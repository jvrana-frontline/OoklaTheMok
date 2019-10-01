using OoklaTheMok.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mime;
using System.Net.Sockets;
using System.Reflection;

//using System.Data.Metadata.Edm;

namespace OoklaTheMok
{
    public class FileGenerator
    {
        public string TableName { get; set; }
        public void GenerateFiles(string tableName)
        {
            TableName = tableName;
            TableDetails td = GetSchema();

            GenerateEntity(td);
            GenerateModel(td);
            GenerateMap(td);
            GenerateMapProfile(td);
            GenerateServiceInterface(td);
            GenerateService(td);
            GenerateController(td);
            GeneratePlmContextLines(td);
            GenerateControllerTests(td);
            GenerateServiceTests(td);
        }

        private object GetValueByPropertyName<T>(T obj, string propertyName)
        {
            PropertyInfo propInfo = typeof(T).GetProperty(propertyName);

            return propInfo.GetValue(obj);
        }

        public TableDetails GetSchema()
        {
            MLPEntities context = new MLPEntities();
            TableDetails td = new TableDetails();
            td.TableName = this.TableName;

            var tblNoteProperties = context
                .GetType()
                .GetProperties()
                .Where(p =>
                    p.PropertyType.IsGenericType &&
                    p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                .Select(p => p.PropertyType.GetGenericArguments()[0])
                .Where(t => t.Name == this.TableName)
                .SelectMany(t => t.GetProperties())
                .ToArray();

            var names = (from t in tblNoteProperties
                         where !t.Name.StartsWith("tbl")
                         select t.Name).ToList();



            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            var entityType = objectContext.MetadataWorkspace.GetItems<EntityType>(DataSpace.CSpace).Where(e => e.Name == td.TableName).First();

            foreach (var col in names)
            {

                FieldDetails f = new FieldDetails();
                f.FieldName = col;
                f.ConvertField();
                var facets = entityType.Properties[col].TypeUsage.Facets;


                var nullable = (from c in facets where c.Name == "Nullable" select c).First();
                if (nullable != null)
                {
                    f.Nullable = (bool)nullable.Value;
                }

                var MaxLength = from c in facets where c.Name == "MaxLength" select c;
                if (MaxLength.Any() && !f.FieldName.StartsWith("txt"))
                {
                    Facet facet = MaxLength.First();
                    if (facet.Value.ToString() == "Max")
                    {
                        f.FieldLengthMax = true;
                    }
                    else
                    {
                        f.FieldLength = Convert.ToInt16(facet.Value);
                        f.FieldLengthMax = false;
                    }
                }
                f.ConvertField();
                //defaults
                switch (f.ModifiedFieldType)
                {
                    case "string":
                        f.DefaultValue = "\"\"";
                        break;
                    case "DateTime":
                    case "DateTime?":
                        f.DefaultValue = "new System.DateTime(1900, 1, 1)";
                        break;
                    case "bool":
                        f.DefaultValue = "true";
                        break;
                    case "int":
                    case "int?":
                    case "float":
                    case "decimal":
                        f.DefaultValue = "0";
                        break;
                    default:
                        f.DefaultValue = "\"\"";
                        break;
                }


                td.Fields.Add(f);

            }

            //foreach (var f in td.Fields)
            //{
            //    f.ConvertField();
            //}
            td.UpdateIdField();

            return td;
        }
        public void GenerateEntity(TableDetails details)
        {
            //generate <tablename>.cs in /Entities/
            string path = $@"c:\Ookla\{details.ClassName}\Entities\{details.ClassName}.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.Entities");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}");
            sb.AppendLine("    {");

            foreach (FieldDetails field in details.Fields)
            {
                sb.AppendLine($"        public {field.ModifiedFieldType} {field.ModifiedFieldName} {{ get; set; }}");
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);

        }
        public void GenerateModel(TableDetails details)
        {
            //generate <tablename>Model.cs in /ViewModels/
            string path = $@"c:\Ookla\{details.ClassName}\ViewModels\{details.ClassName}Model.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using FluentValidation;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.ViewModels");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}Model");
            sb.AppendLine("    {");

            foreach (FieldDetails field in details.Fields)
            {
                sb.AppendLine($"        public {field.ModifiedFieldType} {field.ModifiedFieldName} {{ get; set; }}");
            }

            sb.AppendLine("    }");

            sb.Append(Environment.NewLine);
            sb.AppendLine($"    public class {details.ClassName}ModelValidator : AbstractValidator<{details.ClassName}Model>");
            sb.AppendLine("    {");
            sb.AppendLine($"        public {details.ClassName}ModelValidator()");
            sb.AppendLine("        {");
            foreach (FieldDetails field in details.Fields)
            {
                if (field.ModifiedFieldType == "string" && !field.FieldName.StartsWith("txt") && field.FieldLengthMax == false)
                {
                    sb.AppendLine($"            RuleFor(x => x.{field.ModifiedFieldName}).{field.NullText}().Length(0, {field.FieldLength});");
                }
                else
                {
                    sb.AppendLine($"            RuleFor(x => x.{field.ModifiedFieldName}).{field.NullText}();");
                }
            }
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }
        public void GenerateMap(TableDetails details)
        {
            //generate <tablename>Map.cs in /EntityMaps/
            string path = $@"c:\Ookla\{details.ClassName}\EntityMaps\{details.ClassName}Map.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.AppendLine("using Microsoft.EntityFrameworkCore;");
            sb.AppendLine("using Microsoft.EntityFrameworkCore.Metadata.Builders;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.EntityMaps");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}Map : IEntityTypeConfiguration<{details.ClassName}>");
            sb.AppendLine("    {");
            sb.AppendLine($"        public void Configure(EntityTypeBuilder<{details.ClassName}> builder)");
            sb.AppendLine("        {");
            sb.AppendLine($@"            builder.ToTable(""{details.TableName}"");");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            builder.HasKey(t => t.Id);");
            sb.Append(Environment.NewLine);

            foreach (FieldDetails field in details.Fields)
            {
                sb.AppendLine($@"            builder.Property(e => e.{field.ModifiedFieldName}).HasColumnName(""{field.FieldName}"").HasDefaultValue({field.DefaultValue});");
            }

            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }
        public void GenerateMapProfile(TableDetails details)
        {
            //generate <tablename>MapProfile.cs in /AutoMapper/Profiles/
            string path = $@"c:\Ookla\{details.ClassName}\AutoMapper\Profiles\{details.ClassName}MapProfile.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using AutoMapper;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.ViewModels;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.AutoMapper.Profiles");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}MapProfile : Profile");
            sb.AppendLine("    {");
            sb.AppendLine($"        public {details.ClassName}MapProfile()");
            sb.AppendLine("        {");
            sb.AppendLine($"            CreateMap<{details.ClassName}, {details.ClassName}Model>();");
            sb.AppendLine($"            CreateMap<{details.ClassName}Model, {details.ClassName}>();");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }
        public void GenerateServiceInterface(TableDetails details)
        {
            //generate I<tablename>Service.cs in /Services/Interfaces/
            string path = $@"c:\Ookla\{details.ClassName}\Services\Interfaces\I{details.ClassName}Service.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.Services.Interfaces");
            sb.AppendLine("{");
            sb.AppendLine($"    public interface I{details.ClassName}Service");
            sb.AppendLine("    {");
            sb.AppendLine($"        Task<List<{details.ClassName}>> GetByDistrictIdAsync(int districtId, bool onlyActive = true);");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }
        public void GenerateService(TableDetails details)
        {
            //generate <tablename>Service.cs in /Services/
            string path = $@"c:\Ookla\{details.ClassName}\Services\{details.ClassName}Service.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Services.Interfaces;");
            sb.AppendLine("using Microsoft.EntityFrameworkCore;");
            sb.AppendLine("using Microsoft.Extensions.Logging;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.Services");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}Service : I{details.ClassName}Service");
            sb.AppendLine("    {");

            sb.AppendLine("        private readonly IPlmReadWriteContext _plmDataContext;");
            sb.AppendLine($"        private readonly ILogger<{details.ClassName}Service> _logger;");

            sb.AppendLine($"        public {details.ClassName}Service(IPlmReadWriteContext plmDataContext, ILogger<{details.ClassName}Service> logger)");
            sb.AppendLine("        {");
            sb.AppendLine("            _plmDataContext = plmDataContext;");
            sb.AppendLine("            _logger = logger;");
            sb.AppendLine("        }");

            sb.AppendLine($"        public async Task<List<{details.ClassName}>> GetByDistrictIdAsync(int districtId, bool onlyActive = true)");
            sb.AppendLine("        {");
            sb.AppendLine("            throw new NotImplementedException();");
            sb.AppendLine("            var result = string.Empty; //do stuff here");
            sb.AppendLine("            return result;");
            sb.AppendLine("        }");

            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }
        public void GenerateController(TableDetails details)
        {
            //generate <tablename>Controller.cs in /Controllers/
            string path = $@"c:\Ookla\{details.ClassName}\Controllers\{details.ClassName}Controller.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using AutoMapper;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Services.Interfaces;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.ViewModels;");
            sb.AppendLine("using Microsoft.AspNetCore.Authorization;");
            sb.AppendLine("using Microsoft.AspNetCore.Mvc;");
            sb.AppendLine("using Microsoft.Extensions.Logging;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Net;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.Controllers");
            sb.AppendLine("{");
            sb.AppendLine($@"    [Route(""api/v1/org/{{orgid}}/[controller]"")]");
            sb.AppendLine($@"    [Authorize(Policy = AuthPolicy.UserOrg)]");
            sb.AppendLine($@"    [ApiController]");
            sb.AppendLine($"    public class {details.ClassName}Controller : ControllerBase");
            sb.AppendLine("    {");
            sb.AppendLine($"        private readonly I{details.ClassName}Service _{details.ClassName.ToLower()}Service;");
            sb.AppendLine($"        private readonly ILogger<{details.ClassName}Controller> _logger;");
            sb.AppendLine("        private readonly IMapper _mapper;");
            sb.AppendLine("        private readonly IUserIdentity _userIdentity;");
            sb.AppendLine("        private readonly IUserService _userService;");
            sb.AppendLine("        private readonly IDistrictService _districtService;");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"        public {details.ClassName}Controller(I{details.ClassName}Service {details.ClassName.ToLower()}Service, ILogger<{details.ClassName}Controller> logger,");
            sb.AppendLine("        IMapper mapper, IUserIdentity userIdentity, IUserService userService,");
            sb.AppendLine("        IDistrictService districtService)");
            sb.AppendLine("        {");
            sb.AppendLine($"            _{details.ClassName.ToLower()}Service = {details.ClassName.ToLower()}Service ?? throw new ArgumentNullException(nameof({details.ClassName.ToLower()}Service));");
            sb.AppendLine("            _logger = logger;");
            sb.AppendLine("            _mapper = mapper;");
            sb.AppendLine("            _userIdentity = userIdentity;");
            sb.AppendLine("            _userService = userService;");
            sb.AppendLine("            _districtService = districtService;");
            sb.AppendLine("        }");
            sb.Append(Environment.NewLine);
            sb.AppendLine("        [HttpGet]");
            sb.AppendLine($@"        [ProducesResponseType(typeof(List<{details.ClassName}Model>), (int)HttpStatusCode.OK)]");
            sb.AppendLine(@"        [ProducesResponseType(typeof(BadRequestObjectResult), (int)HttpStatusCode.BadRequest)]");
            sb.AppendLine($@"        async public Task<ActionResult<{details.ClassName}Model>> Get{details.ClassNamePlural}(int orgId, bool onlyActive = true)");
            sb.AppendLine("        {");
            sb.AppendLine("            var district = await _districtService.GetById(orgId, onlyActive);");
            sb.AppendLine($"            if (district == null)");
            sb.AppendLine("            {");
            sb.AppendLine($@"                return BadRequest(""invalid orgId."");");
            sb.AppendLine("            }");
            sb.AppendLine("            else");
            sb.AppendLine("            {");
            sb.AppendLine($"            var {details.ClassName.ToLower()}s = await _{details.ClassName.ToLower()}Service.GetByDistrictIdAsync(district.Id);");
            sb.AppendLine($"            return Ok({details.ClassName.ToLower()}s.Select(d => _mapper.Map<{details.ClassName}Model>(d)).ToList());");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }
        public void GeneratePlmContextLines(TableDetails details)
        {
            //plmContext
            //dbset
            //modelbuilder
            //virtual

            //generate <tablename>Controller.cs in /Controllers/
            string path = $@"c:\Ookla\{details.ClassName}\AdditionalLines.cs";
            StringBuilder sb = new StringBuilder();

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.AppendLine("Add to appropriate sections of PlmContext.cs:");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"        DbSet<{details.ClassName}> {details.ClassNamePlural} {{ get; set; }}");
            sb.AppendLine($"        modelBuilder.ApplyConfiguration(new {details.ClassName}Map());");
            sb.AppendLine($"        public virtual DbSet<{details.ClassName}> {details.ClassNamePlural} {{ get; set; }}");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.AppendLine("Add to appropriate sections of Startup.cs:");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"        services.AddScoped<I{details.ClassName}Service, {details.ClassName}Service>();");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            WriteToFile(sb, path);
        }
        public void GenerateControllerTests(TableDetails details)
        {
            //generate <tablename>ControllerTests.cs in /Tests/Controller/
            string path = $@"c:\Ookla\{details.ClassName}\Tests\Controller\{details.ClassName}ControllerTests.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using AutoMapper;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.AutoMapper;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.AutoMapper.Profiles;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Controllers;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Services.Interfaces;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.ViewModels;");
            sb.AppendLine("using FluentAssertions;");
            sb.AppendLine("using Microsoft.AspNetCore.Mvc;");
            sb.AppendLine("using Microsoft.Extensions.Logging;");
            sb.AppendLine("using Moq;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using Xunit;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.Tests.Controller");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}ControllerTest : ControllerTest<{details.ClassName}Controller, I{details.ClassName}Service>");
            sb.AppendLine("    {");
            sb.AppendLine($"        private readonly {details.ClassName}Controller _controller;");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"        public {details.ClassName}ControllerTest()");
            sb.AppendLine("        {");
            sb.AppendLine($"            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new {details.ClassName}MapProfile()));");
            sb.AppendLine("            var mapper = new Mapper(mapperConfig);");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"            _controller = new {details.ClassName}Controller(");
            sb.AppendLine("                _mockService.Object,");
            sb.AppendLine("                _mockLogger.Object,");
            sb.AppendLine("                mapper,");
            sb.AppendLine("                _mockUserIdentity.Object,");
            sb.AppendLine("                _mockUserService.Object,");
            sb.AppendLine("                _mockDistrictService.Object);");
            sb.AppendLine("        }");
            sb.Append(Environment.NewLine);
            sb.AppendLine("        [Fact]");
            sb.AppendLine("        public void HappyPathInitializeTest()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Arrange");
            sb.AppendLine($"            Action ac = () => new {details.ClassName}Controller(");
            sb.AppendLine($"                new Mock<I{details.ClassName}Service>().Object,");
            sb.AppendLine($"                new Mock<ILogger<{details.ClassName}Controller>>().Object,");
            sb.AppendLine("                new Mock<IMapper>().Object,");
            sb.AppendLine("                new Mock<IUserIdentity>().Object,");
            sb.AppendLine("                new Mock<IUserService>().Object,");
            sb.AppendLine("                new Mock<IDistrictService>().Object);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            // Act and Assert");
            sb.AppendLine("            ac.Should().NotThrow();");
            sb.AppendLine("        }");
            sb.Append(Environment.NewLine);
            sb.AppendLine("        [Fact]");
            sb.AppendLine($"        public void Initialize_Should_Throw_With_Missing_{details.ClassName}Service()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Arrange");
            sb.AppendLine($"            Action ac = () => new {details.ClassName}Controller(null,");
            sb.AppendLine($"                new Mock<ILogger<{details.ClassName}Controller>>().Object,");
            sb.AppendLine("                new Mock<IMapper>().Object,");
            sb.AppendLine("                new Mock<IUserIdentity>().Object,");
            sb.AppendLine("                new Mock<IUserService>().Object,");
            sb.AppendLine("                new Mock<IDistrictService>().Object);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            // Act and Assert");
            sb.AppendLine($@"            ac.Should().ThrowExactly<ArgumentNullException>().Where(ex => ex.ParamName == ""{details.ClassName.ToLower()}Service"");");
            sb.AppendLine("        }");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"        #region Get{details.ClassNamePlural}");
            sb.Append(Environment.NewLine);
            sb.AppendLine("        [Fact]");
            sb.AppendLine($"        public async Task Get{details.ClassNamePlural}_ReturnsModels()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Arrange");
            sb.AppendLine("            var orgId = 12345;");
            sb.AppendLine("            var districtId = 10020;");
            sb.AppendLine($"            var entities = new List<{details.ClassName}>()");
            sb.AppendLine("            {");
            sb.AppendLine($"                new {details.ClassName}(){{Id = 1}}");
            sb.AppendLine("            };");
            sb.AppendLine("            var user = new User() { IsSysAdmin = true };");
            sb.AppendLine("            var district = new District() { Id = districtId, FlOrgId = orgId };");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            _mockUserIdentity.SetupGet(m => m.OrgIds).Returns(new[] { orgId });");
            sb.AppendLine("            _mockUserService.Setup(m => m.GetByIdAndOrgAsync(It.IsAny<IEnumerable<int>>(), It.IsAny<int>())).ReturnsAsync(user);");
            sb.AppendLine("            _mockDistrictService.Setup(m => m.GetById(It.IsAny<int>(), It.IsAny<bool>())).ReturnsAsync(district);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            _mockService.Setup(m => m.GetByDistrictIdAsync(It.IsAny<int>())).ReturnsAsync(entities);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            // Act");
            sb.AppendLine($"            var response = await _controller.Get{details.ClassNamePlural}(orgId);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            // Assert");
            sb.AppendLine("            response.Result.Should().BeOfType<OkObjectResult>()");
            sb.AppendLine($"                .Which.Value.Should().BeOfType<List<{details.ClassName}Model>>();");
            sb.AppendLine("        }");
            sb.AppendLine("        [Fact]");
            sb.AppendLine("        public async Task Get_WithInvalidDistrictId_ReturnsBadRequest()");
            sb.AppendLine("        {");
            sb.AppendLine("            // Arrange");
            sb.AppendLine("            var orgId = 999999;");
            sb.AppendLine("            var districtId = 999999;");
            sb.AppendLine($"            var entities = new List<{details.ClassName}>()");
            sb.AppendLine("            {");
            sb.AppendLine($"                new {details.ClassName}()");
            sb.AppendLine("                {");
            sb.AppendLine("                    Id = 1,");
            sb.AppendLine("                    Active = true");
            sb.AppendLine("                }");
            sb.AppendLine("            };");
            sb.AppendLine("            var user = new User() { IsSysAdmin = true };");
            sb.AppendLine("            District district = null;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            _mockUserIdentity.SetupGet(m => m.OrgIds).Returns(new[] { orgId });");
            sb.AppendLine("            _mockUserService.Setup(m => m.GetByIdAndOrgAsync(It.IsAny<IEnumerable<int>>(), It.IsAny<int>())).ReturnsAsync(user);");
            sb.AppendLine("            _mockDistrictService.Setup(m => m.GetById(It.IsAny<int>(), It.IsAny<bool>())).ReturnsAsync(district);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            _mockService.Setup(m => m.GetByDistrictIdAsync(It.IsAny<int>(), true)).ReturnsAsync(entities);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            // Act");
            sb.AppendLine($"            var response = await _controller.Get{details.ClassNamePlural}(orgId);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            // Assert");
            sb.AppendLine("            response.Result.Should().BeOfType<BadRequestObjectResult>();");
            sb.Append(Environment.NewLine);
            sb.AppendLine("        }");
            sb.AppendLine("        #endregion");
            sb.AppendLine("    }");
            sb.AppendLine("}");


            WriteToFile(sb, path);
        }
        public void GenerateServiceTests(TableDetails details)
        {
            //generate <tablename>ServiceTests.cs in /Tests/Services/
            string path = $@"c:\Ookla\{details.ClassName}\Tests\Services\{details.ClassName}ServiceTests.cs";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Entities;");
            sb.AppendLine("using FL.PG.PLM_EEM_API.Services;");
            sb.AppendLine("using FluentAssertions;");
            sb.AppendLine("using System.Threading.Tasks;");
            sb.AppendLine("using Xunit;");
            sb.Append(Environment.NewLine);
            sb.AppendLine("namespace FL.PG.PLM_EEM_API.Tests.Services");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {details.ClassName}ServiceTests : ServiceTest<{details.ClassName}Service>");
            sb.AppendLine("    {");
            sb.AppendLine($"        private readonly {details.ClassName}Service _service;");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"        public {details.ClassName}ServiceTests()");
            sb.AppendLine("        {");
            sb.AppendLine($"            _service = new {details.ClassName}Service(_readWriteContext, _logger.Object);");
            sb.AppendLine("        }");
            sb.Append(Environment.NewLine);
            sb.AppendLine("        [Fact]");
            sb.AppendLine($"        public async Task GetByDistrictIdAsync_Returns{details.ClassNamePlural}()");
            sb.AppendLine("        {");
            sb.AppendLine("            //Arrange");
            sb.AppendLine("            var districtId = 12345;");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"            var {details.ClassName}Entities = new List<{details.ClassName}>");
            sb.AppendLine("            {");
            sb.AppendLine($@"                new {details.ClassName}{{Id = 1001 , {details.ClassName}Name = ""test name 1""}},");
            sb.AppendLine($@"                new {details.ClassName}{{Id = 1002, {details.ClassName}Name = ""test name 2""}},");
            sb.AppendLine($@"                new {details.ClassName}{{Id = 1003, {details.ClassName}Name = ""test name 3""}},");
            sb.AppendLine($@"                new {details.ClassName}{{Id = 1004 , {details.ClassName}Name = ""test name 4""}}");
            sb.AppendLine("            };");
            sb.Append(Environment.NewLine);
            sb.AppendLine($"            _readWriteContext.{details.ClassNamePlural}.AddRange({details.ClassName}Entities);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            _readWriteContext.SaveChanges();");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            //Act");
            sb.AppendLine("            var result = await _service.GetByDistrictIdAsync(districtId);");
            sb.Append(Environment.NewLine);
            sb.AppendLine("            //Assert");
            sb.AppendLine("            result.Should().HaveCount(4);");
            sb.AppendLine($"            result.Should().BeOfType(typeof(List<{details.ClassName}>));");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            WriteToFile(sb, path);
        }

        public void WriteToFile(StringBuilder sb, string path)
        {
            FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            System.IO.File.WriteAllText(file.FullName, sb.ToString());
        }
    }
}

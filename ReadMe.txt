Work Log

******************************************************
Power Point  and Video (Pluralsight)
Building a Web App with ASP.NET Core, MVC, Entity Framework Core, Bootstrap, and Angular
******************************************************

******************************************************
CheckList - Creating Enities (ref Video) pp166
******************************************************

******************************************************
Task#1 Tooling EF Core
******************************************************
TODO: Check versions and update
File: PopCorn.csproj

<ItemGroup>
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />
</ItemGroup>
******************************************************END

******************************************************
Task #1	 Define the context and database type and Connection string
******************************************************
 // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
  =>        services.AddDbContext<MaterialsContext>(cfg => cfg.UseSqlServer(connectionString: "MaterialDataConnection"));
            services.AddMvc();
        }
System.ArgumentException: 'AddDbContext was called with configuration, but the context type 'MaterialsContext' 
only declares a parameterless constructor. This means that the configuration passed to AddDbContext will never be used. 
If configuration is passed to AddDbContext, then 'MaterialsContext' should declare a 
constructor that accepts a DbContextOptions<MaterialsContext> and must pass it to the base constructor for DbContext.'

******************************************************
Task #2 Define the context and database type and Connection string
******************************************************
Add config.json file with connection string 
"server=(localdb)\\MSSQLLocalDB;Database=MaterialData;Integrated Security=true;MultipleActiveResultSets=true;"

******************************************************
Task #3 Define the context and database type and Connection string
******************************************************
//Adding Configuration DI Constructor and using it...

// This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
=>          services.AddDbContext<MaterialsContext>(cfg => cfg.UseSqlServer(Configuration.GetConnectionString("MaterialDataConnection")));    
            services.AddMvc();
        }
System.ArgumentException: 'AddDbContext was called with configuration, but the context type 'MaterialsContext' 
only declares a parameterless constructor. This means that the configuration passed to AddDbContext will never be used. 
If configuration is passed to AddDbContext, then 'MaterialsContext' should declare a constructor that accepts a 
DbContextOptions<MaterialsContext> and must pass it to the base constructor for DbContext.'

//Update MaterialsContext Constructor...

 public class MaterialsContext : DbContext
    {
        public MaterialsContext(DbContextOptions options):base(options)
        {
        }

// running without errors connected
// The program '[10932] iisexpress.exe' has exited with code 0 (0x0).
******************************************************END

******************************************************
Commit: Add Database connection
******************************************************

******************************************************
CheckList - Using a DbContext Class (ref Video) pp196
******************************************************
//Build out HomeController...IActionResult TRF()...route: http://localhost:63287/home/TRF

******************************************************
Task #1: Configure MailService
******************************************************
Add Services> IMAilService and NullMailService

// This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
=>          services.AddTransient<IMailService, NullMailService>();
            //TODO: Support for real mail service

******************************************************
Task#2 DI into controller 
******************************************************
public HomeController(IMailService mailService, MaterialsContext context)
        {
            _mailService = mailService;
            _context = context;
        }
Error: return null
Fix:
public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(SetupConfiguration) // Fix       
                .UseStartup<Startup>()
                .Build();

private static void SetupConfiguration(WebHostBuilderContext context, IConfigurationBuilder builder)
{
    builder.Sources.Clear();
    builder
        .AddJsonFile("config.json", false, true)
        .AddXmlFile("config.xml", true);
}
***end fix

******************************************************
Commit: Add Controller Home/TRF action (no repository)
******************************************************

******************************************************
Checklist - ADD api/trf TRFcontroller (simple)
******************************************************
Ref - Checklist: How to create the API pp263

Task #1:	Add [Route("api/[Controller]")] to class 
Task #2:	Add [HttpGet]
Task #3:	Test with Postman

	[Route("api/[Controller]")]
    public class TRFController : Controller
    {
        private readonly IMaterialsRepository _repository;
        private readonly ILogger<TRFController> _logger;

        public TRFController(IMaterialsRepository repository, ILogger<TRFController> logger )
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var TRFs = _repository.GetAllTRFs();

            if (TRFs != null)
            {
                return Ok(TRFs.ToList());
            }
            return NotFound();
        }   
    }
****End






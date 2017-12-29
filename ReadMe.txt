Work Log
CheckList - entity Framework Core (ref Video)
******************************************************
Task# Tooling EF Core
******************************************************
TODO: Check versions and update
File: PopCorn.csproj

<ItemGroup>
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />
</ItemGroup>
******************************************************

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
******************************************************
Commit: Add Database connection
******************************************************




using Microsoft.EntityFrameworkCore;

namespace Popcorn.Entities
{
    public partial class MaterialData : DbContext
    {
        public DbSet<Adhesive> Adhesives { get; set; }
        public DbSet<Composite> Composites { get; set; }
        public DbSet<Curve_Data> Curve_Data { get; set; }
        public DbSet<Fastener_Data> Fastener_Data { get; set; }
        public DbSet<Fastener_Sheet> Fastener_Sheet { get; set; }
        public DbSet<Joint_Strength> Joint_Strength { get; set; }
        public DbSet<Nr> Nrs { get; set; }
        public DbSet<Nut> Nuts { get; set; }
        public DbSet<SNCurve> SNCurves { get; set; }
        public DbSet<SS_LinkTable> SS_LinkTable { get; set; }
        public DbSet<TRF> TRFs { get; set; }
        public DbSet<TRF_LinkTable> TRF_LinkTable { get; set; }   
    }
}

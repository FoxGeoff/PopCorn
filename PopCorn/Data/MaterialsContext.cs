using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Popcorn.Data.Entities;
using Popcorn.Entities;

namespace Popcorn.Data
{
    public class MaterialsContext : DbContext
    {
        public MaterialsContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Adhesive> Adhesives { get; set; }
        public DbSet<Bolt> Bolts { get; set; }
        public DbSet<Composite> Composites { get; set; }
        public DbSet<Curve_Data> Curve_Data { get; set; }
        public DbSet<Curve_Description> Curve_Description { get; set; }
        public DbSet<Fastener> Fasteners { get; set; }
        public DbSet<Fastener_Data> Fastener_Data { get; set; }
        public DbSet<Fastener_MatGroup> Fastener_MatGroup { get; set; }
        public DbSet<Fastener_Sheet> Fastener_Sheet { get; set; }
        public DbSet<Joint_Strength> Joint_Strength { get; set; }
        public DbSet<Material> Materials { get; set; }

        internal IEnumerable<TRF> OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public DbSet<Material_LinkNotes> Material_LinkNotes { get; set; }
        public DbSet<Material_Properties> Material_Properties { get; set; }
        public DbSet<Material_PropNotes> Material_PropNotes { get; set; }
        public DbSet<Material_XtraProp> Material_XtraProp { get; set; }
        public DbSet<Nr> Nrs { get; set; }
        public DbSet<Nut> Nuts { get; set; }
        public DbSet<SNCurve> SNCurves { get; set; }
        public DbSet<SS_LinkTable> SS_LinkTable { get; set; }
        public DbSet<TRF> TRFs { get; set; }                        //TODO: Get this data as JSON    
        public DbSet<TRF_LinkTable> TRF_LinkTable { get; set; }     //TODO: Get this data as JSON
    }
}

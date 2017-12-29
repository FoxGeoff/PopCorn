namespace Popcorn.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Joint_Strength
    {
        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(10)]
        public string JS_ID { get; set; }

        [StringLength(30)]
        public string Fastener_Specification { get; set; }

        [StringLength(5)]
        public string Fastener_Diameter { get; set; }

        public short? Psu { get; set; }

        [StringLength(30)]
        public string MatRef { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        public short? T_010 { get; set; }

        public short? T_012 { get; set; }

        public short? T_016 { get; set; }

        public short? T_020 { get; set; }

        public short? T_025 { get; set; }

        public short? T_032 { get; set; }

        public short? T_040 { get; set; }

        public short? T_050 { get; set; }

        public short? T_063 { get; set; }

        public short? T_071 { get; set; }

        public short? T_080 { get; set; }

        public short? T_090 { get; set; }

        public short? T_100 { get; set; }

        public short? T_125 { get; set; }

        public short? T_160 { get; set; }

        public short? T_190 { get; set; }

        public short? T_250 { get; set; }

        public short? T_312 { get; set; }

        public short? T_375 { get; set; }

        public short? T_433 { get; set; }

        [StringLength(10)]
        public string FastenerID { get; set; }

        [StringLength(5)]
        public string FTID { get; set; }

        [StringLength(255)]
        public string Footnote { get; set; }

        public int KeyCol { get; set; }

        public int Id { get; set; }
    }
}

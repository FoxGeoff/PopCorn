namespace Popcorn.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Material_XtraProp
    {
        [StringLength(20)]
        public string AMatID { get; set; }

        [StringLength(3000)]
        public string FtGoodrich { get; set; }

        public int Id { get; set; }
    }
}

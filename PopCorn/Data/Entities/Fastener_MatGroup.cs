using System.ComponentModel.DataAnnotations;

namespace Popcorn.Data.Entities
{
    public class Fastener_MatGroup
    {
        [StringLength(10)]
        public string MatGroup { get; set; }

        [StringLength(20)]
        public string MatID { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int Id { get; set; }
    }
}

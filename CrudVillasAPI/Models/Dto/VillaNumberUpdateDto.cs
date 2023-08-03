using System.ComponentModel.DataAnnotations;

namespace CrudVillasAPI.Models.Dto
{
    public class VillaNumberUpdateDto
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetail { get; set; }
    }
}

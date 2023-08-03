using System.ComponentModel.DataAnnotations;

namespace CrudVillasAPI.Models.Dto
{
    public class VillaNumberDto
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetail { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CrudVillasAPI.Models.Dto
{
    public class VillaCreateDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Detail { get; set; }
        [Required]
        public double Fee { get; set; }
        public int Occupants { get; set; }
        public int SquareMeter { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}

using CrudVillasAPI.Models.Dto;

namespace CrudVillasAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        { 
            new VillaDto{Id=1, Name="Vista a la Piscina", Occupants=3, SquareMeter=50},
            new VillaDto{Id=2,Name="Vista a la Playa", Occupants=4, SquareMeter=80}
        };
    }
}
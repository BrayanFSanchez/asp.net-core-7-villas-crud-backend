using CrudVillasAPI.Data;
using CrudVillasAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudVillasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villaList;
        }


        [HttpGet("id:int")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(v=> v.Id == id);
        }
    }
}

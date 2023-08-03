using AutoMapper;
// using CrudVillasAPI.Data;
using CrudVillasAPI.Models;
using CrudVillasAPI.Models.Dto;
using CrudVillasAPI.Repository.IRepository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;
// using Microsoft.EntityFrameworkCore;

namespace CrudVillasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaNumberController : ControllerBase
    {
        private readonly ILogger<VillaNumberController> _logger;
        private readonly IVillaRepository _villaRepo;
        private readonly IVillaNumberRepository _numberRepo;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        public VillaNumberController(ILogger<VillaNumberController> logger, IVillaRepository villaRepo, IVillaNumberRepository numberRepo, IMapper mapper)
        {
            _logger = logger;
            _villaRepo = villaRepo;
            _numberRepo = numberRepo;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber()
        {
            try
            {
                _logger.LogInformation("Obtener el número de villas");

                IEnumerable<VillaNumber> villaNumberList = await _numberRepo.GetAll();

                _response.Result = _mapper.Map<IEnumerable<VillaNumberDto>>(villaNumberList);
                _response.statusCode = HttpStatusCode.OK;

                return Ok(_response);
}
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("id:int", Name="GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber(int id)
        {
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Error al traer el número de la Villa con Id " + id);
                    _response.statusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                // var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
                var villaNumber = await _numberRepo.Get(x => x.VillaNo == id);

                if (villaNumber == null)
                {
                    _response.statusCode = HttpStatusCode.NotFound;
                    _response.IsSuccessful = false;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<VillaNumberDto>(villaNumber);
                _response.statusCode = HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }

            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumber([FromBody] VillaNumberCreateDto createDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if(await _numberRepo.Get(v=>v.VillaNo == createDto.VillaNo) != null)
                {
                    ModelState.AddModelError("NameExist", "El número de la Villa ya existe");
                    return BadRequest(ModelState);
                }

                if (await _villaRepo.Get(v => v.Id == createDto.VillaId) == null)
                {
                    ModelState.AddModelError("ForeignKey", "El Id de la Villa no existe");
                    return BadRequest(ModelState);
                }

                if(createDto == null)
                {
                    return BadRequest(createDto);
                }

                VillaNumber model = _mapper.Map<VillaNumber>(createDto);

                model.CreationDate = DateTime.Now;
                model.UpdateDate = DateTime.Now;
                await _numberRepo.Create(model);
                _response.Result = model;
                _response.statusCode = HttpStatusCode.Created;

                return CreatedAtRoute("GetVillaBumber", new { id = model.VillaNo }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVillaNumber(int id)
        {
            try
            {
                if(id == 0)
                {
                    _response.IsSuccessful = false;
                    _response.statusCode = HttpStatusCode.BadRequest; 
                    return BadRequest(_response);
                }

                var villaNumber = await _numberRepo.Get(v => v.VillaNo == id);
                if(villaNumber == null)
                {
                    _response.IsSuccessful = false;
                    _response.statusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _numberRepo.Remove(villaNumber);

                _response.statusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return BadRequest(_response);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVillaNumber(int id, [FromBody] VillaNumberUpdateDto updateDto)
        {
            if(updateDto == null || id != updateDto.VillaNo)
            {
                _response.IsSuccessful = false;
                _response.statusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }

            if (await _villaRepo.Get(v => v.Id == updateDto.VillaId) == null)
            {
                ModelState.AddModelError("ForeignKey", "El id de la villa no existe");
                return BadRequest(ModelState);
            }

            VillaNumber model = _mapper.Map<VillaNumber>(updateDto);

            await _numberRepo.Upddate(model);
            _response.statusCode=HttpStatusCode.NoContent;

            return Ok(_response);
        }
    }
}

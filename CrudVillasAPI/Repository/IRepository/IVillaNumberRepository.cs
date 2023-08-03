using CrudVillasAPI.Models;

namespace CrudVillasAPI.Repository.IRepository
{
    public interface IVillaNumberRepository: IRepository<VillaNumber>
    {
        Task<VillaNumber> Upddate(VillaNumber entity);
    }
}
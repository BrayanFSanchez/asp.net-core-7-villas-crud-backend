using CrudVillasAPI.Models;

namespace CrudVillasAPI.Repository.IRepository
{
    public interface IVillaRepository: IRepository<Villa>
    {
        Task<Villa> Upddate(Villa entity);
    }
}
using CrudVillasAPI.Models;
using CrudVillasAPI.Data;
using CrudVillasAPI.Repository.IRepository;

namespace CrudVillasAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }

        public async Task<Villa> Upddate(Villa entity)
        {
            entity.updateDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

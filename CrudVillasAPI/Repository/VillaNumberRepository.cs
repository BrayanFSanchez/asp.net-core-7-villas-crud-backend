using CrudVillasAPI.Models;
using CrudVillasAPI.Data;
using CrudVillasAPI.Repository.IRepository;

namespace CrudVillasAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }

        public async Task<VillaNumber> Upddate(VillaNumber entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

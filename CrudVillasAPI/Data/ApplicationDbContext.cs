using CrudVillasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudVillasAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        public DbSet<Villa> Villas {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Villa Real",
                    Detail = "Detalle de la Villa",
                    ImageUrl= "",
                    Occupants = 5,
                    SquareMeter = 50,
                    Fee=200,
                    Amenity = "",
                    creationDate = DateTime.Now,
                    updateDate= DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Villa elegante",
                    Detail = "Detalle de la Villa",
                    ImageUrl = "",
                    Occupants = 4,
                    SquareMeter = 40,
                    Fee = 150,
                    Amenity = "",
                    creationDate = DateTime.Now,
                    updateDate = DateTime.Now,
                }
            );
        }
    }
}

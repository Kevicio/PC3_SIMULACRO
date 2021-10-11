using Microsoft.EntityFrameworkCore;
using PC3_SIMULACRO.Models;



namespace PC3_SIMULACRO.Data
{
    public class AdopcionContext : DbContext
    {
        public DbSet<SolicitudAdopcion> SolicitudesAdopcion { 
            get;
            set;
        }

        public AdopcionContext(DbContextOptions dco) : base(dco){

        }
    }
}
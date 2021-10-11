using Microsoft.EntityFrameworkCore;



namespace PC3_SIMULACRO.Data
{
    public class AdopcionContext : DbContext
    {
        public DbSet<Models.SolicitudAdopcion> SolicitudesAdopcion { 
            get;
            set;
        }

        public AdopcionContext(DbContextOptions dco) : base(dco){

        }
    }
}
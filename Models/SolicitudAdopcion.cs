using System.ComponentModel.DataAnnotations;

namespace PC3_SIMULACRO.Models
{
    public class SolicitudAdopcion
    {

        public int Id{
            get;
            set;
        }

        [Required(ErrorMessage = "Por favor ingresar su Nombre")] 
        public string NombreCompleto{
            get;
            set;
        }
        
        [Required]
        public string Direccion{
            get;
            set;
        }

        public string Descripcion{
            get;
            set;
        }

        [Required]
        public string Celular{
            get;
            set;
        }

        [EmailAddress]
        [Required]
        public string Email{
            get;
            set;
        }
  
        
    }
}
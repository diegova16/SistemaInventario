using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [MaxLength(60, ErrorMessage = "La longitud máxima de Nombre es 60 caracteres")]
        public String Nombre { get; set; }


        [Required(ErrorMessage = "Descripción es requerido")]
        [MaxLength(60, ErrorMessage = "La longitud máxima de Descripción es 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerido")]
        public bool Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaUTH.Models
{
    public class Clase
    {
        public int claseID { get; set; }

        //Nombre
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El minimo de letras permitido son 3 y maximo 50")]
        public string Name { get; set; }

        //Descripcion
        [StringLength(250, ErrorMessage = "Te sugerimos que incluya descripcion")]
        public string Descripcion { get; set; }
        //Mestro
        [StringLength(250, ErrorMessage = "Te sugerimos que incluya descripcion")]
        public string Maestro { get; set; }

        //Turno
        [StringLength(50, ErrorMessage = "Te sugerimos que incluya descripcion")]
        public string turno { get; set; }

        public Boolean State { get; set; } = true;
    }
}

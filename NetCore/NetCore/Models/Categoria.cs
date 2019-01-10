using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="El nombre debe de tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage ="La descripcion no debe exceder los 256 caracteres")]
        //en las etiquetas que se haga referencia mostrara descripcion con tilde
        [Display(Name ="Descripción")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}

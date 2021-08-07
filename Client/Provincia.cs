using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Tarea9_Form_Vacunate.Client
{
   public class Provincia
  {
    [Key]
    public int id { get; set; }
    [Required]
    public string Nombre { get; set; }

   }
}

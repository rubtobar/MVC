using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}

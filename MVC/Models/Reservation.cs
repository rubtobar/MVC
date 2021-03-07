using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public string Client { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaReserva { get; set; }

        [Column(TypeName = "money")]
        public decimal Prince { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}

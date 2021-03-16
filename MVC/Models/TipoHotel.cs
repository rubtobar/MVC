using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class TipoHotel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int asdf(int a) {
            return a + 1;
        }
    }
}
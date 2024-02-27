using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Park2024.Models
{
    [Table(name: "korisnik")]
    public class Korisnik
    {
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual IList<Zalbi> Zalbi { get; set; }
    }
}

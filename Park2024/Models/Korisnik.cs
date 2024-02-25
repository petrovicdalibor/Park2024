using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Park2024.Models
{
    [Table(name: "korisnik")]
    public class Korisnik
    {
        [Key, ForeignKey("User")]
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Park2024.Models
{
    [Table(name:"sopstvenik")]
    public class Sopstvenik
    {
        [Key, ForeignKey("User")] 
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual IList<Parking> Parkings { get; set; }
    }
}

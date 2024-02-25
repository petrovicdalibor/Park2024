using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Park2024.Models
{
  
    public class Sopstvenik
    {
        [Key, ForeignKey("User")] 
        public string Id { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}

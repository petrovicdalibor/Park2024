using Microsoft.AspNetCore.Identity;

namespace Park2024.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string Ime { get; set; }
		public string Telefon { get; set; }

		public virtual Korisnik Korisnik { get; set; }
		public virtual Sopstvenik Sopstvenik { get; set;}
	}
}

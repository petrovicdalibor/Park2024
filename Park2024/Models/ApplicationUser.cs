using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Park2024.Models
{
	[Table(name:"profil")]
	public class ApplicationUser : IdentityUser<int>
	{
		public string Ime { get; set; }
		public string Telefon { get; set; }

		public virtual Korisnik Korisnik { get; set; }
		public virtual Sopstvenik Sopstvenik { get; set;}
	}
}

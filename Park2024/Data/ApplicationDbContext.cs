using System.Collections.Immutable;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Park2024.Models;

namespace Park2024.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Korisnik> Korisnici { get; set; }
		public DbSet<Sopstvenik> Sopstvenici { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.HasDefaultSchema("Identity");
			builder.Entity<IdentityUser>(e =>
			{
				e.ToTable(name: "User");
			});
            builder.Entity<IdentityRole>(e =>
            {
                e.ToTable("Role");
            });

            builder.Entity<IdentityUserRole<string>>(e =>
			{
				e.ToTable("UserRoles");
			});
			builder.Entity<IdentityUserClaim<string>>(e =>
			{
				e.ToTable("UserClaims");
			});
			builder.Entity<IdentityUserLogin<string>>(e =>
			{
				e.ToTable("UserLogins");
			});
			builder.Entity<IdentityRoleClaim<string>>(e =>
			{
				e.ToTable("RoleClaims");
			});
			builder.Entity<IdentityUserToken<string>>(e =>
			{
				e.ToTable("UserTokens");
			});
		}
	}
}

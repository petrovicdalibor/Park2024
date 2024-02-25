using System.Collections.Immutable;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Park2024.Models;

namespace Park2024.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
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
			builder.HasDefaultSchema("INDO_183284_183269");
			builder.Entity<IdentityUser<int>>(e =>
			{
				e.ToTable(name: "profil");
			});
            builder.Entity<IdentityRole<int>>(e =>
            {
                e.ToTable("Role");
            });

            builder.Entity<IdentityUserRole<int>>(e =>
			{
				e.ToTable("UserRoles");
			});
			builder.Entity<IdentityUserClaim<int>>(e =>
			{
				e.ToTable("UserClaims");
			});
			builder.Entity<IdentityUserLogin<int>>(e =>
			{
				e.ToTable("UserLogins");
			});
			builder.Entity<IdentityRoleClaim<int>>(e =>
			{
				e.ToTable("RoleClaims");
			});
			builder.Entity<IdentityUserToken<int>>(e =>
			{
				e.ToTable("UserTokens");
			});
            builder.Entity<Korisnik>(e =>
            {
                e.ToTable("korisnik");
            });
            builder.Entity<Sopstvenik>(e =>
            {
                e.ToTable("sopstvenik");
                e.HasMany(e => e.Parkings)
                    .WithOne(e => e.Sopstvenik);
            });

            builder.Entity<Parking>(e =>
            {
                e.HasOne(e => e.Sopstvenik)
                    .WithMany(e => e.Parkings)
                    .HasForeignKey(e => e.Sopstvenik_Id)
                    .IsRequired();
            });
        }
	}
}

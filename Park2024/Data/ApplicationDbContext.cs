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
        public DbSet<Parking> Parkings { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.HasDefaultSchema("INDO_183284_183269");
			builder.Entity<IdentityUser<int>>(e =>
			{
            });
            builder.Entity<ApplicationUser>(e =>
            {
                e.ToTable("profil");
                e.Property(e => e.Id).HasColumnName("id");
                e.Property(e => e.Ime).HasColumnName("ime");
                e.Property(e => e.Telefon).HasColumnName("telefon");

                e.HasOne(e => e.Korisnik)
                    .WithOne(e => e.User)
                    .HasForeignKey<Korisnik>(e => e.Id);

                e.HasOne(e => e.Sopstvenik)
                    .WithOne(e => e.User)
                    .HasForeignKey<Sopstvenik>(e => e.Id);
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
                e.Property(e => e.Id).HasColumnName("id");

                e.HasOne(e => e.User)
                    .WithOne(e => e.Korisnik)
                    .HasForeignKey<Korisnik>(e => e.Id);

                e.HasMany(e => e.Zalbi)
                    .WithOne(e => e.Korisnik)
                    .HasForeignKey(e => e.korisnik_id);
            });
            builder.Entity<Sopstvenik>(e =>
            {
                e.ToTable("sopstvenik");
                e.Property(e => e.Id).HasColumnName("id");

                e.HasOne(e => e.User)
                    .WithOne(e => e.Sopstvenik)
                    .HasForeignKey<Sopstvenik>(e => e.Id);

                e.HasMany(e => e.Parkings)
                    .WithOne(e => e.Sopstvenik)
                    .HasForeignKey(e => e.Sopstvenik_Id);
            });

            builder.Entity<Parking>(e =>
            {
                e.ToTable("parking")
                    .Property(e => e.Id)
                    .HasColumnName("id");
                e.Property(e => e.Sopstvenik_Id)
                    .HasColumnName("sopstvenik_id");
                e.Property(e => e.Ulica).HasColumnName("ulica");
                e.Property(e => e.Cena).HasColumnName("cena");
                e.Property(e => e.Br_Mesta).HasColumnName("br_mesta");
                e.Property(e => e.Zona_Id).HasColumnName("zona_id");
                e.Property(e => e.Grad_Id).HasColumnName("grad_id");

                e.HasOne(e => e.Sopstvenik)
                    .WithMany(e => e.Parkings)
                    .HasForeignKey(e => e.Sopstvenik_Id);

                e.HasOne(e => e.Zona)
                    .WithMany(e => e.Parkings)
                    .HasForeignKey(e => e.Zona_Id);

                e.HasOne(e => e.Grad)
                    .WithMany(e => e.Parkings)
                    .HasForeignKey(e => e.Grad_Id);
            });

            //builder.Entity<Zona>(e =>
            //{
            //    e.ToTable("zona");
            //    e.HasKey(e => e.id);
            //    e.HasMany(e => e.Parkings)
            //        .WithOne(e => e.Zona)
            //        .HasForeignKey(e => e.Zona_Id);
            //});

            //builder.Entity<Grad>(e =>
            //{
            //    e.ToTable("grad");
            //    e.HasKey(e => e.id);
            //    e.HasMany(e => e.Parkings)
            //        .WithOne(e => e.Grad)
            //        .HasForeignKey(e => e.Grad_Id);
            //});

            //builder.Entity<Zalbi>(e =>
            //{
            //    e.ToTable("zalbi");
            //    e.HasKey(e => e.id);
            //    e.HasOne(e => e.Parking);
            //    e.HasOne(e => e.Korisnik);
            //});
        }
	}
}

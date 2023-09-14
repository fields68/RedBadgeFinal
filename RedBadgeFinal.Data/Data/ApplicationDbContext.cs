using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedBadgeFinal.Data.Entities;

namespace RedBadgeFinal.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        //public DbSet<CharacterWeapon> CharacterWeapons { get; set; }
        public DbSet<Region> Regions { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
            builder.Entity<Element>().HasData(
                    new Element
                    { 
                        Id = 1,
                        Type = "Anemo"
                    },
					new Element
					{
						Id = 2,
						Type = "Cryo"
					},
					new Element
					{
						Id = 3,
						Type = "Electro"
					},
					new Element
					{
						Id = 4,
						Type = "Dendro"
					},
					new Element
					{
						Id = 5,
						Type = "Geo"
					},
					new Element
					{
						Id = 6,
						Type = "Hydro"
					},
					new Element
					{
						Id = 7,
						Type = "Pyro"
					}
				);
			builder.Entity<Region>().HasData(
					new Region
					{
						Id = 1,
						Name = "Mondstadt",
					},
					new Region
					{
						Id = 2,
						Name = "Liyue",
					},
					new Region
					{
						Id = 3,
						Name = "Inazuma",
					},
					new Region
					{
						Id = 4,
						Name = "Sumeru",
					},
					new Region
					{
						Id = 5,
						Name = "Fontaine",
					},
					new Region
					{
						Id = 6,
						Name = "Natlan",
					},
					new Region
					{
						Id = 7,
						Name = "Snezhnaya",
					}
				);
			builder.Entity<Weapon>().HasData(
					new Weapon
					{
						Id = 1,
						Type = "Sword"
					},
					new Weapon
					{
						Id = 2,
						Type = "Claymore"
					},
					new Weapon
					{
						Id = 3,
						Type = "Polearm"
					},
					new Weapon
					{
						Id = 4,
						Type = "Catalyst"
					},
					new Weapon
					{
						Id = 5,
						Type = "Bow"
					}
				);
		}
	}
}
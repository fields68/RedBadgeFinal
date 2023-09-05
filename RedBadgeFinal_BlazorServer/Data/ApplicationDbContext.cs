﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedBadgeFinal_BlazorServer.Data.Entities;

namespace RedBadgeFinal_BlazorServer.Data
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
    }
}
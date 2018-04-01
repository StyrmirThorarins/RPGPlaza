using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPGPlaza.Models;
using RPGPlaza.Models.SavageWorlds;

namespace RPGPlaza.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<SWCharacter> SWCharacters { get; set; }
        public DbSet<SWSkill> SWSkills { get; set; }
        public DbSet<SWHindrance> SWHindrances { get; set; }
        public DbSet<SWEdge> SWEdges { get; set; }
        public DbSet<SWEdgeType> SWEdgeTypes { get; set; }
        public DbSet<SWWeapon> SWWeapons { get; set; }
        public DbSet<SWArmor> SWArmors { get; set; }
        public DbSet<SWMundaneItem> SWMundaneItems { get; set; }
        public DbSet<SWBook> SWBooks { get; set; }
        public DbSet<SWRace> SWRaces { get; set; }
        public DbSet<SWSkillCustom> SWSkillCustom { get; set; }
        public DbSet<SWHindranceCustom> SWHindrancesCustom { get; set; }
        public DbSet<SWEdgeCustom> SWEdgesCustom { get; set; }
        public DbSet<SWWeaponCustom> SWWeaponsCustom { get; set; }
        public DbSet<SWArmorCustom> SWArmorsCustom { get; set; }
        public DbSet<SWMundaneItemCustom> SWMundaneItemsCustom { get; set; }
        public DbSet<SWRaceCustom> SWRacesCustom { get; set; }
    }
}

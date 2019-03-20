using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsGoGranades.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CsGoGranades.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<Map> Maps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Map>().HasData(new Map
            {
                Id = 1, DisplayName = "Inferno", Name = "de_inferno",
                ThumbUrl ="~/images/thumbs/320px-De_new_inferno.jpg",
                OverviewUrl = "~/images/overview/de_inferno.png",
                SizeX = 1080,
                SizeY = 1080
            });
            modelBuilder.Entity<Map>().HasData(new Map
            {
                Id = 2, DisplayName = "Mirage", Name = "de_mirage",
                ThumbUrl = "~/images/thumbs/320px-Csgo_mirage.jpg",
                OverviewUrl = "~/images/overview/de_mirage.png"
            });
            modelBuilder.Entity<Map>().HasData(new Map
            {
                Id = 3,
                DisplayName = "Dust 2",
                Name = "de_dust2",
                ThumbUrl = "~/images/thumbs/320px-Csgo_dust2.0.jpg",
                OverviewUrl = "~/images/overview/de_dust2.png",
                SizeX = 1080,
                SizeY = 1080
            });
            modelBuilder.Entity<Map>().HasData(new Map
            {
                Id = 4,
                DisplayName = "Nuke",
                Name = "de_nuke",
                ThumbUrl = "~/images/thumbs/320px-Nuke_csgo.jpg",
                OverviewUrl = "~/images/overview/de_nuke.png"
            });
            modelBuilder.Entity<Map>().HasData(new Map
            {
                Id = 5,
                DisplayName = "Train",
                Name = "de_train",
                ThumbUrl = "~/images/thumbs/320px-Train_csgo.jpg",
                OverviewUrl = "~/images/overview/de_train.png"
            });

            modelBuilder.Entity<GranadeSpot>().HasData(new GranadeSpot
            {
                Id = 1,
                MapId = 3,
                YoutubeUrl = "nrHQ5VdOnv8",
                X = 561,
                Y = 281,
                Type = 1

            });
        }
    }
}

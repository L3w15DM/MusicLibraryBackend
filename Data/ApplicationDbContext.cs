using System;
using Microsoft.EntityFrameworkCore;
using MusicLibraryAPI.Models;

namespace MusicLibraryAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Song> Songs { get; set; }

		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Song entity
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Intro",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 2,
                    Title = "January 28th",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 3,
                    Title = "Wet Dreamz",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 4,
                    Title = "'03 Adolescence",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 5,
                    Title = "A Tale Of 2 Citiez",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 6,
                    Title = "Fire Squad",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 7,
                    Title = "St. Tropez",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 8,
                    Title = "G.O.M.D",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 9,
                    Title = "No Role Models",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 10,
                    Title = "Hello",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 11,
                    Title = "Apparently",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 12,
                    Title = "Love Yourz",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                },
                new Song
                {
                    Id = 13,
                    Title = "Note To Self",
                    Artist = "J. Cole",
                    Album = "2014 Forest Hills Drive",
                    ReleaseDate = new DateOnly(2014, 12, 09),
                    Genre = "Hip-Hop"
                }

         ); 
        }
    }
}


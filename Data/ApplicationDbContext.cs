using System;
using Microsoft.EntityFrameworkCore;

namespace MusicLibraryAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
	}
}


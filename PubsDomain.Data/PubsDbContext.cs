using Microsoft.EntityFrameworkCore;
using Pubs.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PubsDomain.Data
{
	public class PubsDbContext : DbContext
	{
		public DbSet<Author> Authors { get; set; }
		public DbSet<TitleAuthor> TitleAuthors { get; set; }
		public DbSet<Title> Titles { get; set; }
		public DbSet<Roysched> Royscheds { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<PubInfo> Pub_Infos { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Job> Jobs { get; set; }
		public DbSet<Sales> Sales { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<Discount> Discounts { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = PubsProject; Trusted_Connection = true");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TitleAuthor>().HasKey(ta => new { ta.AuthorId, ta.TitleId });
			modelBuilder.Entity<Discount>().HasNoKey();
			modelBuilder.Entity<Sales>().HasKey(s => new { s.StoreId, s.TitleId, s.SalesId });
			modelBuilder.Entity<Roysched>().HasNoKey();
			modelBuilder.Entity<PubInfo>().HasKey(pi => pi.PublisherId);
			base.OnModelCreating(modelBuilder);
		}
	}
}

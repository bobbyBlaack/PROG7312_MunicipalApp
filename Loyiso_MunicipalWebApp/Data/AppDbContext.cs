using Loyiso_MunicipalWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace Loyiso_MunicipalWebApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ReportModel> Reports { get; set; }

        public DbSet<LocalEventModel> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}

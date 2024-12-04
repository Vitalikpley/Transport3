using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;

namespace TransportMigration
{
    public class TransportDbContext : DbContext
    {
        public DbSet<StopStation> StopStations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TransportLine> Lines { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("SQLIte"));
        }
        public static IConfiguration Configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appSetting.json")
      .AddUserSecrets<Program>().Build();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schedule>().HasData(Schedule.DefaultSchedule());
            modelBuilder.Entity<StopStation>().HasData(StopStation.DefaultStopStation());
            modelBuilder.Entity<Ticket>().HasData(Ticket.DefaultTickets());
            modelBuilder.Entity<TransportLine>().HasData(TransportLine.DefaultTransportLine());
        }

    }
}

using System.Data.Entity;
using Civitas.Entities;

namespace Civitas.DataModel
{
    public class ReportContext: DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}

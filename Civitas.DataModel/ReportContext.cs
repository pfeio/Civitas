using System.Data.Entity;
using Civitas.Entities;

namespace Civitas.DataModel
{
    public class ReportContext: DbContext
    {
        public DbSet<Report> Reports { get; set; }
    }
}

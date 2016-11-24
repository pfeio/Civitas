using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Civitas.Entities;

namespace Civitas.DataModel
{
    public class ReportDAL : IDisposable    
    {
        private ReportContext ctx;
        private bool inDebug;
        //public ReportDAL(ReportContext ctx)
        //{
        //    this.ctx = ctx;
        //}

        public ReportDAL(Boolean debug = false)
        {
            ctx = new ReportContext();
            inDebug = debug;
            if (inDebug)
                ctx.Database.Log = Console.WriteLine;

        }

        public void CreateReport(Report newReport)
        {
            ctx.Reports.Add(newReport);
            int resCount = ctx.SaveChanges();

        }

        public Report GetRandomReport()
        {
            return ctx.Reports.FirstOrDefault();
        }

        public Report GetReport(Guid reportToRetrieve)
        {
            return 
                (ctx.Reports
                .Include(n => n.Location)
                .Include(n => n.Reporter)
                //.Select(n => new {n.Id, n.Creation, n.Description, n.Location, n.Reporter, n.Title ,n.Support.Count})
                .FirstOrDefault(n => n.Id == reportToRetrieve));

        }

        public void DeleteReport(Guid reportToDelete)
        {
            Report r = createStubReport(reportToDelete);


            ctx.Entry(r).State = EntityState.Deleted;
            ctx.SaveChanges();

        }

        private static Report createStubReport(Guid reportToDelete)
        {
            Report r = new Report();
            r.Id = reportToDelete;
            var stubLocation = new Location();
            stubLocation.Id = Guid.Empty;
            var stubUser = new User();
            stubUser.Id = Guid.Empty;
            r.Location = stubLocation;
            r.Reporter = stubUser;
            r.Support = new List<Vote>();

            return r;
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}

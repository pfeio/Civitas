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
    public class ReportDal : IDisposable    
    {
        private readonly ReportContext ctx;
        private readonly bool inDebug;

        public ReportDal(Boolean debug = false)
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

        public IList<Report> GetAllReports()
        {
            return ctx.Reports.ToList();
        }

        public Report GetReport(Guid reportToRetrieve)
        {
            return 
                (ctx.Reports

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

            return r;
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}

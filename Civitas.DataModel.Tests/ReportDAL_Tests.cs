using System;
using System.Collections.Generic;
using System.Data.Entity;
using Civitas.DataModel;
using Civitas.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Civita.DataModel.Tests
{
    [TestClass]
    public class ReportDAL_Tests
    {
        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new NullDatabaseInitializer<ReportContext>());
        }

        [TestMethod]
        public void Creation()
        {
            bool debug = true;
            Guid newReportId = Guid.NewGuid();
            using (ReportDAL dal = new ReportDAL(debug))
            {
                User u = new User();
                u.Firstname = "Pedro";
                u.Lastname = "Feio";
                u.Id = Guid.NewGuid();
                u.Username = "pedro.feio";

                Location l = new Location();
                l.Id = Guid.NewGuid();
                l.Name = "Somewhere in London";

                Report r = new Report();
                r.Creation = DateTime.Now;
                r.Title = "Test report 1";
                r.Description = "This is the description of the report. Preeeetyy looong.";
                r.Id = newReportId;
                r.Reporter = u;
                r.Support = new List<Vote>();
                r.Location = l;

                dal.CreateReport(r);
            }

            using (ReportDAL dal = new ReportDAL(debug))
            {
                Report r = dal.GetReport(newReportId);
                Assert.IsNotNull(r, "New report was inserted");
            }
        }


        [TestMethod]
        public void Deletion()
        {
            Report original = null;
            using (ReportDAL dal = new ReportDAL(true))
            {
                original = dal.GetRandomReport();
            }

            if (original == null)
                Assert.Inconclusive("No database records!");

            using (ReportDAL dal = new ReportDAL(true))
            {
                dal.DeleteReport(original.Id);
            }

            using (ReportDAL dal = new ReportDAL(true))
            {
                Assert.IsNull(dal.GetReport(original.Id), "Report {0} was deleted from the database.", original.Id);
            }
        }

    }
}

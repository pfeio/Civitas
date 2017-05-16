using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Civitas.DataModel;
using Civitas.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Civita.DataModel.Tests
{
    [TestClass]
    public class ReportDal_SeedTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new ReportInitializer());
        }

        [TestMethod]
        public void CountReports()
        {
            using (ReportDal dal = new ReportDal())
            {
                IList<Report> seededReports = new List<Report>();

                for (int i = 0; i < 10000; i++)
                {
                    seededReports.Add(new Report()
                    {
                        Creation = DateTime.UtcNow.AddDays(i),
                        Description =
                            $@"This is report description number {i}. This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...vThis is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times...This is just a generic report created for testing purposes. This report by no means should be considered relevant or real. 
this report is meant to be quite large, so I'm just going to repeat the same rows a LOT of times, like 10 times... ",
                        Id = Guid.NewGuid(),
                        Title = $"Dummy report. {DateTime.UtcNow.AddDays(i)} This is report number {i}."
                    });


                }

                dal.CreateReport(seededReports);

                int count = dal.GetContext().Reports.Count();
                Assert.IsTrue(count >= 1000);
            }
        }
    }
}

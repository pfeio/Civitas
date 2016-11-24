using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Civitas.DAL;
using Civitas.Models;

namespace Civitas.Controllers
{
    [RoutePrefix("api/report")]
    public class ReportController : ApiController
    {
        private IList<Report> existingReports = new List<Report>()
        {
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing zebra" , Description = "There's way to cross the street!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Broken streetlight" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 2" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing zebra" , Description = "There's way to cross the street!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Broken streetlight" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Broken trafic light" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "No road markings" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "No road signs" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing zebra" , Description = "There's way to cross the street!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Broken streetlight" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Uncollected garbage" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Uncollected garbage 2" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing zebra" , Description = "There's way to cross the street!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Broken streetlight" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 2" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"}
        };

        public IEnumerable<Report> GetAllReports()
        {
            return existingReports;
        }

        public IHttpActionResult GetReport(Guid id)
        {
            var report = existingReports.FirstOrDefault((p) => p.Id == id);
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }

        [Route("search/{searchCriteria}")]
        public IHttpActionResult GetReport(string searchCriteria)
        {
            var report = existingReports.FirstOrDefault(p => p.Title.Contains(searchCriteria));
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }
    }
}

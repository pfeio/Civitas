using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Civitas.EntitiesCore;
using Microsoft.AspNetCore.Mvc;

namespace Civitas.WebAPICore.Controllers
{
    [Route("api/report")]
    public class ReportController : Controller
    {
        private readonly IList<Report> existingReports = new List<Report>()
        {
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
            new Report {Creation = DateTime.Now, Id = new Guid("ef55f267-9794-4bd4-acff-26db2f61f9d6") , Title = "Missing zebra" , Description = "There's way to cross the street!"},
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
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
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
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
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
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
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
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
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
            new Report {Creation = DateTime.Now, Id = Guid.NewGuid(), Title = "Missing sidewalk 3" , Description = "There's no sidewalk, so people need to walk on a busy road!"},
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


        [HttpGet]
        public IEnumerable<Report> GetAllReports()
        {
            return existingReports;
        }

        /// <summary>
        /// Retrieves a specific report with a 200 OK response, give it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetReport(Guid id)
        {
            var report = existingReports.FirstOrDefault((p) => p.Id == id);
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }

        [Route("search/t={searchCriteria}")]
        public IActionResult GetReportByTitle(string searchCriteria)
        {
            var report = existingReports.Where(p => p.Title.Contains(searchCriteria)).ToList();
            if (report.Count == 0)
            {
                return NotFound();
            }
            return Ok(report);
        }


        [Route("search/d={description}")]
        public IActionResult GetReportByDescription(string description)
        {
            var report = existingReports.Where(p => p.Description.Contains(description)).ToList();
            if (report.Count == 0)
            {
                return NotFound();
            }
            return Ok(report);
        }

        [HttpPost]
        public Boolean CreateReport(Report newReport)
        {
            this.existingReports.Add(newReport);
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using Civitas.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civitas.DataModel
{
    public class ReportInitializer : CreateDatabaseIfNotExists<ReportContext>
    {
        protected override void Seed(ReportContext context)
        {
            base.Seed(context);
        }
    }
}

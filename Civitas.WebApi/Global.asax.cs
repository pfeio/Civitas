﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Swashbuckle.Application;

namespace Civitas
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //GlobalConfiguration.Configuration
            //    .EnableSwagger(c => c.SingleApiVersion("v1", "Civitas API"))
            //    .EnableSwaggerUi();
        }
    }
}

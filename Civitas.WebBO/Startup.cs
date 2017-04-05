using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Civitas.WebBO.Startup))]
namespace Civitas.WebBO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

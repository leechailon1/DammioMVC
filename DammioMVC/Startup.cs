using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DammioMVC.Startup))]
namespace DammioMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

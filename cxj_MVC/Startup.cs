using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cxj_MVC.Startup))]
namespace cxj_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewBagViewData.Startup))]
namespace ViewBagViewData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

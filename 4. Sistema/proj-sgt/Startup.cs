using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proj_sgt.Startup))]
namespace proj_sgt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

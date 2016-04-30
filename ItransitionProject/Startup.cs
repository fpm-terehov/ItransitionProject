using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItransitionProject.Startup))]
namespace ItransitionProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBConnectionApp.Startup))]
namespace DBConnectionApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

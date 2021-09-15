using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522_SA_2021.Startup))]
namespace PRG522_SA_2021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegistrationWeb.Startup))]
namespace RegistrationWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

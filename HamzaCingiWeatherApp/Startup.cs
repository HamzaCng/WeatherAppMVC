using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HamzaCingiWeatherApp.Startup))]
namespace HamzaCingiWeatherApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

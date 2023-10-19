using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HOTEL_LANGA.Startup))]
namespace HOTEL_LANGA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

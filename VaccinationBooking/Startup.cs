using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VaccinationBooking.Startup))]
namespace VaccinationBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

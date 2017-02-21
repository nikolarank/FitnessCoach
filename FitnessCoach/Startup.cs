using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessCoach.Startup))]
namespace FitnessCoach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

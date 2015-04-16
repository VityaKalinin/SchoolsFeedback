using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolsFeedback.Startup))]
namespace SchoolsFeedback
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

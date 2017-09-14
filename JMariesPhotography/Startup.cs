using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMariesPhotography.Startup))]
namespace JMariesPhotography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

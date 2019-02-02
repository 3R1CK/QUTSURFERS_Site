using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QUTSurfers.Startup))]
namespace QUTSurfers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

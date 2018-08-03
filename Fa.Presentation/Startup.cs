using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fa.Presentation.Startup))]
namespace Fa.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

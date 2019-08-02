using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Canvas.Startup))]
namespace Canvas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Academic_demo.Startup))]
namespace Academic_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(entidades.Startup))]
namespace entidades
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

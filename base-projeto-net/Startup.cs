using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(base_projeto_net.Startup))]
namespace base_projeto_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

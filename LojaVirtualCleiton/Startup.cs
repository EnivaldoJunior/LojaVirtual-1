using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaVirtualCleiton.Startup))]
namespace LojaVirtualCleiton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CyberBoard.Startup))]
namespace CyberBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

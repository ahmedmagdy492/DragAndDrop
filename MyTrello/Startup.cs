using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTrello.Startup))]
namespace MyTrello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

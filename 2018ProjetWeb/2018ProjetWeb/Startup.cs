using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2018ProjetWeb.Startup))]
namespace _2018ProjetWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

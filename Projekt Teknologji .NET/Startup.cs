using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt_Teknologji.NET.Startup))]
namespace Projekt_Teknologji.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

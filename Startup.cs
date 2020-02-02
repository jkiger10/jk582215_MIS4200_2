using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jk582215_MIS4200_2.Startup))]
namespace jk582215_MIS4200_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

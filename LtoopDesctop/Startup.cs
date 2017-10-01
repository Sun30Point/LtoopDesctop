using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LtoopDesctop.Startup))]
namespace LtoopDesctop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

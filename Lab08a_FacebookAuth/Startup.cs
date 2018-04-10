using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab08a_FacebookAuth.Startup))]
namespace Lab08a_FacebookAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

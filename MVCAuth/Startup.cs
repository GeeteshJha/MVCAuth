using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MVCAuth.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuth.Startup))]
namespace MVCAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
            ConfigureAuth(app);
        }
    }
}

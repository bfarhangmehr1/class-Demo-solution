using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website_behnam.Startup))]
namespace Website_behnam
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

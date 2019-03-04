using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoanUnionApp.Startup))]
namespace LoanUnionApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

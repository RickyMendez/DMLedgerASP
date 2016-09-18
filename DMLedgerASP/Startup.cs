using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMLedgerASP.Startup))]
namespace DMLedgerASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

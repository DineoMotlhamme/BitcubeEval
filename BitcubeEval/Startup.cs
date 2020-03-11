using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitcubeEval.Startup))]
namespace BitcubeEval
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

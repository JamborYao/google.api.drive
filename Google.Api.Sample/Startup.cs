using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Google.Api.Sample.Startup))]
namespace Google.Api.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

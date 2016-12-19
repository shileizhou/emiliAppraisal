using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(emiliAppraisal.Startup))]
namespace emiliAppraisal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

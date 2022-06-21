using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool12.Startup))]
namespace BigSchool12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

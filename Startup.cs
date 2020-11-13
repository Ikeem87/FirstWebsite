using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelView.Startup))]
namespace ModelView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub.Startup))]
namespace GigHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

    public class Test
    {
        public string Name { get; set; }
    }
}

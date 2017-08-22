using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitBashLearning.Startup))]
namespace GitBashLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

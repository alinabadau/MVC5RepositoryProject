using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5RepositoryProject.Startup))]
namespace MVC5RepositoryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

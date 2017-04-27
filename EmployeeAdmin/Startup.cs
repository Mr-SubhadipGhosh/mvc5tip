using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeAdmin.Startup))]
namespace EmployeeAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

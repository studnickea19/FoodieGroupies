using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodieGroupies.Startup))]
namespace FoodieGroupies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

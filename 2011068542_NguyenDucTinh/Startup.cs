using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011068542_NguyenDucTinh.Startup))]
namespace _2011068542_NguyenDucTinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

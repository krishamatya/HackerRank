using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalRAuth.Areas.Identity.Data;
using SignalRAuth.Data;

[assembly: HostingStartup(typeof(SignalRAuth.Areas.Identity.IdentityHostingStartup))]
namespace SignalRAuth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SignalRAuthContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SignalRAuthContextConnection")));

                services.AddDefaultIdentity<SignalRAuthUser>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                .AddEntityFrameworkStores<SignalRAuthContext>();
            });
        }
    }
}
﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.Areas.Identity.Data;
using SignalR.Data;

[assembly: HostingStartup(typeof(SignalR.Areas.Identity.IdentityHostingStartup))]
namespace SignalR.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SignalRContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SignalRContextConnection")));

                services.AddDefaultIdentity<SignalRUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SignalRContext>();
            });
        }
    }
}
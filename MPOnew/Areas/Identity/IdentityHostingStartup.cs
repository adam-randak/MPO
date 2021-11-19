using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MPOnew.Areas.Identity.Data;

using MPOnew.Entities;

[assembly: HostingStartup(typeof(MPOnew.Areas.Identity.IdentityHostingStartup))]
namespace MPOnew.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MPODbContext>();

                services.AddDefaultIdentity<MPOnewUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<MPODbContext>();
            });
        }
    }
}
﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.Logging.QuickStart
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(
            IConfiguration configuration
            )
        {
            Configuration = configuration;
        }

        public void ConfigureServices(
            IServiceCollection services
            )
        {
            services.AddLogging(
                Configuration.GetSection("Logging")
                );
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env
            )
        {
            app.UseLogging(
                env,
                Configuration.GetSection("Logging")
                );
        }
    }
}

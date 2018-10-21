﻿using CoffeeAPI.Models;
using CoffeeAPI.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;

namespace CoffeeAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;";
            //var connection = Configuration.GetConnectionString("KoffieDatabase");
            services.AddDbContext<CoffeeContext>(options => options.UseSqlServer(connection));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // clock skew compensates for server time drift
                    ClockSkew = TimeSpan.FromMinutes(5),
                    // specify the key used to sign the token
                    IssuerSigningKey = new SymmetricSecurityKey(AuthHelper.SecurityKey),
                    // ensure the token is signed
                    RequireSignedTokens = true,
                    // ensure the token has an expiration time
                    RequireExpirationTime = true,
                    // ensure the token hasn't expired
                    ValidateLifetime = true,
                    // do not validate the audience
                    ValidateAudience = false,
                    // ensure the token was issued by a trusted server
                    ValidateIssuer = true,
                    ValidIssuer = "https://jorisvdinther.nl"
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

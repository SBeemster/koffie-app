using CoffeeAPI.Models;
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
                    // Clock skew compensates for server time drift
                    ClockSkew = TimeSpan.FromMinutes(5),
                    // Specify the key used to sign the token
                    IssuerSigningKey = new SymmetricSecurityKey(AuthHelper.SecurityKey),
                    // Ensure the token is signed
                    RequireSignedTokens = true,
                    // Ensure the token has an expiration time
                    RequireExpirationTime = true,
                    // Ensure the token hasn't expired
                    ValidateLifetime = true,
                    // Ensure the token audience matches our audience value
                    ValidateAudience = true,
                    ValidAudience = "api://default",
                    // Ensure the token was issued by a trusted authorization server
                    ValidateIssuer = true,
                    ValidIssuer = "https://{yourOktaDomain}/oauth2/default"
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

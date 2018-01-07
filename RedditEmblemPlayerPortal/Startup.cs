using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Discord.OAuth2;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Rewrite;
using RedditEmblemPlayerPortal.Models;

namespace RedditEmblemPlayerPortal
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
      //Database context and entity framework
      services.AddDbContext<DatabaseContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("RedditEmblemDatabase")));

      //services.AddScoped<IUserData, UserData>();

      //MVC
      services.AddMvc()
          .AddRazorPagesOptions(options =>
          {
            options.Conventions.AuthorizeFolder("/Account/Manage");
            options.Conventions.AuthorizePage("/Account/Logout");
          });

      services.Configure<MvcOptions>(options =>
      {
        options.Filters.Add(new RequireHttpsAttribute());
      });

      //User authentication
      services.AddAuthentication(options =>
      {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
      })
        .AddDiscord(x =>
        {
          x.AppId = Configuration["Discord:ClientId"];
          x.AppSecret = Configuration["Discord:ClientSecret"];
          x.Scope.Add("guilds");
          x.CallbackPath = "/Account/DiscordCallback";
        })
        .AddCookie();

      services.AddIdentity<DiscordUserToken, IdentityRole>()
         //.AddEntityFrameworkStores<DatabaseContext>()
         .AddDefaultTokenProviders();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseBrowserLink();
        app.UseDatabaseErrorPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
      }

      app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent());

      app.UseStaticFiles();

      app.UseAuthentication();

      app.UseMvc(routes =>
            {
              routes.MapRoute(
                      name: "default",
                      template: "{controller}/{action=Index}/{id?}");
            });
    }
  }
}
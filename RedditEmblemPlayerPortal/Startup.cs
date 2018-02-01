using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;

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
      services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("RedditEmblemDatabase")));

      services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

      //Reroute user to Discord login if they try to access the app without authenticating
      services.ConfigureApplicationCookie(options => 
      {
        options.LoginPath = "/Account/ExternalLogin";
      });

      services.AddAuthentication()
        .AddDiscord(x =>
        {
          x.AppId = Configuration["Discord:ClientId"];
          x.AppSecret = Configuration["Discord:ClientSecret"];
          x.Scope.Add("guilds");
          x.CallbackPath = "/ExternalLogin/Callback";
        });

      //Require authentication for Angular app
      services.AddMvc()
        .AddRazorPagesOptions(options =>
        {
          options.Conventions.AuthorizePage("/Angular");
        });

      services.Configure<MvcOptions>(options =>
      {
        options.Filters.Add(new RequireHttpsAttribute());
      });

      // Register no-op EmailSender used by account confirmation and password reset during development
      // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=532713
      services.AddSingleton<IEmailSender, EmailSender>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseBrowserLink();
        app.UseDeveloperExceptionPage();
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
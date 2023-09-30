using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TechSurvey.DAL.Contexts;
using TechSurvey.MVC.AutoMapperProfile;
using TechSurvey.MVC.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TechcareerSurveyDb")));

builder.Services.AddSurveyServices();
builder.Services.AddAutoMapper(typeof(SurveyProfile));

#region Cookie Base Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(p =>
        {
            p.LoginPath = "/Login/Index";
            p.AccessDeniedPath = "/Login/Yasak";

            p.LogoutPath = "/Login/?";
            p.Cookie.Name = "Survey";
            p.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        });
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#region Admin Area Route
app.UseEndpoints(endpoints =>
{
endpoints.MapControllerRoute(
name: "areas",
pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);
}); 
#endregion

app.Run();

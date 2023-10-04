using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechSurvey.DAL.Contexts;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.AutoMapperProfile;
using TechSurvey.MVC.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TechcareerSurveyDb")));

#region Identity Configuration
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
    {
        //Password settings.
        options.Password.RequireDigit = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 8;
        options.Password.RequiredUniqueChars = 1;
        options.User.RequireUniqueEmail = true;

        //SignIn settings.
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.SignIn.RequireConfirmedAccount = false;

        //Lockout settings.
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.AllowedForNewUsers = true;

    }).AddEntityFrameworkStores<SqlDbContext>()
    .AddDefaultTokenProviders();

#region Cookie Settings.
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "MyDukkan";
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.AccessDeniedPath = "/AccessDenied";

    options.Cookie.HttpOnly = true;
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
});

builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
    options.TokenLifespan = TimeSpan.FromMinutes(5);
});
#endregion

#endregion

builder.Services.AddSurveyServices();

#region AutoMapper
builder.Services.AddAutoMapper(typeof(TechSurveyProfile));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

#region Admin Area Route
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
#endregion

#region Map Controller Route
app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion

app.Run();

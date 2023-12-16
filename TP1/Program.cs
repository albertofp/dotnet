using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TP1.Models;
using TP1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddDbContext<BooksContext>(options =>
  options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BooksContext>();

builder.Services.Configure<IdentityOptions>(options => {
  options.Password.RequireDigit = false;
  options.Password.RequireLowercase = false;
  options.Password.RequireNonAlphanumeric = false;
  options.Password.RequireUppercase = false;
  options.Password.RequiredLength = 3;
// Lockout settings
  options.Lockout.MaxFailedAccessAttempts = 30;
  options.Lockout.AllowedForNewUsers = true;
// User settings
  options.User.RequireUniqueEmail = true;
});

builder.Services.AddMvc().AddNToastNotifyToastr();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for
  // production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseRequestLocalization("pt-BR");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseNToastNotify();

app.MapRazorPages();

app.Run();

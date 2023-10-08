using Application;
using Infrastructure;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddApplicationServices();

builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    {
      options.SignIn.RequireConfirmedAccount = false;
      options.Password.RequireUppercase = false;
      options.Password.RequiredLength = 8;
      options.Password.RequireNonAlphanumeric = false;
      options.Password.RequireDigit = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();

#endregion

var app = builder.Build();

#region Pipelines

if (app.Environment.IsDevelopment())
{
  app.UseMigrationsEndPoint();
}
else
{
  app.UseExceptionHandler("/Error");
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

#endregion

app.Run();

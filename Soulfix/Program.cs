using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer;
using Pomelo.EntityFrameworkCore.MySql;
using Soulfix.Controllers.Message;
using Soulfix.Data;
using Soulfix.Repository.Category;
using Soulfix.Repository.Client;
using Soulfix.Repository.Event;
using Soulfix.Repository.Login;
using Soulfix.Repository.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("database");
builder.Services.AddDbContext<BaseContext>(x => x.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//Injetando dependencia da Interface resolvendo ela com uma classe
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<IMessage, Message>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();

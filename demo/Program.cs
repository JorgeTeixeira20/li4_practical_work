using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using demo.Data;
using demo;
using DataLayer;
using demo.Features.Home;
using DataLayer.Cards;
using DataLayer.Watches;
using DataLayer.Utilizador;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<ICardRepository, CardRepository>();
builder.Services.AddTransient<IWatchRepository, WatchRepository>();
builder.Services.AddTransient<IUtilizadorRepository, UtilizadorRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

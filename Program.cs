using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Security.Authentication;
using AspNet_MVC_Mongo_Sample.Models;
using AspNet_MVC_Mongo_Sample.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// mongo db connection service
// builder.Services.Configure<MongoDbConnectionSettings>(
//   builder.Configuration.GetSection("MongoDbConnection"));

// Register MongoDB client
var connectionString = builder.Configuration.GetValue<string>("MongoDbConnection:ConnectionString");
var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
//settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
builder.Services.AddSingleton<IMongoClient>(new MongoClient(settings));

// SampleModel1 service
builder.Services.AddSingleton<SampleModel1Svc>();

// proposal service
builder.Services.AddSingleton<SampleModel2Svc>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

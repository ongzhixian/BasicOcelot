using System.Reflection.Emit;

using Ocelot.DependencyInjection;
using Ocelot.Middleware;

IConfiguration Configuration;
IWebHostEnvironment env;

var builder = WebApplication.CreateBuilder(args);

Configuration = builder.Configuration;

env = builder.Environment;

ConfigureServices(builder.Services, Configuration);


var app = builder.Build();

if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseOcelot();

app.MapGet("/", () => "Hello World!");

app.Run();


void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddOcelot(configuration);
}

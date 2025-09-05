using AppBlazor.Client;
using AppBlazor.Client.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.ComponentModel;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<EmpleadoService>();

builder.Services.AddScoped<TipoCiudadService>();
builder.Services.AddScoped<TipoJefeService>();

await builder.Build().RunAsync();

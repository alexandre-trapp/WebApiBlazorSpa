using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WeatherForecastSpa.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5000") });

await builder.Build().RunAsync();

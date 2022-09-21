using CardGameBlazor;
using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/") });
builder.Services.AddScoped<ICardHttpService, CardHttpService>();
builder.Services.AddScoped<IHandHistoryHttpService, HandHistoryHttpService>();

await builder.Build().RunAsync();

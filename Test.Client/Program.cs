using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Test.Client;
using Test.Client.HttpRepository;
using Test.Client.HttpRepository.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("TestAPI", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiConfiguration:BaseAddress"] + "/api/");
    client.Timeout = TimeSpan.FromMinutes(5);
});

builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("TestAPI"));

builder.Services.AddScoped<IPersonHttpRepository, PersonHttpRepository>();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

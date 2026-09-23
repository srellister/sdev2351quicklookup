using Fluxor;
using InventoryLookup;
using InventoryLookup.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// App services
builder.Services.AddSingleton<IInventoryService, InMemoryInventoryService>();

// Fluxor -- scans this assembly for [FeatureState], reducers and effects.
builder.Services.AddFluxor(options =>
    options.ScanAssemblies(typeof(Program).Assembly));

await builder.Build().RunAsync();

global using InvestmentPlataform.Shared;
global using System.Net.Http.Json;
global using InvestmentPlataform.Client.Services.ProductService;
global using InvestmentPlataform.Client.Services.CategoryService;
global using InvestmentPlataform.Client.Services.AuthServices;
global using Microsoft.AspNetCore.Components.Authorization;
global using InvestmentPlataform.Client.Services.OrderService;
global using InvestmentPlataform.Client.Services.CartService;
using InvestmentPlataform.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();
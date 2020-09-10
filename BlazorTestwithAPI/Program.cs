using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlazorTestwithAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp =>
            {
                Uri uri = new Uri("https://499d57b7-43c7-4f0b-8ab4-40d039c2eaab.mock.pstmn.io/");
                return new HttpClient { BaseAddress = uri };
            });

            await builder.Build().RunAsync();
        }
    }
}

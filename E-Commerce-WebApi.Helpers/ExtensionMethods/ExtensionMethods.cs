using E_Commerce_WebApi.Repositories.Interfaces;
using E_Commerce_WebApi.Repositories.Repositories;
using E_Commerce_WebApi.Services.Interfaces;
using E_Commerce_WebApi.Services.Service;
using ECoommerce.Services.Service;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Http;

namespace E_Commerce_WebApi.Helpers.ExtensionMethods
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {

            

            //services.AddHttpClient("GithubAPI", client =>
            //{
            //    //customize as per your need
            //    client.BaseAddress = new Uri("http://api.github.com/");
            //    client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            //    client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactoryExample");
            //});


            //Registering Repositories in the DI
            //Add new here
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IUoRepositories, UoRepositories>();


            //
            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<IUoWService, UoWService>();

            
            services.AddHttpClient("ECommerceDapper", client =>
            {
                //customize as per your need
                client.BaseAddress = new Uri("http://api.github.com/");
                client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
                client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactoryExample");
            });


        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.SemanticKernel;
using MudBlazor.Services;
using PaceIndustries.Circuit.Components;
using PaceIndustries.Shared.Data;

namespace PaceIndustries.Circuit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddMudServices();

            string connectionString = builder.Configuration["ConnectionStrings"];

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            ConfigureSemanticKernel(builder.Services, builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }

        private static void ConfigureSemanticKernel(IServiceCollection services, IConfiguration configuration)
        {
            string name = configuration["AzureOpenAi:Name"];

            string endpoint = configuration["AzureOpenAi:Endpoint"];

            string apiKey = configuration["AzureOpenAi:Key1"];

            services.AddKernel().AddAzureOpenAIChatCompletion(name, endpoint, apiKey);
        }
    }
}

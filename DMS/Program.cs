using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DMS.Application;
using DMS.Infrastructure.Extensions;
using System.Reflection;
using MediatR;

namespace DMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddApplication();
            


            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("Index");

            app.Run();
        }
    }
}
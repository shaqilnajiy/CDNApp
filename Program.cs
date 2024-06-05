using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CDNDev.Data;
using CDNDev.Services;

namespace CDNDev
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Load configuration from appsettings.json
            var configuration = builder.Configuration;

            // Configure DbContext with connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<UserContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CDN Dev API", Version = "v1" });
            });

            // Register UserService
            builder.Services.AddScoped<UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Complete Developer Network API v1"));
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
﻿using System;
using System.Threading.Tasks;
using dotnet_meets_react.Migrations;
using dotnet_meets_react.src.contexts.activityTracker.shared.infraestructure;
using dotnet_meets_react.src.contexts.activityTracker.user.domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace dotnet_meets_react
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var repositories = services.GetRequiredService<Repositories>();
                var userManager = services.GetRequiredService<UserManager<User>>();
                await repositories.Database.MigrateAsync();
                await Seed.Hidratate(repositories, userManager);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occured during migration");
            }

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(
                    webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    }
                );
    }
}

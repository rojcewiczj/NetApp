﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using API.Interfaces;
using API.Services;
using API.Data;
using Microsoft.EntityFrameworkCore;
using System;


namespace API.Extensions
{
public static class ApplicationServiceExtensions
{

	public static IServiceCollection AddApplicationServices(this IServiceCollection, IConfiguration config)
	{
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;

	}

}
}
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using API.Interfaces;
using API.Services;
using API.Helpers;
using API.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;


namespace API.Extensions
{
public static class ApplicationServiceExtensions
{

	public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
	{
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;

	}

}
}
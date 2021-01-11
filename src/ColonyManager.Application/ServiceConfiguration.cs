using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddRegisteredServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddValidatorsFromAssembly(typeof(ServiceConfiguration).Assembly);



            return services;
        }
    }
}

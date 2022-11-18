using ColonyManager.Application.Services;
using ColonyManager.Domain.Interfaces.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ColonyManager.Application
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddRegisteredServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddValidatorsFromAssembly(typeof(ServiceConfiguration).Assembly);

            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleInternetInformationService, PeopleInternetInformationService>();
            services.AddScoped<IPeoplePhoneInformationService, PeoplePhoneInformationService>();
            services.AddScoped<IPeopleAddressService, PeopleAddressService>();

            services.AddScoped<IColonyService, ColonyService>();

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddScoped<INationalityService, NationalityService>();
            services.AddScoped<IGenderService, GenderService>();

            return services;
        }
    }
}

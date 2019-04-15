

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace reCAPTCHA.AspNetCore
{
    public static class RecaptchaServiceExtensions
    {
        public static IServiceCollection AddGoogleRecaptcha(this IServiceCollection services,IConfigurationSection configuration)
        {
            services.Configure<RecaptchaSettings>(configuration);
            services.AddScoped<IRecaptchaService, RecaptchaService>();
            return services;
        }

        public static IServiceCollection AddGoogleRecaptcha(this IServiceCollection services,Action<RecaptchaSettings> options)
        {
            services.Configure(options);
            services.AddScoped<IRecaptchaService, RecaptchaService>();
            return services;
        }
    }
}
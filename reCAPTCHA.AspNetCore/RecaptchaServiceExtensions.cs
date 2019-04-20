

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace reCAPTCHA.AspNetCore
{
    public static class RecaptchaServiceExtensions
    {
        public static IServiceCollection AddGoogleRecaptcha(this IServiceCollection services,IConfigurationSection configuration)
        {
            services.AddHttpClient("GoogleRecaptcha",
                c => c.BaseAddress = new Uri($"https://{configuration["Domain"]}"));
            services.Configure<RecaptchaSettings>(configuration);
            services.AddScoped<IRecaptchaService, RecaptchaService>();
            return services;
        }
    }
}
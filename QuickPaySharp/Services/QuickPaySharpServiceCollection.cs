using System;
using System.Net.Http.Headers;
using QuickPaySharp.Services;
using RechargeSharp.Services.Subscriptions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class QuickPaySharpServiceCollection
    {
        public static IServiceCollection AddRechargeSharp(this IServiceCollection services, Action<QuickPaySharpServiceOptions> options)
        {
            services.Configure(options);

            services.AddHttpClient("QuickPaySharpClient", (services, opts) =>
            {
                opts.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                opts.DefaultRequestHeaders.Add("Accept-Version", "v10");
                opts.BaseAddress = new Uri("https://api.quickpay.net/");
            });

            services.AddTransient(x => options);
            services.AddLogging();

            services.AddTransient<PaymentService>();

            return services;
        }
    }
}

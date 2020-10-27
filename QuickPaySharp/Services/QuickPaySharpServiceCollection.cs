using System;
using System.Net.Http.Headers;
using QuickPaySharp.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class QuickPaySharpServiceCollection
    {
        public static IServiceCollection AddRechargeSharp(this IServiceCollection services, Action<QuickPaySharpServiceOptions> options)
        {
            services.Configure(options);

            services.AddHttpClient("RechargeSharpClient", (services, opts) =>
            {
                opts.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                opts.BaseAddress = new Uri("https://api.rechargeapps.com/");
            });

            services.AddHttpClient("RechargeSharpWebhookClient", (services, opts) =>
            {
                opts.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                opts.BaseAddress = new Uri("https://api.rechargeapps.com/");
            });

            services.AddTransient(x => options);
            services.AddLogging();

            //services.AddTransient<AddressService>()
            //    .AddTransient<ChargeService>()
            //    .AddTransient<CheckoutService>()
            //    .AddTransient<CollectionService>()
            //    .AddTransient<CustomerService>()
            //    .AddTransient<DiscountService>()
            //    .AddTransient<MetafieldService>()
            //    .AddTransient<OneTimeProductService>()
            //    .AddTransient<OrderService>()
            //    .AddTransient<ProductService>()
            //    .AddTransient<ShopService>()
            //    .AddTransient<SubscriptionService>()
            //    .AddTransient<WebhookService>();

            return services;
        }
    }
}

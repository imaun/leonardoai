using LeonardoAi.Contracts;

namespace LeonardoAi;

using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollection
{

    /// <summary>
    /// Adds LeonardoAI Client services to the ServiceCollection.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="apiKey">LeonardoAI ApiKey</param>
    /// <returns></returns>
    public static IServiceCollection AddLeonardoAiClient(this IServiceCollection services, string apiKey)
    {
        services.AddHttpClient();
        
        services.AddSingleton<ILeonardoAiClient>(provider =>
        {
            var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
            return new LeonardoAiClient(httpClientFactory, apiKey);
        });
        return services;
    }
}
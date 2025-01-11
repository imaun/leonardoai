namespace LeonardoAi;

using Contracts;
using Internal;

public class LeonardoAiClient
{

    public LeonardoAiClient(IHttpClientFactory httpClientFactory, string apiKey)
    {
        ImageGeneration = new ImageGenerationsClient(httpClientFactory, apiKey);
    }
    
    public IImageGenerationsClient ImageGeneration { get; }
}
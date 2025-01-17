namespace LeonardoAi;

using Contracts;
using Internal;

/// <inheritdoc />
public class LeonardoAiClient : ILeonardoAiClient
{

    public LeonardoAiClient(IHttpClientFactory httpClientFactory, string apiKey)
    {
        ImageGeneration = new ImageGenerationsClient(httpClientFactory, apiKey);
        InitImages = new InitImagesClient(httpClientFactory, apiKey);
    }
    
    public IImageGenerationsClient ImageGeneration { get; }
    
    public IInitImagesClient InitImages { get; }
}
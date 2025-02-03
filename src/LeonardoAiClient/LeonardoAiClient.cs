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
        Prompt = new PromptClient(httpClientFactory, apiKey);
        Dataset = new DatasetClient(httpClientFactory, apiKey);
        Model = new ModelClient(httpClientFactory, apiKey);
        LcmGeneration = new LcmGenerationClient(httpClientFactory, apiKey);
    }
    
    public IImageGenerationsClient ImageGeneration { get; }
    
    public IInitImagesClient InitImages { get; }
    
    public IPromptClient Prompt { get; }
    
    public IDatasetClient Dataset { get; }
    
    public IModelClient Model { get; }
    
    public ILcmGenerationClient LcmGeneration { get; }
}
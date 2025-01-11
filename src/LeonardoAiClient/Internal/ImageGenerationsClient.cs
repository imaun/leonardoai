namespace LeonardoAi.Internal;

using Contracts;
using Models;

internal class ImageGenerationsClient : LeonardoAiRestClient, IImageGenerationsClient
{
    const string EndpointBaseUrl = "/api/rest/v1/generations";
    
    public ImageGenerationsClient(IHttpClientFactory httpClientFactory, string apiKey) 
        : base(httpClientFactory, apiKey)
    {
    }
    
    public async Task<ImageGenerationResponse> GenerateImageAsync(
        ImageGenerationRequest request,
        CancellationToken cancellationToken = default)
    {
        if (request == null) 
            throw new ArgumentNullException(nameof(request));
        
        return (await PostAsync<ImageGenerationRequest, ImageGenerationResponse>(
            EndpointBaseUrl,
            request,
            cancellationToken
        ))!;
    }
    
    
}

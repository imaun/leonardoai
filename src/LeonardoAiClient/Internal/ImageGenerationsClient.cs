using LeonardoAiClient.Requests;
using LeonardoAiClient.Responses;

namespace LeonardoAiClient.Internal;

internal class ImageGenerationsClient : LeonardoAiRestClient
{
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
            "/api/rest/v1/generations",
            request,
            cancellationToken
        ))!;
    }
}

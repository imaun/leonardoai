namespace LeonardoAi.Internal;

using Contracts;
using Models;

/// <inheritdoc />
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
        ArgumentNullException.ThrowIfNull(request);

        return (await PostAsync<ImageGenerationRequest, ImageGenerationResponse>(
            EndpointBaseUrl,
            request,
            cancellationToken
        ).ConfigureAwait(false))!;
    }
    
    
    public async Task<GetGenerationByIdResponse?> GetGenerationByIdAsync(
        string generationId,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(generationId);
        
        string endpoint = $"{EndpointBaseUrl}/{generationId}";
        
        return await GetAsync<GetGenerationByIdResponse>(endpoint, cancellationToken).ConfigureAwait(false);
    }
}

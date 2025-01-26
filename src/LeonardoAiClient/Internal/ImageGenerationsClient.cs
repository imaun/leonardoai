namespace LeonardoAi.Internal;

using Contracts;
using Models;

/// <inheritdoc cref="LeonardoAi.Contracts.IImageGenerationsClient" />
internal class ImageGenerationsClient : LeonardoAiRestClient, IImageGenerationsClient
{
    const string EndpointBaseUrl = "/api/rest/v1/generations";
    
    public ImageGenerationsClient(IHttpClientFactory httpClientFactory, string apiKey) 
        : base(httpClientFactory, apiKey)
    {
    }
    
    /// <inheritdoc />
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
    
    /// <inheritdoc />
    public async Task<GetGenerationByIdResponse?> GetGenerationByIdAsync(
        string generationId,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(generationId);
        
        string endpoint = $"{EndpointBaseUrl}/{generationId}";
        
        return await GetAsync<GetGenerationByIdResponse>(endpoint, cancellationToken).ConfigureAwait(false);
    }
    
    /// <inheritdoc />
    public async Task DeleteGenerationByIdAsync(string generationId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(generationId))
            throw new ArgumentException("Generation ID cannot be null or empty.", nameof(generationId));
        
        var endpoint = $"/api/rest/v1/generations/{generationId}";
        
        await DeleteAsync(endpoint, cancellationToken).ConfigureAwait(false);
    }

}

using System.Text.Json;
using LeonardoAi.Contracts;
using LeonardoAi.Models;

namespace LeonardoAi.Internal; 

// <inheritdoc />
internal class InitImagesClient : LeonardoAiRestClient, IInitImagesClient
{
    const string EndpointBaseUrl = "/api/rest/v1/init-image";

    public InitImagesClient(IHttpClientFactory httpClientFactory, string apiKey)
        : base(httpClientFactory, apiKey)
    {
    }

    // <inheritdoc />
    public async Task<UploadInitImageResponse?> UploadInitImageAsync(
        UploadInitImageRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        return await PostAsync<UploadInitImageRequest, UploadInitImageResponse>(
            EndpointBaseUrl,
            request,
            cancellationToken
        ).ConfigureAwait(false);
    }

    // <inheritdoc />
    public async Task UploadImageAsync(
        Stream fileStream, string url, string fields, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(url)) 
            throw new ArgumentException("URL cannot be null or empty.", nameof(url));
        
        if (fileStream == null || fileStream.Length == 0) 
            throw new ArgumentException("File stream cannot be null or empty.", nameof(fileStream));
        
        var fieldsDictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(fields);
        if (fieldsDictionary == null)
            throw new InvalidOperationException("Failed to deserialize fields.");
        
        await PostFileAsync(url, fieldsDictionary, fileStream, cancellationToken).ConfigureAwait(false);
    }
}
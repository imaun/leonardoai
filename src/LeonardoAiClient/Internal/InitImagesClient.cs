using LeonardoAi.Contracts;
using LeonardoAi.Models;

namespace LeonardoAi.Internal; 

/// <summary>
/// Client for handling operations related to Init Images.
/// </summary>
internal class InitImagesClient : LeonardoAiRestClient, IInitImagesClient
{
    const string EndpointBaseUrl = "/api/rest/v1/init-image";

    public InitImagesClient(IHttpClientFactory httpClientFactory, string apiKey)
        : base(httpClientFactory, apiKey)
    {
    }

    /// <summary>
    /// Uploads an init image and retrieves presigned details for uploading to S3.
    /// </summary>
    /// <param name="request">The request containing the image file extension.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>The response containing the presigned upload details.</returns>
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
}
namespace LeonardoAi.Contracts;

using Models;

/// <summary>
/// Interface for operations related to Init Images.
/// </summary>
public interface IInitImagesClient
{
    
    /// <summary>
    /// Uploads an init image and retrieves presigned details for uploading to S3.
    /// </summary>
    /// <param name="request">The request containing the image file extension.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response with presigned upload details.</returns>
    Task<UploadInitImageResponse?> UploadInitImageAsync(
        UploadInitImageRequest request,
        CancellationToken cancellationToken = default);
}
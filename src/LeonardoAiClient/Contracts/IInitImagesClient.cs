namespace LeonardoAi.Contracts;

using Models;

/// <summary>
/// Client for handling operations related to Init Images.
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
    
    /// <summary>
    /// Uploads an image to a presigned URL.
    /// </summary>
    /// <param name="fileStream">The file content as a stream to be uploaded.</param>
    /// <param name="url">The presigned URL for the file upload.</param>
    /// <param name="fields">A JSON string representing the required form fields for the upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if any of the parameters <paramref name="url"/>, <paramref name="fileStream"/>, or <paramref name="fields"/> are null or invalid.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown if deserialization of the <paramref name="fields"/> JSON string fails.
    /// </exception>
    Task UploadImageAsync(
        Stream fileStream, string url, string fields,
        CancellationToken cancellationToken = default);
}
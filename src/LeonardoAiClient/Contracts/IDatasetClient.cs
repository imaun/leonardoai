namespace LeonardoAi.Contracts;

using Models;

/// <summary>
/// Client for handling operations related to Datasets.
/// </summary>
public interface IDatasetClient
{
    /// <summary>
    /// Creates a new dataset.
    /// </summary>
    /// <param name="request">The request containing the dataset name and optional description.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the ID of the created dataset.</returns>
    Task<CreateDatasetResponse?> CreateDatasetAsync(CreateDatasetRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a dataset by its ID.
    /// </summary>
    /// <param name="datasetId">The ID of the dataset to retrieve.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the dataset details.</returns>
    Task<GetDatasetResponse?> GetDatasetByIdAsync(string datasetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a dataset by its ID.
    /// </summary>
    /// <param name="datasetId">The ID of the dataset to delete.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DeleteDatasetByIdAsync(string datasetId, CancellationToken cancellationToken = default);

    
    /// <summary>
    /// Uploads an image to a dataset and retrieves presigned details for uploading to S3.
    /// </summary>
    /// <param name="datasetId">The ID of the dataset to which the image will be uploaded.</param>
    /// <param name="request">The request containing the image file extension.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response with presigned upload details.</returns>
    Task<UploadDatasetImageResponse?> UploadDatasetImageAsync(
        string datasetId,
        UploadDatasetImageRequest request,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Uploads a previously generated image to a dataset.
    /// </summary>
    /// <param name="datasetId">The ID of the dataset to which the image will be uploaded.</param>
    /// <param name="request">The request containing the generated image ID.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response with the uploaded image ID.</returns>
    Task<UploadDatasetImageFromGenResponse?> UploadDatasetImageFromGenAsync(
        string datasetId,
        UploadDatasetImageFromGenRequest request,
        CancellationToken cancellationToken = default);
}
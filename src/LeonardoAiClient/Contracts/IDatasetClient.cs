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
    
}
namespace LeonardoAi.Contracts;

using Models;

/// <summary>
/// Services to Train custom Models
/// </summary>
public interface IModelClient
{
    
    /// <summary>
    /// Trains a new custom model.
    /// </summary>
    /// <param name="request">The request containing training parameters.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response with the trained model ID and API credit cost.</returns>
    Task<TrainModelResponse?> TrainModelAsync(
        TrainModelRequest request,
        CancellationToken cancellationToken = default);
}
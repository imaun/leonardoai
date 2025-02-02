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
    
    /// <summary>
    /// Retrieves a custom model by its ID.
    /// </summary>
    /// <param name="modelId">The ID of the custom model to retrieve.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the model details.</returns>
    Task<GetModelResponse?> GetModelByIdAsync(string modelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a custom model by its ID.
    /// </summary>
    /// <param name="modelId">The ID of the custom model to delete.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DeleteModelByIdAsync(string modelId, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Retrieves a list of custom models by user ID.
    /// </summary>
    /// <param name="userId">The ID of the user whose models should be retrieved.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. 
    /// The task result contains a list of custom models belonging to the user.
    /// </returns>
    Task<GetUserModelsResponse?> GetModelsByUserIdAsync(string userId, CancellationToken cancellationToken = default);

}
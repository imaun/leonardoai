namespace LeonardoAi.Contracts;

using Models;

public interface IImageGenerationsClient
{
    
    /// <summary>
    /// Generates an image based on the specified request parameters.
    /// </summary>
    /// <param name="request">The request containing parameters for image generation.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>The task result contains the image generation response.</returns>
    Task<ImageGenerationResponse> GenerateImageAsync(
        ImageGenerationRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves information about a specific generation by its ID.
    /// </summary>
    /// <param name="generationId">The ID of the generation to retrieve.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>The task result contains the response with details about the specified generation.</returns>
    Task<GetGenerationByIdResponse?> GetGenerationByIdAsync(
        string generationId,
        CancellationToken cancellationToken = default);
    
    
    /// <summary>
    /// Deletes a single image generation by its ID.
    /// </summary>
    /// <param name="generationId">The ID of the image generation to delete.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DeleteGenerationByIdAsync(string generationId, CancellationToken cancellationToken = default);

}
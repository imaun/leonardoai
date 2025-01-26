namespace LeonardoAi.Contracts;

using Models;

/// <summary>
/// Client for handling operations related to Prompts.
/// </summary>
public interface IPromptClient
{
    /// <summary>
    /// Generates a random prompt.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the generated random prompt and API credit cost.</returns>
    Task<PromptGenerationResponse?> RandomAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Improves a given prompt based on the provided instructions.
    /// </summary>
    /// <param name="request">The request containing the prompt and optional improvement instructions.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the improved prompt and API credit cost.</returns>
    Task<PromptGenerationResponse?> ImproveAsync(PromptImproveRequest request, CancellationToken cancellationToken = default);
}

namespace LeonardoAi.Contracts;

using Models;
using System.Threading.Tasks;

public interface ILcmGenerationClient
{
    
    /// <summary>
    /// Creates an LCM image generation request.
    /// </summary>
    /// <param name="request">The request containing generation parameters.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response with generated images.</returns>
    Task<CreateLcmGenerationResponse?> CreateLcmGenerationAsync(
        CreateLcmGenerationRequest request,
        CancellationToken cancellationToken = default);
    
    
    /// <summary>
    /// Performs instant refinement on an LCM image.
    /// </summary>
    /// <param name="request">The request containing refinement parameters.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the refined image.</returns>
    Task<PerformInstantRefineResponse?> PerformInstantRefineAsync(
        PerformInstantRefineRequest request,
        CancellationToken cancellationToken = default);
}
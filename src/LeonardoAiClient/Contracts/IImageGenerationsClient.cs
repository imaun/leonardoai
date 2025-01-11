namespace LeonardoAi.Contracts;

using Models;

public interface IImageGenerationsClient
{
    
    Task<ImageGenerationResponse> GenerateImageAsync(
        ImageGenerationRequest request,
        CancellationToken cancellationToken = default);
}
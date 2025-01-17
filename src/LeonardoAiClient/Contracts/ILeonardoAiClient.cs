namespace LeonardoAi.Contracts;

public interface ILeonardoAiClient
{
    
    IImageGenerationsClient ImageGeneration { get; }
    
    
    IInitImagesClient InitImages { get; }
}
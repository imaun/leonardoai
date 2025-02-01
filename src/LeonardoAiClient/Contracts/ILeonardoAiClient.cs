namespace LeonardoAi.Contracts;

/// <summary>
/// Provides all the underlying APIs from LeonardoAI
/// </summary>
public interface ILeonardoAiClient
{

    IImageGenerationsClient ImageGeneration { get; }

    IInitImagesClient InitImages { get; }

    IPromptClient Prompt { get; }
    
    
    IDatasetClient Dataset { get; }
    
    IModelClient Model { get; }

}
namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for retrieving a list of public platform models.
/// </summary>
public class GetPlatformModelsResponse
{
    /// <summary>
    /// The list of platform models available for public use.
    /// </summary>
    [JsonPropertyName("custom_models")]
    public List<PlatformModelDetails>? PlatformModels { get; set; }
}

/// <summary>
/// Represents details of a platform model.
/// </summary>
public class PlatformModelDetails
{
    /// <summary>
    /// The ID of the platform model.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// The name of the platform model.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The description of the platform model.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether the platform model is featured.
    /// </summary>
    [JsonPropertyName("featured")]
    public bool Featured { get; set; }

    /// <summary>
    /// Indicates whether the platform model is NSFW.
    /// </summary>
    [JsonPropertyName("nsfw")]
    public bool Nsfw { get; set; }

    /// <summary>
    /// The generated image associated with the platform model.
    /// </summary>
    [JsonPropertyName("generated_image")]
    public PlatformModelGeneratedImage? GeneratedImage { get; set; }
}

/// <summary>
/// Represents a generated image associated with a platform model.
/// </summary>
public class PlatformModelGeneratedImage
{
    /// <summary>
    /// The ID of the generated image.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// The URL of the generated image.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for retrieving a custom model by ID.
/// </summary>
public class GetModelResponse
{
    [JsonPropertyName("custom_models_by_pk")]
    public CustomModelDetails? CustomModel { get; set; }
}

/// <summary>
/// Represents detailed custom model information.
/// </summary>
public class CustomModelDetails
{
    /// <summary>
    /// The ID of the custom model.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// The name of the custom model.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The description of the custom model.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The instance prompt used during training.
    /// </summary>
    [JsonPropertyName("instancePrompt")]
    public string? InstancePrompt { get; set; }

    /// <summary>
    /// The height of the model.
    /// </summary>
    [JsonPropertyName("modelHeight")]
    public int ModelHeight { get; set; }

    /// <summary>
    /// The width of the model.
    /// </summary>
    [JsonPropertyName("modelWidth")]
    public int ModelWidth { get; set; }

    /// <summary>
    /// Indicates whether the model is public.
    /// </summary>
    [JsonPropertyName("public")]
    public bool IsPublic { get; set; }

    /// <summary>
    /// The version of Stable Diffusion used.
    /// </summary>
    [JsonPropertyName("sdVersion")]
    public string? SdVersion { get; set; }

    /// <summary>
    /// The status of the model training process.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The type of the custom model.
    /// </summary>
    [JsonPropertyName("type")]
    public string? ModelType { get; set; }

    /// <summary>
    /// The timestamp when the model was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The timestamp when the model was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}

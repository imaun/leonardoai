namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Request model for training a custom model.
/// </summary>
public class TrainModelRequest
{
    /// <summary>
    /// The name of the model.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The description of the model.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; } = string.Empty;

    /// <summary>
    /// The ID of the dataset to train the model on.
    /// </summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; } = string.Empty;

    /// <summary>
    /// The instance prompt to use during training.
    /// </summary>
    [JsonPropertyName("instance_prompt")]
    public string InstancePrompt { get; set; } = string.Empty;

    /// <summary>
    /// The type of model to train.
    /// </summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }

    /// <summary>
    /// Whether or not the model is NSFW.
    /// </summary>
    [JsonPropertyName("nsfw")]
    public bool? Nsfw { get; set; } = false;

    /// <summary>
    /// The resolution for training. Must be 512 or 768.
    /// </summary>
    [JsonPropertyName("resolution")]
    public int? Resolution { get; set; } = 512;

    /// <summary>
    /// The base version of Stable Diffusion to use.
    /// </summary>
    [JsonPropertyName("sd_version")]
    public string? SdVersion { get; set; } = "v1_5";

    /// <summary>
    /// The strength of the training.
    /// </summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

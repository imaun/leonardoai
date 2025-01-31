namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Request model for uploading a previously generated image to a dataset.
/// </summary>
public class UploadDatasetImageFromGenRequest
{
    /// <summary>
    /// The ID of the image to upload to the dataset.
    /// </summary>
    [JsonPropertyName("generatedImageId")]
    public string GeneratedImageId { get; set; } = string.Empty;
}
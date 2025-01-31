namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Request model for uploading a dataset image.
/// </summary>
public class UploadDatasetImageRequest
{
    /// <summary>
    /// The file extension of the image (must be png, jpg, jpeg, or webp).
    /// </summary>
    [JsonPropertyName("extension")]
    public string Extension { get; set; } = string.Empty;
}
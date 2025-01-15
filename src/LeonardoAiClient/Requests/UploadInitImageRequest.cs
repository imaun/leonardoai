namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Request model for uploading an init image.
/// </summary>
public class UploadInitImageRequest
{
    /// <summary>
    /// The extension of the image file (png, jpg, jpeg, or webp).
    /// </summary>
    [JsonPropertyName("extension")]
    public string Extension { get; set; } = string.Empty;
}
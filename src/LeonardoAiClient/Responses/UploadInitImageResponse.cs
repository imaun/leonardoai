namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for uploading an init image, containing presigned details for S3 upload.
/// </summary>
public class UploadInitImageResponse
{
    [JsonPropertyName("uploadInitImage")]
    public InitImageUploadDetails? UploadInitImage { get; set; }
}

/// <summary>
/// Details for the presigned S3 upload.
/// </summary>
public class InitImageUploadDetails
{
    /// <summary>
    /// The fields required for the S3 upload.
    /// </summary>
    [JsonPropertyName("fields")]
    public string? Fields { get; set; }

    /// <summary>
    /// The ID of the uploaded image.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The key of the uploaded image in the S3 bucket.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The presigned URL for uploading the image to S3.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
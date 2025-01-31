namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for uploading a dataset image.
/// </summary>
public class UploadDatasetImageResponse
{
    [JsonPropertyName("uploadDatasetImage")]
    public DatasetUploadOutput? UploadDatasetImage { get; set; }
}

/// <summary>
/// Represents the details of the dataset image upload.
/// </summary>
public class DatasetUploadOutput
{
    /// <summary>
    /// The required fields for the upload request.
    /// </summary>
    [JsonPropertyName("fields")]
    public string? Fields { get; set; }

    /// <summary>
    /// The ID of the uploaded dataset image.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The key for the uploaded dataset image.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The URL where the dataset image should be uploaded.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
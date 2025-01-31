namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for uploading a generated image to a dataset.
/// </summary>
public class UploadDatasetImageFromGenResponse
{
    [JsonPropertyName("uploadDatasetImageFromGen")]
    public DatasetGenUploadOutput? UploadDatasetImageFromGen { get; set; }
}

/// <summary>
/// Represents the details of the uploaded generated image.
/// </summary>
public class DatasetGenUploadOutput
{
    /// <summary>
    /// The ID of the uploaded dataset image.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
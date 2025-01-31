using System.Text.Json.Serialization;

namespace LeonardoAi.Models;

/// <summary>
/// Response model for retrieving a dataset by ID.
/// </summary>
public class GetDatasetResponse
{
    [JsonPropertyName("datasets_by_pk")]
    public DatasetDetails? Dataset { get; set; }
}

/// <summary>
/// Represents detailed dataset information.
/// </summary>
public class DatasetDetails
{
    /// <summary>
    /// The ID of the dataset.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// The name of the dataset.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The description of the dataset.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The timestamp when the dataset was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The timestamp when the dataset was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// A list of dataset images associated with this dataset.
    /// </summary>
    [JsonPropertyName("dataset_images")]
    public List<DatasetImage> DatasetImages { get; set; } = new();
}

/// <summary>
/// Represents an image associated with a dataset.
/// </summary>
public class DatasetImage
{
    /// <summary>
    /// The ID of the dataset image.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    /// <summary>
    /// The URL of the dataset image.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// The timestamp when the dataset image was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
}

/// <summary>
/// Response model for deleting a dataset.
/// </summary>
public class DeleteDatasetResponse
{
    [JsonPropertyName("delete_datasets_by_pk")]
    public DeletedDataset? DeletedDataset { get; set; }
}

/// <summary>
/// Represents the deleted dataset details.
/// </summary>
public class DeletedDataset
{
    /// <summary>
    /// The ID of the deleted dataset.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
}

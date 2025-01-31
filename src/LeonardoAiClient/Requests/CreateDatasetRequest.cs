namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Request model for creating a dataset.
/// </summary>
public class CreateDatasetRequest
{
    /// <summary>
    /// The name of the dataset.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// A description for the dataset.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>
/// Response model for creating a dataset.
/// </summary>
public class CreateDatasetResponse
{
    [JsonPropertyName("insert_datasets_one")]
    public Dataset? InsertDatasetsOne { get; set; }
}

/// <summary>
/// Represents a single dataset entry.
/// </summary>
public class Dataset
{
    /// <summary>
    /// The ID of the dataset.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
}
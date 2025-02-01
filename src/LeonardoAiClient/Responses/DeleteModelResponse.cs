namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for deleting a custom model.
/// </summary>
public class DeleteModelResponse
{
    [JsonPropertyName("delete_custom_models_by_pk")]
    public DeletedCustomModel? DeletedCustomModel { get; set; }
}

/// <summary>
/// Represents the deleted custom model details.
/// </summary>
public class DeletedCustomModel
{
    /// <summary>
    /// The ID of the deleted custom model.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
}
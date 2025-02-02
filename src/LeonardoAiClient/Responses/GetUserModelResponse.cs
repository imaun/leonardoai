namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for retrieving a list of custom models by user ID.
/// </summary>
public class GetUserModelsResponse
{
    /// <summary>
    /// The list of custom models belonging to the user.
    /// </summary>
    [JsonPropertyName("custom_models")]
    public List<CustomModelDetails>? CustomModels { get; set; }
}
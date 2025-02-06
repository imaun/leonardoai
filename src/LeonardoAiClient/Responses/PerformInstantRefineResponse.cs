namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for performing instant refinement on an LCM image.
/// </summary>
public class PerformInstantRefineResponse
{
    [JsonPropertyName("lcmGenerationJob")]
    public LcmGenerationOutput? LcmGenerationJob { get; set; }
}
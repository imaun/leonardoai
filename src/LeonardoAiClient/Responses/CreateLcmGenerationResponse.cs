namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for LCM image generation.
/// </summary>
public class CreateLcmGenerationResponse
{
    [JsonPropertyName("lcmGenerationJob")]
    public LcmGenerationOutput? LcmGenerationJob { get; set; }
}

/// <summary>
/// Represents the output of an LCM image generation request.
/// </summary>
public class LcmGenerationOutput
{
    /// <summary>
    /// The generated image data URLs.
    /// </summary>
    [JsonPropertyName("imageDataUrl")]
    public List<string> ImageDataUrls { get; set; } = new();

    /// <summary>
    /// Timestamp when the request was processed.
    /// </summary>
    [JsonPropertyName("requestTimestamp")]
    public DateTime RequestTimestamp { get; set; }

    /// <summary>
    /// API credit cost for the generation.
    /// </summary>
    [JsonPropertyName("apiCreditCost")]
    public int? ApiCreditCost { get; set; }
}
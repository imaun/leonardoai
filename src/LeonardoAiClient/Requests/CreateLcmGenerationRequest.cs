namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Request model for creating an LCM image generation.
/// </summary>
public class CreateLcmGenerationRequest
{
    /// <summary>
    /// Image data used to generate the image, in base64 format. Prefix: `data:image/jpeg;base64,`
    /// </summary>
    [JsonPropertyName("imageDataUrl")]
    public string ImageDataUrl { get; set; } = string.Empty;

    /// <summary>
    /// The prompt used to generate images.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = string.Empty;

    /// <summary>
    /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
    /// </summary>
    [JsonPropertyName("guidance")]
    public float? Guidance { get; set; }

    /// <summary>
    /// Creativity strength of the generation. Higher strength will deviate more from the original image. Must be a float between 0.1 and 1.
    /// </summary>
    [JsonPropertyName("strength")]
    public float? Strength { get; set; }

    /// <summary>
    /// Timestamp of the request.
    /// </summary>
    [JsonPropertyName("requestTimestamp")]
    public DateTime? RequestTimestamp { get; set; }

    /// <summary>
    /// The style to apply for generation.
    /// </summary>
    [JsonPropertyName("style")]
    public string? Style { get; set; }

    /// <summary>
    /// The number of steps to use for the generation. Must be between 4 and 16.
    /// </summary>
    [JsonPropertyName("steps")]
    public int? Steps { get; set; }

    /// <summary>
    /// The output width of the image. Must be 512, 640, or 1024.
    /// </summary>
    [JsonPropertyName("width")]
    public int? Width { get; set; } = 512;

    /// <summary>
    /// The output height of the image. Must be 512, 640, or 1024.
    /// </summary>
    [JsonPropertyName("height")]
    public int? Height { get; set; } = 512;

    /// <summary>
    /// The seed value for deterministic generation.
    /// </summary>
    [JsonPropertyName("seed")]
    public long? Seed { get; set; }
}

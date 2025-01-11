using System.Text.Json.Serialization;

namespace LeonardoAi.Models;

public class ImageGenerationRequest
{
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = "A majestic cat in the snow";

    [JsonPropertyName("alchemy")]
    public bool? Alchemy { get; set; } = true;

    [JsonPropertyName("contrastRatio")]
    public float? ContrastRatio { get; set; }

    [JsonPropertyName("expandedDomain")]
    public bool? ExpandedDomain { get; set; }

    [JsonPropertyName("fantasyAvatar")]
    public bool? FantasyAvatar { get; set; }

    [JsonPropertyName("guidance_scale")]
    public int? GuidanceScale { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; } = 768;

    [JsonPropertyName("highContrast")]
    public bool? HighContrast { get; set; }

    [JsonPropertyName("highResolution")]
    public bool? HighResolution { get; set; }

    [JsonPropertyName("imagePrompts")]
    public List<string>? ImagePrompts { get; set; }

    [JsonPropertyName("imagePromptWeight")]
    public float? ImagePromptWeight { get; set; }

    [JsonPropertyName("init_generation_image_id")]
    public string? InitGenerationImageId { get; set; }

    [JsonPropertyName("init_image_id")]
    public string? InitImageId { get; set; }

    [JsonPropertyName("init_strength")]
    public float? InitStrength { get; set; }

    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; } = "b24e16ff-06e3-43eb-8d33-4416c2d75876";

    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; set; }

    [JsonPropertyName("num_images")]
    public int? NumImages { get; set; } = 4;

    [JsonPropertyName("num_inference_steps")]
    public int? NumInferenceSteps { get; set; } = 15;

    [JsonPropertyName("public")]
    public bool? Public { get; set; }

    [JsonPropertyName("transparency")]
    public string? Transparency { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; } = 1024;

    [JsonPropertyName("ultra")]
    public bool? Ultra { get; set; }

    [JsonPropertyName("unzoom")]
    public bool? Unzoom { get; set; }

    [JsonPropertyName("unzoomAmount")]
    public float? UnzoomAmount { get; set; }

    [JsonPropertyName("upscaleRatio")]
    public float? UpscaleRatio { get; set; }
}
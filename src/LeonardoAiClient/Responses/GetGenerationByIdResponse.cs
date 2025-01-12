namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

public class GetGenerationByIdResponse
{
    [JsonPropertyName("generations_by_pk")]
    public GenerationByPk? Generation { get; set; }
}

public class GenerationByPk
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("generated_images")]
    public List<GeneratedImage>? GeneratedImages { get; set; }

    [JsonPropertyName("generation_elements")]
    public List<GenerationElement>? GenerationElements { get; set; }

    [JsonPropertyName("guidanceScale")]
    public float? GuidanceScale { get; set; }

    [JsonPropertyName("imageHeight")]
    public int ImageHeight { get; set; }

    [JsonPropertyName("imageWidth")]
    public int ImageWidth { get; set; }

    [JsonPropertyName("inferenceSteps")]
    public int? InferenceSteps { get; set; }

    [JsonPropertyName("initStrength")]
    public float? InitStrength { get; set; }

    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    [JsonPropertyName("negativePrompt")]
    public string? NegativePrompt { get; set; }

    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = string.Empty;

    [JsonPropertyName("public")]
    public bool Public { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

public class GeneratedImage
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("fantasyAvatar")]
    public bool? FantasyAvatar { get; set; }

    [JsonPropertyName("likeCount")]
    public int LikeCount { get; set; }

    [JsonPropertyName("nsfw")]
    public bool Nsfw { get; set; }

    [JsonPropertyName("generated_image_variation_generics")]
    public List<ImageVariationGeneric>? GeneratedImageVariationGenerics { get; set; }
}

public class ImageVariationGeneric
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("transformType")]
    public string? TransformType { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public class GenerationElement
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("weightApplied")]
    public float? WeightApplied { get; set; }

    [JsonPropertyName("lora")]
    public LoraElement? Lora { get; set; }
}

public class LoraElement
{
    [JsonPropertyName("akUUID")]
    public string? AkUUID { get; set; }

    [JsonPropertyName("baseModel")]
    public string? BaseModel { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("urlImage")]
    public string? UrlImage { get; set; }

    [JsonPropertyName("weightDefault")]
    public float? WeightDefault { get; set; }

    [JsonPropertyName("weightMax")]
    public float? WeightMax { get; set; }

    [JsonPropertyName("weightMin")]
    public float? WeightMin { get; set; }
}

namespace LeonardoAiClient.Responses;

using System.Text.Json.Serialization;

public class ImageGenerationResponse
{
    [JsonPropertyName("sdGenerationJob")]
    public SdGenerationJob? SdGenerationJob { get; set; }
}

public class SdGenerationJob
{
    [JsonPropertyName("generationId")]
    public string GenerationId { get; set; }

    [JsonPropertyName("apiCreditCost")]
    public int? ApiCreditCost { get; set; }
}
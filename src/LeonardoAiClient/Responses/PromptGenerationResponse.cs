namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

public class PromptGenerationResponse
{
    [JsonPropertyName("promptGeneration")]
    public PromptGenerationOutput? PromptGeneration { get; set; }
}

public class PromptGenerationOutput
{
    /// <summary>
    /// The generated or improved prompt.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = string.Empty;

    /// <summary>
    /// API credits cost for the operation.
    /// </summary>
    [JsonPropertyName("apiCreditCost")]
    public int ApiCreditCost { get; set; }
}

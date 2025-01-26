namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

public class PromptImproveRequest
{
    /// <summary>
    /// The prompt to improve.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = string.Empty;

    /// <summary>
    /// Optional improvement instructions.
    /// </summary>
    [JsonPropertyName("promptInstructions")]
    public string? PromptInstructions { get; set; }
}
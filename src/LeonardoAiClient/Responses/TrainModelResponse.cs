namespace LeonardoAi.Models;

using System.Text.Json.Serialization;

/// <summary>
/// Response model for training a custom model.
/// </summary>
public class TrainModelResponse
{
    [JsonPropertyName("sdTrainingJob")]
    public TrainingJobOutput? SdTrainingJob { get; set; }
}

/// <summary>
/// Represents the details of the trained model.
/// </summary>
public class TrainingJobOutput
{
    /// <summary>
    /// The ID of the trained custom model.
    /// </summary>
    [JsonPropertyName("customModelId")]
    public string CustomModelId { get; set; } = string.Empty;

    /// <summary>
    /// API Credits Cost for Model Training. Available for Production API Users.
    /// </summary>
    [JsonPropertyName("apiCreditCost")]
    public int? ApiCreditCost { get; set; }
}
namespace LeonardoAi.Internal;

using Models;
using Contracts;

/// <inheritdoc cref="LeonardoAi.Contracts.IModelClient"/> 
public class ModelClient : LeonardoAiRestClient, IModelClient
{
    public ModelClient(IHttpClientFactory httpClientFactory, string apiKey) 
        : base(httpClientFactory, apiKey)
    {
    }

    /// <inheritdoc />
    public async Task<TrainModelResponse?> TrainModelAsync(
        TrainModelRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request, nameof(request));

        const string endpoint = "/api/rest/v1/models";
        return await PostAsync<TrainModelRequest, TrainModelResponse>(endpoint, request, cancellationToken).ConfigureAwait(false);
    }
}
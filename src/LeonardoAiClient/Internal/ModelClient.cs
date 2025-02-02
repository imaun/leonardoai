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

    /// <inheritdoc />
    public async Task<GetModelResponse?> GetModelByIdAsync(string modelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId, nameof(modelId));
        
        string endpoint = $"/api/rest/v1/models/{modelId}";
        return await GetAsync<GetModelResponse>(endpoint, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task DeleteModelByIdAsync(string modelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId, nameof(modelId));
        
        string endpoint = $"/api/rest/v1/models/{modelId}";
        await DeleteAsync(endpoint, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GetUserModelsResponse?> GetModelsByUserIdAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(userId, nameof(userId));
        
        string endpoint = $"/api/rest/v1/models/user/{userId}";
        return await GetAsync<GetUserModelsResponse>(endpoint, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<GetPlatformModelsResponse?> GetPlatformModelsAsync(CancellationToken cancellationToken = default)
    {
        string endpoint = "/api/rest/v1/platformModels";
        return await GetAsync<GetPlatformModelsResponse>(endpoint, cancellationToken).ConfigureAwait(false);
    }
}
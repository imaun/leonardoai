namespace LeonardoAi.Internal;

using Models;
using Contracts;

/// <inheritdoc cref="LeonardoAi.Contracts.IDatasetClient" /> 
public class DatasetClient : LeonardoAiRestClient, IDatasetClient 
{
    public DatasetClient(IHttpClientFactory httpClientFactory, string apiKey) 
        : base(httpClientFactory, apiKey)
    {
    }

    /// <inheritdoc /> 
    public async Task<CreateDatasetResponse?> CreateDatasetAsync(
        CreateDatasetRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        
        const string endpoint = "/api/rest/v1/datasets";
        return await PostAsync<CreateDatasetRequest, CreateDatasetResponse>
            (endpoint, request, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc /> 
    public async Task<GetDatasetResponse?> GetDatasetByIdAsync(string datasetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(datasetId);
        
        string endpoint = $"/api/rest/v1/datasets/{datasetId}";
        return await GetAsync<GetDatasetResponse>(endpoint, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc /> 
    public async Task DeleteDatasetByIdAsync(string datasetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(datasetId);
        
        string endpoint = $"/api/rest/v1/datasets/{datasetId}";
        await DeleteAsync(endpoint, cancellationToken).ConfigureAwait(false);
    }

}
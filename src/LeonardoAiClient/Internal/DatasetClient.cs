namespace LeonardoAi.Internal;

using Models;
using Contracts;

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
    
    
    // public async Task<>
}
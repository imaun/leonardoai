namespace LeonardoAi.Internal;

using Contracts;
using Models;

public class LcmGenerationClient : LeonardoAiRestClient, ILcmGenerationClient
{
    public LcmGenerationClient(IHttpClientFactory httpClientFactory, string apiKey) 
        : base(httpClientFactory, apiKey)
    {
    }

    /// <inheritdoc /> 
    public async Task<CreateLcmGenerationResponse?> CreateLcmGenerationAsync(
        CreateLcmGenerationRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request, nameof(request));

        const string endpoint = "/api/rest/v1/generations-lcm";
        return await PostAsync<CreateLcmGenerationRequest, CreateLcmGenerationResponse>
            (endpoint, request, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc /> 
    public async Task<PerformInstantRefineResponse?> PerformInstantRefineAsync(
        PerformInstantRefineRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request, nameof(request));
        
        const string endpoint = "/api/rest/v1/lcm-instant-refine"; 
        return await PostAsync<PerformInstantRefineRequest, PerformInstantRefineResponse>
            (endpoint, request, cancellationToken).ConfigureAwait(false);
    }
}
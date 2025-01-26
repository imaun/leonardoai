namespace LeonardoAi.Internal;

using Contracts;
using Models;

internal class PromptClient : LeonardoAiRestClient, IPromptClient
{
    public PromptClient(IHttpClientFactory httpClientFactory, string apiKey)
        : base(httpClientFactory, apiKey)
    {
    }

    /// <inheritdoc />
    public async Task<PromptGenerationResponse?> RandomAsync(CancellationToken cancellationToken = default)
    {
        const string endpoint = "/api/rest/v1/prompt/random";
        return await PostAsync<object, PromptGenerationResponse>(endpoint, null!, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<PromptGenerationResponse?> ImproveAsync(PromptImproveRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        const string endpoint = "/api/rest/v1/prompt/improve";
        return await PostAsync<PromptImproveRequest, PromptGenerationResponse>(endpoint, request, cancellationToken).ConfigureAwait(false);
    }
}

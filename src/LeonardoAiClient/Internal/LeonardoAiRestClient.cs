using System.Net.Http.Json;

namespace LeonardoAiClient.Internal;

internal class LeonardoAiRestClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    
    public LeonardoAiRestClient(IHttpClientFactory httpClientFactory, string apiKey)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        if (string.IsNullOrWhiteSpace(apiKey)) 
            throw new ArgumentException("API key must not be null or empty.", nameof(apiKey));
        _apiKey = apiKey;
        _httpClient = _httpClientFactory.CreateClient("LeonardoAi");
        
        //set default headers
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        _httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "UTF-8");
    }
    
    /// <summary>
    /// Sends a POST request to the specified endpoint with the given request payload and returns the response.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request payload.</typeparam>
    /// <typeparam name="TResponse">The type of the response payload.</typeparam>
    /// <param name="endpoint">The relative endpoint URL.</param>
    /// <param name="request">The request payload.</param>
    /// <returns>The deserialized response object.</returns>
    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endpoint)) 
            throw new ArgumentException("Endpoint must not be null or empty.", nameof(endpoint));

        try
        {
            var response = await _httpClient.PostAsJsonAsync(endpoint, request, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>(cancellationToken: cancellationToken);
            }
            
            var errorContent = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new HttpRequestException($"Request failed with status {response.StatusCode}: {errorContent}");
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while calling the API: {ex.Message}", ex);
        }
    }
}
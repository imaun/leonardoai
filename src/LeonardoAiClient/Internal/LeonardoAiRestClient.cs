namespace LeonardoAi.Internal;

using System.Net.Http.Json;

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

        // Set the base address for the API
        _httpClient.BaseAddress = new Uri("https://cloud.leonardo.ai");

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
            var response = await _httpClient.PostAsJsonAsync(endpoint, request, cancellationToken).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>(cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            
            var errorContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            throw new HttpRequestException($"Request failed with status {response.StatusCode}: {errorContent}");
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while calling the API: {ex.Message}", ex);
        }
    }
    
    /// <summary>
    /// Sends a GET request to the specified endpoint and returns the response.
    /// </summary>
    public async Task<TResponse?> GetAsync<TResponse>(string endpoint, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endpoint)) 
            throw new ArgumentException("Endpoint must not be null or empty.", nameof(endpoint));

        try
        {
            var response = await _httpClient.GetAsync(endpoint, cancellationToken).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var errorContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            throw new HttpRequestException($"Request failed with status {response.StatusCode}: {errorContent}");
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while calling the API: {ex.Message}", ex);
        }
    }
    
    /// <summary>
    /// Uploads a file to the specified URL using multipart form data.
    /// </summary>
    /// <param name="url">The presigned URL for the file upload.</param>
    /// <param name="fields">A dictionary containing the required form fields for the upload.</param>
    /// <param name="fileStream">The file content as a stream to be uploaded.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains the ID of the uploaded file 
    /// (if provided in the fields dictionary).
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown if any of the parameters <paramref name="url"/>, <paramref name="fields"/>, or <paramref name="fileStream"/> 
    /// are null or invalid.
    /// </exception>
    /// <exception cref="HttpRequestException">
    /// Thrown if the server responds with a failure status code.
    /// </exception>
    public async Task PostFileAsync(
        string url,
        Dictionary<string, string> fields,
        Stream fileStream,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(url)) 
            throw new ArgumentException("URL cannot be null or empty.", nameof(url));
        
        if (fileStream == null || fileStream.Length == 0) 
            throw new ArgumentException("File stream cannot be null or empty.", nameof(fileStream));

        using var multipartContent = new MultipartFormDataContent();

        // Add the fields as form data
        foreach (var field in fields)
        {
            multipartContent.Add(new StringContent(field.Value), field.Key);
        }

        var fileContent = new StreamContent(fileStream);
        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
        multipartContent.Add(fileContent, "file");
        
        using var httpClient = _httpClientFactory.CreateClient();
        
        var response = await httpClient.PostAsync(url, multipartContent, cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            throw new HttpRequestException($"File upload failed with status {response.StatusCode}: {errorContent}");
        }
    }
    
    
    /// <summary>
    /// Sends a DELETE request to the specified endpoint.
    /// </summary>
    /// <param name="endpoint">The relative endpoint URL.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <exception cref="ArgumentException">Thrown if the endpoint is null or empty.</exception>
    /// <exception cref="HttpRequestException">Thrown if the server responds with a failure status code.</exception>
    public async Task DeleteAsync(string endpoint, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endpoint))
            throw new ArgumentException("Endpoint must not be null or empty.", nameof(endpoint));

        try
        {
            var response = await _httpClient.DeleteAsync(endpoint, cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                throw new HttpRequestException($"Request failed with status {response.StatusCode}: {errorContent}");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while calling the API: {ex.Message}", ex);
        }
    }


}
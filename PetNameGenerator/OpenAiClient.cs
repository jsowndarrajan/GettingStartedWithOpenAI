using System.Net.Http.Json;

namespace PetNameGenerator;

public class OpenAiClient : IOpenAiClient
{
    private readonly HttpClient _httpClient;


    public OpenAiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CreateCompletionResponse> CreateCompletion(CreateCompletionRequest completionRequest)
    {
        var response = await _httpClient.PostAsJsonAsync(
            Constants.OpenAI.Endpoints.Completion,
            completionRequest);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<CreateCompletionResponse>() ?? new DefaultCreateCompletionResponse();
        }

        return new DefaultCreateCompletionResponse();
    }
}
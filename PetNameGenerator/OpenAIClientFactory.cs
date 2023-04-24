using System.Net.Http.Headers;
using static PetNameGenerator.Constants;

namespace PetNameGenerator
{
    public static class OpenAIClientFactory
    {
        public static IOpenAiClient Create()
        {
            var apiKey = Environment.GetEnvironmentVariable(OpenAI.EnvironmentVariables.ApiKey);
            ArgumentException.ThrowIfNullOrEmpty(apiKey);

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(OpenAI.BaseAddress),
                DefaultRequestHeaders =
                {
                    Authorization = new AuthenticationHeaderValue(OpenAI.Authorization.Scheme, apiKey)
                }

            };

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return new OpenAiClient(httpClient);
        }
    }
}

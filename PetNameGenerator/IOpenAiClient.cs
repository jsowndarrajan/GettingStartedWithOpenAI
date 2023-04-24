namespace PetNameGenerator;

public interface IOpenAiClient
{
    Task<CreateCompletionResponse> CreateCompletion(CreateCompletionRequest completionRequest);
}
namespace PetNameGenerator;

public class CreateCompletionRequest
{
    public string Model { get; }

    public string Prompt { get; set; }

    public CreateCompletionRequest(string model, string prompt)
    {
        Model = model;
        Prompt = prompt;
    }
}
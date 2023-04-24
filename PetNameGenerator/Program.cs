namespace PetNameGenerator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = OpenAIClientFactory.Create();

            Console.WriteLine("Enter Animal Name: ");
            var animalName = Console.ReadLine();

            ArgumentException.ThrowIfNullOrEmpty(animalName);

            var completionRequest = new CreateCompletionRequest(
                Constants.OpenAI.Models.Davinci,
                GeneratePrompt(animalName));

            var response = await httpClient.CreateCompletion(completionRequest);

            foreach (var choice in response.Choices)
            {
                Console.WriteLine(choice.Text);
            }
        }

        private static string GeneratePrompt(string animal)
        {
            return "Suggest three names for an animal that is a superhero. For instance:\n" +
                "Animal: Cat\n" +
                "Names: Captain Sharpclaw, Agent Fluffball, The Incredible Feline\n" +
                "Animal: Dog\n" +
                "Names: Ruff the Protector, Wonder Canine, Sir Barks-a-Lot\n" +
                $"Animal: {animal.ToUpper()}\n" +
                "Names:";
        }
    }
}
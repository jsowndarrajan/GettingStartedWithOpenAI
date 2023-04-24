namespace PetNameGenerator;

public static class Constants
{
    public static class OpenAI
    {
        public const string DomainUrl = "https://api.openai.com";
        public const string Version = "v1";
        public const string BaseAddress = $"{DomainUrl}/{Version}/";

        public static class Endpoints
        {
            public const string Completion = "completions";
        }

        public static class EnvironmentVariables
        {
            public const string ApiKey = "OpenAI-ApiKey";
        }

        public static class Authorization
        {
            public const string Scheme = "Bearer";
        }

        public static class Models
        {
            public const string Davinci = "davinci";
        }
    }

}
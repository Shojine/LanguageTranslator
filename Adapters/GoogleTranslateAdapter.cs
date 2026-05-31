using Google.Cloud.Translation.V2;

public class GoogleTranslateAdapter : ITranslationService
{
    private readonly Google.Cloud.Translation.V2.TranslationClient client;

    public GoogleTranslateAdapter(string apiKey)
    {
        client = Google.Cloud.Translation.V2.TranslationClient.CreateFromApiKey(apiKey);
    }

    public Task<string> DetectLanguageAsync(string text)
    {
        var detection = client.DetectLanguage(text);
        return Task.FromResult(detection.Language);
    }

    public Task<IEnumerable<string>> GetSupportedLanguagesAsync()
    {
        var languages = client.ListLanguages();
        return Task.FromResult(languages.Select(l => l.Code));
    }

    public Task<bool> IsValidLanguageAsync(string language)
    {
        return Task.FromResult(GetSupportedLanguagesAsync().GetAwaiter().GetResult().Contains(language));
    }

    public Task<string> TranslateAsync(string text, string targetLanguage)
    {
        var translation = client.TranslateText(text, targetLanguage);
        return Task.FromResult(translation.TranslatedText);
    }
}
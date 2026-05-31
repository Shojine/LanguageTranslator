

public interface ITranslationService
{
    Task<string> TranslateAsync(string text, string targetLanguage);
    Task<string> DetectLanguageAsync(string text);
    Task<IEnumerable<string>> GetSupportedLanguagesAsync();
    Task<bool> IsValidLanguageAsync(string language);
}
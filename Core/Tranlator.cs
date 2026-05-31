public class Translator : ITranslator
{
    private readonly ITranslationService translationService;


    public Translator(ITranslationService transServ)
    {
        this.translationService = transServ;
    }
    public string Translate(string text, string targetLanguage)
    {
        return translationService.TranslateAsync(text, targetLanguage).GetAwaiter().GetResult();
    }

    public string TranslateEnglish(string text)
    {
        return translationService.TranslateAsync(text, "en").GetAwaiter().GetResult();
    }

    public string DetectLanguage(string text)
    {
        return translationService.DetectLanguageAsync(text).GetAwaiter().GetResult();
    }

    public bool IsValidLanguage(string language)
    {
        return translationService.GetSupportedLanguagesAsync().GetAwaiter().GetResult().Contains(language);
    }

    public string TranslateFromLanguage(string text, string sourceLanguage, string targetLanguage)
    {
        return translationService.TranslateFromLanguageAsync(text, sourceLanguage, targetLanguage).GetAwaiter().GetResult();
    }
}
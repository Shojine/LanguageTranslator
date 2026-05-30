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

    public bool IsValidLanguage(string language)
    {
        return translationService.GetSupportedLanguagesAsync().GetAwaiter().GetResult().Contains(language);
    }
}

public interface ITranslator
{
    string Translate(string text, string targetLanguage);
    string TranslateEnglish(string text);
    string DetectLanguage(string text);
    bool IsValidLanguage(string language);
    string TranslateFromLanguage(string text, string sourceLanguage, string targetLanguage);
}
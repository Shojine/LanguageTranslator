using Azure.AI.Translation.Text;
public class Config
{
    public static Translator transInstance{ get; private set; }
    public string GoogleApiKey { get; set; }
    public void Initialize()
    {
        ITranslationService translationService = new GoogleTranslateAdapter(GoogleApiKey);
        transInstance = new Translator(translationService);
    }
}
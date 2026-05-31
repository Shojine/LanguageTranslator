using Azure.AI.Translation.Text;
public class Config
{
    private static Config instance;

    public static Config Instance()
    {
        if (instance == null)
        {
            instance = new Config();
        }
        return instance;
    }

    private Config() { }
    public static Translator transInstance{ get; private set; }
    public string GoogleApiKey { get; set; }
    public void Initialize()
    {
        ITranslationService translationService = new GoogleTranslateAdapter(GoogleApiKey);
        transInstance = new Translator(translationService);
    }
}
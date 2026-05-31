public class TranslatorFacade
{
    private static TranslatorFacade instance;

    public static TranslatorFacade Instance()
    {
        if (instance == null)
        {
            instance = new TranslatorFacade();
        }
        return instance;
    }

    private TranslatorFacade() { }


    public string Translate(bool autoDetect = true)
    {
        if (autoDetect)
        {
            string textToTranslate = ReadInput("Enter text to translate: ", false);
            return Config.transInstance.TranslateEnglish(Config.transInstance.DetectLanguage(textToTranslate));
        }
        else
        {
            return Config.transInstance.Translate(ReadInput("Enter text to translate: ", false), ReadInput("Enter target language: ", true));
        }
    }
    private string ReadInput(string prompt, bool isLanguage = false)
    {
        Console.WriteLine(prompt);
        if (string.IsNullOrEmpty(prompt))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
            return ReadInput(prompt);
        }
        else
        {
            var input = Console.ReadLine();
            if(isLanguage && !Config.transInstance.IsValidLanguage(input))
            {
                Console.WriteLine("Invalid language. Please try again.");
                return ReadInput(prompt, true);
            }
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                return ReadInput(prompt);
            }
        }
        return "error";
    }
}
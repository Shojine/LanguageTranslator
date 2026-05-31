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


    public string Translate(bool autoDetect = true, string sourceLanguage = "en")
    {
        if (autoDetect)
        {
            string textToTranslate = ReadInput("Enter text to translate: ");
            return Config.transInstance.TranslateEnglish(textToTranslate);
        }
        else
        {
            if(sourceLanguage == "en")
            {
                return Config.transInstance.Translate(ReadInput("Enter text to translate: "), ReadInput("Enter target language: ", true));
            }
            return Config.transInstance.TranslateFromLanguage(ReadInput("Enter text to translate: "), ReadInput("Enter source language: ", true), ReadInput("Enter target language: ", true));
        }
    }
    private string ReadInput(string prompt, bool isLanguage = false)
    {
        Console.Write(prompt);
        var input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
            return ReadInput(prompt, isLanguage);
        }
        if (isLanguage && !Config.transInstance.IsValidLanguage(input))
        {
            Console.WriteLine("Invalid language. Please try again.");
            return ReadInput(prompt, isLanguage);
        }
        return input;
    }
}
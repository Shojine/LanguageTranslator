public static class ConsoleMenu
{
    public static void ShowMenu()
    {
        Console.WriteLine("Welcome to the Language Translator!");
        Console.WriteLine("1. Translate Text");
        Console.WriteLine("2. Exit");
        Console.Write("Please select an option: ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("\nYou selected: Translate Text");
                ITranslator translator =  Config.transInstance;
                Console.Write("Enter text to translate: ");
                string text = Console.ReadLine();
                if(string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Input text cannot be empty. Please try again.");
                    ShowMenu();
                    return;
                }
                Console.Write("Enter target language: ");
                string targetLanguage = Console.ReadLine();
                if(string.IsNullOrEmpty(targetLanguage))
                {
                    Console.WriteLine("Target language cannot be empty. Please try again.");
                    ShowMenu();
                    return;
                }
                if(!Config.transInstance.IsValidLanguage(targetLanguage))
                {
                    Console.WriteLine("Invalid target language. Please try again.");
                    ShowMenu();
                    return;
                }
                string translatedText = translator.Translate(text, targetLanguage);
                Console.WriteLine($"Translated Text: {translatedText}");
                ShowMenu(); // Loop till they choose to exit
                break;
            case ConsoleKey.D2:
                Console.WriteLine("\nExiting the application. Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nInvalid option. Please try again.");
                ShowMenu(); // Show the menu again for valid input
                break;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string apiKey = "AIzaSyCDdNHm3oBSwwzC3fhFxZAs2C4nOEyUqyM";
        if(string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Google API key is not set.");
            return;
        }
        Config config = new Config { GoogleApiKey = apiKey };
        config.Initialize();
        ConsoleMenu.ShowMenu();
    }
}
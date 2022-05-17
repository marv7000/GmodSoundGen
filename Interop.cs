namespace GmodSoundGen;

public class Interop
{
    public static void WriteLog(string message, MessageType type)
    {
        switch (type)
        {
            case MessageType.Error:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("[ERROR]\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
                break;
            case MessageType.Warning:
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("[WARN]\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
                break;
            case MessageType.Info:
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("[INFO]\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
                break;
            case MessageType.Debug:
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("[DEBUG]\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
                break;
        }
    }

    public enum MessageType
    {
        Error,
        Warning,
        Info,
        Debug
    }
}

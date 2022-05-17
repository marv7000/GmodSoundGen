/// MIT License
/// Program by marv7000

namespace GmodSoundGen;

public class SoundGen
{
    static readonly int Version = 1;
    
    public static void Main(string[] args)
    {
        Interop.WriteLog($"GmodSoundGen v{Version}", Interop.MessageType.Info);
        try
        {
            Interop.WriteLog($"Reading file:\t{args[0]}", Interop.MessageType.Info);
            var file = ReadCSV(args[0]);
        }
        catch(Exception e)
        {
            Interop.WriteLog(e.Message, Interop.MessageType.Error);
            return;
        }
    }

    /// <summary>
    /// Reads a CSV spreadsheet and returns a 2D string array.
    /// </summary>
    /// <param name="fileName">File to read.</param>
    /// <returns></returns>
    public static string[,] ReadCSV(string fileName)
    {
        // Open the file
        StreamReader file = new StreamReader(fileName);

        // Read the header row
        string[] headers = file.ReadLine().Split(',');

        // Initialize the 2D array
        string[,] output = new string[headers.Length, headers.Length];

        // Read the file line by line
        while (!file.EndOfStream)
        {
            string[] row = file.ReadLine().Split(',');

            // Populate the 2D array
            for (int i = 0; i < headers.Length; i++)
            {
                output[i, 0] = headers[i];
                output[i, 1] = row[i];
            }
        }

        // Close the file
        file.Close();

        // Return the 2D array
        return output;
    }
}
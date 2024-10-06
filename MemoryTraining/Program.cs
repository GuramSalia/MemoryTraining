using System;
using System.Speech.Synthesis;
using System.Threading;

internal class Program
{
    private static void Main()
    {
        string[] words = { "right", "left", "up", "down" };
        Random random = new Random();
        bool continueReading = true;

        // Initialize the SpeechSynthesizer
        using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
        {
            Console.WriteLine("Press any key to stop...");

            // Start reading words in a loop
            while (!Console.KeyAvailable && continueReading)
            {
                string word = words[random.Next(words.Length)];
                Console.WriteLine(word); // Also print the word on the console
                synthesizer.Speak(word); // Read the word aloud
                Thread.Sleep(1500); // Pause for 1.5 seconds
            }

            continueReading = false;
            Console.WriteLine("Stopped.");
        }
    }
}
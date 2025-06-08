using SimpleMalObfuscator.Commands;

namespace SimpleMalObfuscator
{
    public class Program
    {
        public static readonly string MenuArt = @"
               @@   @@@@   @@   
               @@@  @@@@  @@@  
               @@@  @@@@  @@@   
                @@@@@@@@@@@@
                   @@@@@@       
                    @@@@       
                    @@@@        
                    @@@@
  SimpleMalObfuscador by github.com/joaostack
";

        /// <summary>
        /// Obfuscate a binary/executable
        /// </summary>
        /// <param name="filePath">Target file</param>
        /// <param name="outFile">Output PS1 file</param>
        static void Main(string filePath, string outFile)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MenuArt);
            Console.ResetColor();

            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(outFile))
            {
                Console.WriteLine("Use -h to show options.");
                return;
            }

            try
            {
                var command = new ObfuscateCommand(filePath, outFile);
                command.Execute();
            } catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR: {ex}");
            }
        }
    }
}
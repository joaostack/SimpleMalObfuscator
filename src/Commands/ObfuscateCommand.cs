using SimpleMalObfuscator.Core;
using System.Diagnostics;

namespace SimpleMalObfuscator.Commands
{
    public class ObfuscateCommand
    {
        private readonly string _filePath;
        private readonly string _outFile;

        public ObfuscateCommand(string filePath, string outFile)
        {
            _filePath = filePath;
            _outFile = outFile;
        }

        public void Execute()
        {
            var content = Ofuscator.GetBinContent(_filePath);
            var b64Content = Ofuscator.ConvertBinToBase64(_filePath);
            Ofuscator.SaveToPS1(b64Content, _outFile);
        }
    }
}

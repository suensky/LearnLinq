using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnLinq
{
    public class Utilities
    {
        public static void Test()
        {
            Console.WriteLine(GetBinPath());

            Console.WriteLine(GetRandomBinFilePath());
        }

        public static string GetBinPath()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }

        public static string GetRandomBinFilePath()
        {
            string fileName = Path.GetRandomFileName() + ".xml";

            return Path.Combine(GetBinPath(), fileName);
        }
    }
}

using System;
using System.IO;
using System.Text.RegularExpressions;


namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"C:\f.txt");
            var result = Regex.Matches(text, @"\b[eyuioa]+\w*[eyuioa]", RegexOptions.IgnoreCase);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace File
{
    class File
    {
        string lineText, tmp, path;
        int count = 0;

        public string Input()
        {
            tmp = Console.ReadLine();
            return tmp;
        }

        public void findWord(string word, string p)
        {
            Regex rgx = new Regex(word);
            lineText = readFile(p);

            foreach (Match match in rgx.Matches(lineText))
            {
                count++;
                
            }

            Console.WriteLine("В файле найдено {0} раз слово {1} ", count, word);
        }

        public void replaceWord(string p, string oldWord, string newWord)
        {
            lineText = readFile(p);
            Regex rgx = new Regex(oldWord);
            string result = rgx.Replace(lineText, newWord);

            try
            {
                StreamWriter writer = new StreamWriter(path);
                writer.Write(result);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Replaced!");

        }

        private string readFile(string p)
        {
            try
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, p);
                StreamReader reader = new StreamReader(path);
                lineText = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lineText;
        }

    }
}

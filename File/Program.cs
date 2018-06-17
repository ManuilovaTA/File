using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            File f = new File();
            string path, word, word2, task;

            Console.WriteLine("Enter the path to file:");
            path = f.Input();

            Console.WriteLine("Enter the number of task:" +
                "\n Find the number of occurrences of a string in a text file  => 1" +
                "\n To replace a string with another in the specified file => 2");
            task = Console.ReadLine();

            switch (task)
            {
                case "1":
                    Console.WriteLine("Enter the word:");
                    word = f.Input();
                    f.findWord(word, path);
                    break;
                case "2":
                    Console.WriteLine("Enter the word:");
                    word = f.Input();
                    Console.WriteLine("Enter the word for replace:");
                    word2 = f.Input();
                    f.replaceWord(path, word, word2);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.ReadKey();
        }
    }
}

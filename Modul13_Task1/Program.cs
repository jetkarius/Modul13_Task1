using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Modul_13_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("H:\\Text1.txt");
            CreateListT(text);

            CreateLinkList(text);
        }
        static void CreateListT(string text)
        {

            Console.WriteLine("\nCreateListT начал работу");

            char[] delimiters = new char[] { ' ', '\r', '\n', ',', '.' };

            var wordslist = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newElements = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            var timer = new Stopwatch();
            timer.Start();

            wordslist.AddRange(newElements);

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.WriteLine("CreateListT завершил работу");
            Console.ReadKey();


        }
        static void CreateLinkList(string text)
        {
            Console.WriteLine("\nCreateLinkList начал работу");

            char[] delimiters = new char[] { ' ', '\r', '\n', ',', '.' };

            var wordslist = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newElements = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            var linkedList = new LinkedList<string>(wordslist);

            var timer = new Stopwatch();
            timer.Start();

            foreach (var el in newElements)
            {
                linkedList.AddAfter(linkedList.First, el);
            }

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.WriteLine("CreateLinkList завершил работу");
            Console.ReadKey();
        }
    }
}
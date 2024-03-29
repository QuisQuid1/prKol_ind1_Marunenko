using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace индивидуалка_коллекции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stack
            /*try
            {
                Console.WriteLine("Введите выражение в префиксной форме, например- / - A - B C + - D E F");
                string exp = Console.ReadLine();
                var t = exp.Split(' ').Reverse().ToArray();
                Stack<string> s = new Stack<string>();
                for (int i = 0; i < t.Length; i++)
                {
                    if ("+-/*".Contains(t[i]))
                    {

                        s.Push("(" + s.Pop() + t[i] + s.Pop() + ")");
                    }
                    else
                    {
                        s.Push(t[i]);
                    }
                }
                Console.WriteLine(s.Peek());
                Console.ReadKey();
            }
            catch { Console.WriteLine("Что то не то"); }*/

            //queque
            Queue<char> nonDigit = new Queue<char>();
            Queue<char> Digit = new Queue<char>();
            string file = @"C:\папка\програмки\индивидуалка коллекции\bin\Debug\text.txt";
            string fileContent = File.ReadAllText(file);
            try 
            {
                if (File.Exists("text.txt"))
                {
                    if (fileContent==" ")
                    {
                        Console.WriteLine("Файл пуст");
                    }
                    else 
                    {
                        foreach (char c in fileContent)
                        {
                            if (char.IsDigit(c))
                            {
                                Digit.Enqueue(c);
                            }
                            else if (char.IsLetter(c))
                            {
                                nonDigit.Enqueue(c);
                            }
                        }
                        Console.WriteLine("Символы, отличные от цифр:");
                        while (nonDigit.Count > 0)
                        {
                            Console.WriteLine(nonDigit.Dequeue());
                        }
                        Console.WriteLine("Цифры:");
                        while (Digit.Count > 0)
                        {
                            Console.WriteLine(Digit.Dequeue());
                        }
                    }
                }
                else { Console.WriteLine("Файла нет"); }
                Console.ReadKey();
            }
            catch { Console.WriteLine("Что то не то"); }
           
        }

    }
}


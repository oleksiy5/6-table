using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "";            
            while (txt.ToLower() != "end")
            {
                txt = Console.ReadLine();

                if (txt.All(char.IsDigit))
                {
                    int[] numbers = new int[txt.Length];
                    for (int i = 0; i < txt.Length; i++)                    
                        numbers[i] = int.Parse(txt[i].ToString());                    

                    foreach (int number in numbers)
                        Console.WriteLine(number);
                }
                else
                {
                    char[] chars = txt.ToArray();
                    foreach (char ch in chars)
                        Console.WriteLine($"{(int)ch} ({ch.ToString()})");
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using UserPosts.Data;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.App
{
    public class Program
    {
        delegate void Printer();
        static void Main()
        {
            //List<Printer> printers = new List<Printer>();
            //int i = 0;
            //for (; i < 10; i++)
            //{
            //    printers.Add(delegate { System.Console.WriteLine(i); });
            //}

            //foreach (var printer in printers)
            //{
            //    printer();
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (row <= 9 && col == 1)
                    {
                        Console.Write(" ");
                    }
                    else if (col >= 9)
                    {
                        Console.Write(col);
                    }
                    else
                    {
                        Console.Write(col + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
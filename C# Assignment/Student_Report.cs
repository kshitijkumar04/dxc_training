using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class arrayex1
    {
        static void Main()
        {
            int count;
            Console.WriteLine("Enter total no. of students");
            count = int.Parse(Console.ReadLine());
            string[] name = new string[count];
            Console.WriteLine("Enter the names");
            for(int i = 0; i < count; i++)
            {
                name[i] = Console.ReadLine();
            }
            int[,] marks = new int[count,5];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter marks for student "+name[i]);
                for (int j = 0; j < 5; j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                }               
            }           
            Console.WriteLine("Name    mark1   mark2   mark3   mark4   mark5   total   average");
            Console.WriteLine("---------------------------------------------------------------");
            for(int k = 0; k < count; k++)
            {
                Console.Write(name[k]+"\t");
                int p = 0;
                for (int m = 0; m < 5; m++)
                {
                    Console.Write(marks[k, m]+"\t");
                    p = (p + marks[k, m]);
                  
                }               
                double j = p / 5;
                Console.Write(p+"\t");
                Console.WriteLine(j);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

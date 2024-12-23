using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    internal class Queue1
    {
        Queue<string> qu = new Queue<string>();
        public void que()
        {

            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();

                qu.Enqueue(name);
            }
            Display();

        }
        public void Display()
        {
            Console.WriteLine("The details of students are : ");
            foreach (var i in qu)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenerics
{
    internal class Queue1
    {
        public Queue1()
        {
            Queue qu = new Queue();
            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();

                qu.Enqueue(name);

            }

            Console.WriteLine();
            Console.WriteLine("The details of students are : ");
            foreach (var i in qu)
            {
                Console.WriteLine(i);
            }

        }
    }
}

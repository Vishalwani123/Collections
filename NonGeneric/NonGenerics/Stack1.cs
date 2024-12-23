using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenerics
{
    internal class Stack1
    {
        public void stk()
        {
            Stack sk = new Stack();
            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();

                sk.Push(name);

            }

            Console.WriteLine();
            Console.WriteLine("The details of students are : ");
            foreach (var i in sk)
            {
                Console.WriteLine(i);
            }



        }


    }
}

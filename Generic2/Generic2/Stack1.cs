using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    internal class Stack1
    {
        Stack<string> st = new Stack<string>();
        public void s()
        {

            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();

                st.Push(name);
            }
            Display();

        }
        public void Display()
        {
            Console.WriteLine("The details of students are : ");
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }
        }

    }
}

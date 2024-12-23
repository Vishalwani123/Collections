using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    internal class List1
    {
        List<string> l1 = new List<string>();
        public void lt()
        {

            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();
                
                l1.Add(name);
            }
            Display();

        }
        public void Display()
        {
            Console.WriteLine("The details of students are : ");
            foreach (var i in l1)
            {
                Console.WriteLine(i);
            }
        }


    }
}

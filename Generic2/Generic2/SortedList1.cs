using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    internal class SortedList1
    {
        SortedList<int, string> sl = new SortedList<int, string>();
        public void st()
        {

            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age of student : ");
                int age = Convert.ToInt32(Console.ReadLine());
                sl.Add(age, name);
            }
            Display();

        }
        public void Display()
        {
            Console.WriteLine("The details of students are : ");
            foreach (KeyValuePair<int, string> i in sl)
            {
                Console.WriteLine(i.Key + ": " + i.Value);
            }
        }
    }
}

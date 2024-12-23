using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenerics
{
    internal class SortedList1
    {
        public void SorLis()
        {
            SortedList sl = new SortedList();
            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the roll-no of student : ");
                int rollno = Convert.ToInt32(Console.ReadLine());

                sl.Add(name, rollno);
            }

            Console.WriteLine();
            Console.WriteLine("The details of students are : ");
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }
    }
}

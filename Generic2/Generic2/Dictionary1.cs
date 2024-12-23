using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    internal class Dictionary1
    {
        Dictionary<int, string> dt = new Dictionary<int, string>();
        public void dct()
        {

            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age of student : ");
                int age = Convert.ToInt32(Console.ReadLine());
                dt.Add(age, name);
            }
            Display();
  
        }
        public void Display()
        {
            Console.WriteLine("The details of students are : ");
            foreach(KeyValuePair<int, string> i in dt)
            {
                Console.WriteLine(i.Key + ": " + i.Value);  
            }
        }
       
    }
}

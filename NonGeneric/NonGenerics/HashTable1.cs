using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenerics
{
    internal class HashTable1
    {
        public void HasTab()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter the size ");
            int size = Convert.ToInt32(Console.ReadLine());
            

            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the name of student : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the roll-no of student : ");
                int rollno = Convert.ToInt32(Console.ReadLine());

                ht.Add(name, rollno);
            }

            foreach(DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }


    }
}

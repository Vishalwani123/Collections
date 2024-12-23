using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenerics
{
    internal class ArrayList1
    {
        public void ArrLis()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter the Name of Student : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Age of Student : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Student in percentage: ");
            double Marks = Convert.ToDouble(Console.ReadLine());

            al.Add(Name);
            al.Add(Age);
            al.Add(Marks);

            Console.WriteLine();
            Console.WriteLine("The Details of Students are : ");

            foreach(var i in al)
            {
                Console.WriteLine(i);
            }


        }



    }

}




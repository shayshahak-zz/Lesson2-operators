using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is my name";
            int myID = 4;
            string myPhone = "0542002002";
            Console.WriteLine("{0} {1} {2}", myString, myID, myPhone);
            Console.WriteLine(myString);
            Console.WriteLine(myID);
            Console.WriteLine(myPhone);
            double x = 3.5;
            double y = 4;
            double z = 2.33;
            Console.WriteLine("the sum is {0}", x + y + z);
            Console.WriteLine("the average is {0}", (x + y + z) / 3);
            Console.WriteLine("the multiplying is {0}", (x * y * z));
            int a = 5;
            int b = 10;//test
            int c;
            //my comment
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a is {0}", a);
            Console.WriteLine("b is {0}", b);
            a = (a * b);
            b = (a / b);
            a = (a / b);
            Console.WriteLine("a is {0}", a);
            Console.WriteLine("b is {0}", b);
        }
    }
}

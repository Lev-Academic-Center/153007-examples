using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            welcomeMethod();
            //Console.ReadKey();

            Student s1 = new Student();

            s1.Name = "Cinderella";
            s1.Age = 18;

            Student s2;
            s2 = s1;
            Console.WriteLine(s1.Name + s1.Age);
            Console.WriteLine(s2.Name + s2.Age);

            ValueTypeVSRefType myTest = new ValueTypeVSRefType();

            int[] arr = new int[30];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = i * 2;



            foreach (int i in arr)
                Console.WriteLine(i);


            myTest.a();

            Console.ReadKey();
        }

        private static void welcomeMethod()
        {
            Console.WriteLine("Enter Your Name");
            string usr;
            usr = "hi";
            String userName = Console.ReadLine();
            // Console.WriteLine("{0}, Welcome to my first console  application" , userName);
            Console.WriteLine(userName + " Welcome to my first console application"+usr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
             Enums.Days d = Enums.Days.Friday;
           
            string today = d.ToString();

            List<Student> StudentsList = new List<Student>();
            Student s1 = new Student("Moshe",20);
            
            Console.WriteLine(s1);

            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2011, 10, 05);

            if (date1.DayOfWeek  == (DayOfWeek)((int)d)-1)
                Console.WriteLine("Shabat Shaolm");
            switch (d)
            {
                case Enums.Days.Sunday:
                    Console.WriteLine("Shavua Tov");
                    break;
                case Enums.Days.Monday:
                    Console.WriteLine("Shiur C#");
                    break;
                case Enums.Days.Friday:
                    Console.WriteLine("Shabat Shaolm");
                    break;
                default:
                    Console.WriteLine("Tomorrow is another day");
                    break;
            }

            TimeSpan t = date1 - date2;
            string str2 = "32 13 15";
            
            try
            {
                int i = Int32.Parse(str2);
                //int[] myInts = Convert.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            var Person = new
            {
                Id = 1234,
                personName = "oshri"
             };

        }
        /// <summary>
        /// func dummy
        /// </summary>
        /// <returns>always return 1</returns>
        int func() { return 1; }
    }
}

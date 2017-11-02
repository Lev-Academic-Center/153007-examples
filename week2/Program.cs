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
            TimeSpan t = date1 - date2;
            string str2 = "3a2";

            try
            {
                int i = Int32.Parse(str2);
                int j = Convert.ToInt32(str2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// <summary>
        /// func dummy
        /// </summary>
        /// <returns>always return 1</returns>
        int func() { return 1; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1;

namespace Week5
{
    static class MyTools
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        public static Student ToStudent(this string str)
        {
            return Student.Parse(str);
        }
    }

}

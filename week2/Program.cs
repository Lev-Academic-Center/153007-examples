using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enums.Days d = Enums.Days.Friday;
            string today = d.ToString();
        }
        /// <summary>
        /// func
        /// </summary>
        /// <returns></returns>
        int func() { return 1; }
    }
}

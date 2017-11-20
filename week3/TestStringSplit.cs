using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public class TestStringSplit
    {
        static char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

        public static int[] ToIntArray(string str)
        {
            string[] words = str.Split(delimiterChars);
            List<int> arr = new List<int>();
            foreach (string s in words)
            {
                arr.Add(int.Parse(s));
            }

            return arr.ToArray();
        }




    }
}

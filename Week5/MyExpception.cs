using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class MyExpception : Exception
    {
        public MyExpception() :base() {}
        public MyExpception(string message) : base(message) {}
        public MyExpception(string message,
                           Exception inner) : base(message, inner) { }

    }
}

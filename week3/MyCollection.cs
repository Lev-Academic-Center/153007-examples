using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1;

namespace week3
{
    class MyCollection : IEnumerable
    {
        Student[] arr = new Student[10]; // ...
        public MyEnmrtr GetEnumerator() { return new MyEnmrtr(this); }
        class MyEnmrtr : IEnumerator
        {
            MyCollection coll; Student curr = null;
            int cntr = -1; // before the first element!!!
            internal MyEnmrtr(MyCollection coll) { this.coll = coll; }
            public void Reset() { } // deprecated – can be empty
            public object Current { get { return curr; } }
            public bool MoveNext()
            {
                if (++cntr >= coll.arr.Length) return false;
                else { curr = coll.arr[cntr]; return true; }
            }
        }
    }

}

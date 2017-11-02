using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1;

namespace week3
{
    public class BAStudent : Student
    {
        private bool _milga;

        public BAStudent(bool _milga) : base("Shlomo",18,2)
        {
            this._milga = _milga;
        }

        public bool Milga
        {
            get
            {
                return _milga;
            }

            set
            {
                _milga = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "milga: " + _milga;
        }
    }
}

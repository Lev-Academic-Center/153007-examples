using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1;

namespace week3
{
    class MAStudent : BAStudent
    {

        public override int getAve()
        {
            return base.getAve();
        }
        public MAStudent(bool _milga) : base(_milga)
        {
        }
    }
}

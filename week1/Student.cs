using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Student
    {

        private string _name;
	    private int _age;
        private int _id;

        public int Grade { get; set; }

        #region Properties
        public string Name {
		get {
            return _name;}
		set  {_name = value;}
	}

	public int Age {
		get {return _age;}
		set  {_age = value;}
	}

        public int Id
        {
            get {return _id; }
        }
    }
    #endregion
}

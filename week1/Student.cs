using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Student
    {

        private string _name;
	    private int _age;
        private int _id;


        public Student(string _name="", int _age=0, int _id=1)
        {
            this._name = _name;
            this._age = _age;
            this._id = _id;
        }

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
        #endregion

        public override string ToString()
        {
            return _name + " " + _id;
        }
    }
    
    
}

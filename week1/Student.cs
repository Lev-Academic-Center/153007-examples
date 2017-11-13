using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Student : IComparable
    {

        private string _name;
	    private int _age;
        private  int _id;

        private static int _counterId;

        #region Ctor
  
        public Student(string _name="", int _age=0, int _id=1)
        {
            this._name = _name;
            this._age = _age;
            this._id = _counterId++;
        }

        public Student(string _name, int _age)
        {
            this._name = _name;
            this._age = _age;
            this._id = _counterId++;
        }

        public Student(string _name)
        {
            this._name = _name;
            this._id = _counterId++;
        }
        #endregion

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

        public virtual int getAve()
        {
            return 80;
        }

        public int CompareTo(object obj)
        {
            return Grade.CompareTo((obj as Student).Grade);
            //return Id.CompareTo((obj as Student).Id);

        }
    }
    
    
}

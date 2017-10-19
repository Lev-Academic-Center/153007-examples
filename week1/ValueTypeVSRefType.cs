using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5776
{
    class MyClass //1
{
	public int x;
}
struct MyStruct //2
{
	public int x;
}

    class ValueTypeVSRefType
    {

        public void a()
        {
            ValueTypeVSRefType mainClass = new ValueTypeVSRefType();
            MyClass myClass = new MyClass(); //3
            MyStruct myStruct = new MyStruct(); //3     
            myClass.x = 9;
            myStruct.x = 9;
            System.Console.WriteLine("*** Before ***");
            System.Console.WriteLine("Class value is {0}", myClass.x);
            System.Console.WriteLine("Struct value is {0}", myStruct.x);
            mainClass.inc(myClass, ref myStruct); //4
            System.Console.WriteLine("*** After ***");
            System.Console.WriteLine("Class value is {0}", myClass.x);
            System.Console.WriteLine("Struct value is {0}", myStruct.x);
            System.Console.ReadLine();
        }
        void inc( MyClass mc,ref MyStruct ms)  //5
        {
            mc.x++;
            ms.x++;
        }
    }


}

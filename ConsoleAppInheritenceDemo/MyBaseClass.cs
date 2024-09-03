using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritenceDemo
{
    public abstract class MyBaseClass
    {

        public abstract string MyAbstractMethod();

        public MyBaseClass(int myBaseProperty)
        {
            MyBaseProperty = myBaseProperty;
        }

     

        public int MyBaseProperty { get; set; }


        public virtual string MybaseMethod()
        {
            return "In mybase method";
        }
    }
}

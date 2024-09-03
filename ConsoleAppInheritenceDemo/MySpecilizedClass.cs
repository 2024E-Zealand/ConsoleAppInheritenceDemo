using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritenceDemo
{
    public class MySpecilizedClass : MyBaseClass, IMyInterface
    {
        public MySpecilizedClass(string mySpecilizedProperty, int mybaseproperty)
            : base(mybaseproperty)
        {
            MySpecilizedProperty = mySpecilizedProperty;
        }

        public MySpecilizedClass(string mySpecilizedProperty)
            :this(mySpecilizedProperty, 0)
        {
                
        }

        public override string MybaseMethod()
        {
            return "In MySpicializedclass" + base.MybaseMethod();
        }

        public string MyInterfaceMethod()
        {
            throw new NotImplementedException();
        }

        public override string MyAbstractMethod()
        {
            throw new NotImplementedException();
        }

        public string MySpecilizedProperty { get; set; }


    }
}

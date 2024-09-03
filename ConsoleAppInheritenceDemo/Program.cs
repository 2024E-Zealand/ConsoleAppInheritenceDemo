// See https://aka.ms/new-console-template for more information
using ConsoleAppInheritenceDemo;

//Console.WriteLine("Hello, World!");

//MyBaseClass myBaseClass = new MyBaseClass(1);


//Console.WriteLine(myBaseClass.MybaseMethod());


MySpecilizedClass mySpec = new MySpecilizedClass("specialized prop");
Console.WriteLine( mySpec.MybaseMethod());


//brug af is og as keyword

//Console.WriteLine(mySpec is IMyInterface);
//(mySpec as IMyInterface).MyInterfaceMethod();
//(mySpec as MySpecilizedClass).MySpecilizedProperty="1";
//(mySpec as MyBaseClass).MybaseMethod();


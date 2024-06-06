using ConsoleAppClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppClass.Model.Animal;

namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //**class object
            Car myObj = new Car();

            //**Multiple Object
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);

            //**class Members
            MyClass myObj3 = new MyClass();
            Console.WriteLine(myObj3.color);
            Console.WriteLine(myObj3.maxSpeed);

            //**Constructors
            Car2 car2s = new Car2("Mustang");
            Console.WriteLine(car2s.model);
            //test test test555 5555 9999


            //**Access Modifiers
            // Create a myCar object
            Car3 myCar = new Car3();
            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);


            //**Polymorphism
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            //**abstract
            Pig2 myPig2 = new Pig2(); // Create a Pig object
            myPig2.animalSound();  // Call the abstract method
            myPig2.sleep();  // Call the regular method

            //**Interface
            Pig3 myPig3 = new Pig3();  // Create a Pig object
            myPig3.animalSound();

            //**Multiple Interfaces
            DemoClass myObj4 = new DemoClass();
            myObj4.myMethod();
            myObj4.myOtherMethod();
            myObj4.myTestDemo();

            //**Enum
            Level2 TY = new Level2();
            TY.levelTest();

            #region Equals
            // Construct a Point object.
            var p1 = new Point(1, 2);

            // Make another Point object that is a copy of the first.
            var p2 = p1.Copy();

            // Make another variable that references the first Point object.
            var p3 = p1;

            // The line below displays false because p1 and p2 refer to two different objects.
            Console.WriteLine(Object.ReferenceEquals(p1, p2));

            // The line below displays true because p1 and p2 refer to two different objects that have the same value.
            Console.WriteLine(Object.Equals(p1, p2));

            // The line below displays true because p1 and p3 refer to one object.
            Console.WriteLine(Object.ReferenceEquals(p1, p3));

            // The line below displays: p1's value is: (1, 2)
            Console.WriteLine($"p1's value is: {p1.ToString()}");
            #endregion

            //Object.GetType Method
            object[] values = { (int) 12, (long) 10653, (byte) 12, (sbyte) -5,
                   16.3, "string" };
            foreach (var value in values)
            {
                Type t = value.GetType();
                if (t.Equals(typeof(byte)))
                    Console.WriteLine("{0} is an unsigned byte.", value);
                else if (t.Equals(typeof(sbyte)))
                    Console.WriteLine("{0} is a signed byte.", value);
                else if (t.Equals(typeof(int)))
                    Console.WriteLine("{0} is a 32-bit integer.", value);
                else if (t.Equals(typeof(long)))
                    Console.WriteLine("{0} is a 64-bit integer.", value);
                else if (t.Equals(typeof(double)))
                    Console.WriteLine("{0} is a double-precision floating point.",
                                      value);
                else
                    Console.WriteLine("'{0}' is another data type.", value);
            }

            //Object.Finalize Method
            ExampleClass ext = new ExampleClass();
            ext.ShowDuration();





        }

        
    }
}

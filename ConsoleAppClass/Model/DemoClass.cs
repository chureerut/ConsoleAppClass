using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass.Model
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    interface ITestDemo
    {
        void myTestDemo();
    }
    // Implement multiple interfaces
    public class DemoClass : IFirstInterface, ISecondInterface, ITestDemo
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }

        public void myTestDemo()
        {
            Console.WriteLine("myTestDemo");
        }
    }
}

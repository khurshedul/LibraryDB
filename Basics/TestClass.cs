using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class TestClass
    {
        public int x = 0;
        private int y = 0;
        internal  int z = 0;
        protected  int k = 0;
        int p = 0;
        //public static void Main()
        //{
        //    TestClass c = new TestClass();
        //    c.x = 1;
        //    c.y = 2;
        //    c.z = 3;
        //    c.k = 4;
        //    c.p = 5;
        //    Console.Write($"{c.x },{c.y},{c.z},{c.k},{c.p}");
        //}
    }

    class MyClass: TestClass
    {
        public static void Main() {

            TestClass myClass = new MyClass();
            myClass.x = 1;
            myClass.z = 2;
           
            TestClass testClass = new TestClass();

            testClass.x = 3;
            testClass.z = 4;

            MyClass my = new MyClass();
            my.x = 5;
            my.z = 6;
            my.k = 7;
        }
    }


}

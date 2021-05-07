using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_test
{
    
     public class TestClass2 :BaseTests
    {

        [Test]
        public void Test1()
        {
            if (TestApp.inputTen() != 10)
            {
                throw new System.Exception("Not 10");
            }

        }

        [Test]
        public void Test2()
        {
            if (TestApp.inputTen() != 10)
            {
                throw new System.Exception("Not 10");
            }

        }

    }
}

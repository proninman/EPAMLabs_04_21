using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_test
{
    
    public class ClassTest : BaseTests
    {
        [Test,TestCaseSource("tempDate")]
        
        public void Test1(int x)
        {
            var temp = TestApp.inputTen(x);
            Assert.IsTrue(x== temp, $"Мы ожидали {x} а пришло {temp}");
        }

        [Test, TestCaseSource("tempDate")]
        public void Test2(int x)
        {
            var temp = TestApp.inputTen(x);
            Assert.IsTrue(x == temp, $"Мы ожидали {x} а пришло {temp}");
        }

        static object[] tempDate =
        {
            new object [] {10},
             new object [] {20},
              new object [] {30},

        };
     
    }
}
 
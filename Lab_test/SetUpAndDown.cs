using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_test
{
    [SetUpFixture]
    class SetUpAndDown
    {
        [OneTimeSetUp]
        public void OneSetUp()
        {

        }
        [OneTimeTearDown]
        public void OneDown()
        {

        }
    }
}

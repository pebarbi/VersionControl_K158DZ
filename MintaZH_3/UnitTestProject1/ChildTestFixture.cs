using MintaZH_3.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH_3
{
    public class ChildTestFixture
    {
        [   Test,
            TestCase(1, true),
            TestCase(2, true),
            TestCase(3, true),
            TestCase(4, true),
            TestCase(5, true),
            TestCase(555, true),
            TestCase(0, true)
        ]

        public void TestCheckBehaviour (int value, bool expectedResult)
        {
            //Arrange
            var c = new Child();

            //Act
            var actualResult = c.CheckBehaviour(value);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

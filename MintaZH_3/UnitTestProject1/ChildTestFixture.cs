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
            TestCase 1,
            TestCase 2,
            TestCase 3,
            TestCase 4,
            TestCase 5,
            TestCase 555
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

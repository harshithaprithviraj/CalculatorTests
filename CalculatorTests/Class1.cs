using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalculatorTests
{
    [TestFixture]
    class CalcTests
    {
       
        [Test]
        public void GetAddition_Input3point4and5point6_Returns9point0()
        {//Arrange
            double firstNumber = 3.4;
            double secondNumber = 5.6;
            double expectedResult = firstNumber + secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input7point4and5point2_Returns2point2()
        {//Arrange
            double firstNumber = 7.4;
            double secondNumber = 5.2;
            double expectedResult = firstNumber - secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input7point0and2point0_Returns14point0()
        {//Arrange
            double firstNumber = 7.0;
            double secondNumber = 2.0;
            double expectedResult = firstNumber * secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input6point0and3point0_Returns2point0()
        {//Arrange
            double firstNumber = 6.0;
            double secondNumber = 3.0;
            double expectedResult = firstNumber / secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input1point0and5point0_Returns6point0()
        {//Arrange
            double firstNumber = 1.0;
            double secondNumber = 5.0;
            double expectedResult = firstNumber + secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input9point4and3point2_Returns6point0()
        {//Arrange
            double firstNumber = 9.0;
            double secondNumber = 3.0;
            double expectedResult = firstNumber - secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input5point0and2point0_Returns10point0()
        {//Arrange
            double firstNumber = 5.0;
            double secondNumber = 2.0;
            double expectedResult = firstNumber * secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input8point0and4point0_Returns2point0()
        {//Arrange
            double firstNumber = 8.0;
            double secondNumber = 4.0;
            double expectedResult = firstNumber / secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input7point0and1point0_Returns8point0()
        {//Arrange
            double firstNumber = 7.0;
            double secondNumber = 1.0;
            double expectedResult = firstNumber + secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input9point5and3point2_Returns6point3()
        {//Arrange
            double firstNumber = 9.5;
            double secondNumber = 3.2;
            double expectedResult = firstNumber - secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input1point0and4point0_Returns4point0()
        {//Arrange
            double firstNumber = 1.0;
            double secondNumber = 4.0;
            double expectedResult = firstNumber * secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input3point0and1point0_Returns3point0()
        {//Arrange
            double firstNumber = 3.0;
            double secondNumber = 1.0;
            double expectedResult = firstNumber / secondNumber;
            Calc testCalc = new Calc(firstNumber, secondNumber);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

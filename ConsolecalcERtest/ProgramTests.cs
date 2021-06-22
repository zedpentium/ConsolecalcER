using System;
using Xunit;
using ConsolecalcER;

namespace ConsolecalcER.Tests
{ 
    public class ProgramTests
    {

        [Fact]
        public void TestDividByZero()
        {
            //Arrange
            int mChoice = 3; //3 is division
            double userTal1 = 200;
            double userTal2 = 0;
            //Program testMathDivide = null;
            //testMathDivide = new Program();

            //Act



            double resultSum = Program.DoMathWithInput(mChoice, userTal1, userTal2);
            //testMathDivide(4);

            // DoMathWithInput
            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.NotEqual(0, resultSum);

        }

        [Fact]
        public void TestMyMathMethod()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 1; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            double userTal1 = 25; // First value
            double userTal2 = 7; // Second Value
            //Program testMathWays = null;
            //testMathDivide = new Program();

            //Act
            //testMathWays = new Program();


            double resultSum = Program.DoMathWithInput(mChoice, userTal1, userTal2);
            //testMathDivide(4);

            // DoMathWithInput
            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(32, resultSum);
        }

        [Fact]
        public void TestPlusArrInput()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 1; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            double[] inpArray = new double[] { 5, 78, 98, 78 };

            //Act
            //testMathWays = new Program();

            double resultSum = Program.DoMathWithInput(mChoice, inpArray);

            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(259, resultSum);
        }

        [Fact]
        public void TestMinusArrInput()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 2; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            double[] inpArray = new double[] { 535, 78, 98, 78 };

            //Act
            //testMathWays = new Program();

            double resultSum = Program.DoMathWithInput(mChoice, inpArray);

            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(281, resultSum);
        }

    }
}

using System;
using Xunit;
using ConsolecalcER;

namespace ConsolecalcER.Tests
{ 
    public class ProgramTests
    {

        


        [Fact]
        public void TestMyMathMethodPlus()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 1; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            int userTal1 = 25; // First value   // changed double to int to get dividbyzero xunit testing
            int userTal2 = 7; // Second Value
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
        public void TestMyMathMethodPlusWithNegative()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 1; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            int userTal1 = 25; // First value   // changed double to int to get dividbyzero xunit testing
            int userTal2 = -7; // Second Value
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
            Assert.Equal(18, resultSum);
        }

        [Fact]
        public void TestMyMathMethodMinus()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 2; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            int userTal1 = 25; // First value   // changed double to int to get dividbyzero xunit testing
            int userTal2 = 7; // Second Value
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
            Assert.Equal(18, resultSum);
        }

        [Fact]
        public void TestMyMathMethodMinusWithMinus()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 2; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            int userTal1 = 25; // First value   // changed double to int to get dividbyzero xunit testing
            int userTal2 = -7; // Second Value
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
        public void TestDivideByZero()
        {
            //Arrange
            int mChoice = 3; //3 is division
            int userTal1 = 200; // changed double to int to get dividbyzero xunit testing
            int userTal2 = 0;
            //Program testMathDivide = null;
            //testMathDivide = new Program();

            //Act
            //Assert.Throws<DivideByZeroException>(() =>
            //{


            int resultSum = Program.DoMathWithInput(mChoice, userTal1, userTal2);
            //testMathDivide(4);

            // DoMathWithInput
            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(0, resultSum);
            //});
        }

        [Fact]
        public void TestDivision()
        {
            //Arrange
            int mChoice = 3; //3 is division
            int userTal1 = 200; // changed double to int to get dividbyzero xunit testing
            int userTal2 = 3;
            //Program testMathDivide = null;
            //testMathDivide = new Program();

            //Act
            //Assert.Throws<DivideByZeroException>(() =>
            //{


            int resultSum = Program.DoMathWithInput(mChoice, userTal1, userTal2);
            //testMathDivide(4);

            // DoMathWithInput
            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(66, resultSum);
            //});
        }




        [Fact]
        public void TestMyMathMethodMultiplication()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 4; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            int userTal1 = 25; // First value   // changed double to int to get dividbyzero xunit testing
            int userTal2 = 7; // Second Value
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
            Assert.Equal(175, resultSum);
        }


        [Fact]
        public void TestMyMathMethodMultiplicationWithMinus()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 4; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            int userTal1 = 25; // First value   // changed double to int to get dividbyzero xunit testing
            int userTal2 = -7; // Second Value
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
            Assert.Equal(-175, resultSum);
        }



        // ------------- InputArray testing below

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
        public void TestPlusArrInputWithMinus()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 1; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            double[] inpArray = new double[] { -5, 78, -98, 78 };

            //Act
            //testMathWays = new Program();

            double resultSum = Program.DoMathWithInput(mChoice, inpArray);

            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(53, resultSum);
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


        }[Fact]
        public void TestMinusArrInputWithMinus()
        {
            //Arrange

            // change below values to test the different math
            int mChoice = 2; // 1 is Addition, 2 Subtraction, 3 Division, 4 Multiplication
            double[] inpArray = new double[] { -535, 78, 98, -78 };

            //Act
            //testMathWays = new Program();

            double resultSum = Program.DoMathWithInput(mChoice, inpArray);

            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(-633, resultSum);
        }

    }
}

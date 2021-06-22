using System;
using Xunit;
using ConsolecalcER;

namespace ConsolecalcER.Tests
{ 
    public class ProgramTests
    {

        [Fact]
        public void Construct()
        {
            //Arrange
            int mChoice = 3;
            double Program.userTal1 = 200;
            double userTal2 = 0;
            Program testMathDivide = null;

            //Act
            testMathDivide = new Program();


            Program.DoMathWithInput(mChoice);
            testMathDivide(4);

            // DoMathWithInput
            //Assert
            //Assert.Equal("Model cant be empty.", result.Message);
            //Assert.Equal(intSum, testMathDivide.intSum);
            Assert.Equal(userTal1, testMathDivide.userTal2);

        }

        //public void TestMyMathMethod(int mChoice)
        //{


        //}

 

        
    }
}

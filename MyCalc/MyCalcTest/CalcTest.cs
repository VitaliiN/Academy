using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using MyCalc;
using Moq;



namespace MyCalcTest
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void Should_Return7_WhenAdding3to4()
        {
            //arrange
            var calc = new Calc();
            var outer = new Mock<IOut>();
            calc.Out = outer.Object;
            
            //act 
            calc.Add(3, 4);

            //assert
            Assert.That(calc.Result,Is.EqualTo("7"));

        }

    [Test]
    public void Should_Return2_WhenSubstract5And3()
    {
        //arrange
        var calc = new Calc();
        var outer = new Mock<IOut>();
        calc.Out = outer.Object;

        //act
        calc.Substract(5, 3);

        //assert
        Assert.That(calc.Result,Is.EqualTo("2"));
    }
        [Test]
        public void Should_Return15_WhenMultiply3And5()
        {
            //arrange
            var calc = new Calc();
            var outer = new Mock<IOut>();
            calc.Out = outer.Object;

            //act
            calc.Multiply(3, 5);

            //assert
            Assert.That(calc.Result, Is.EqualTo("15"));
            
        }

        [Test]
        public void Should_Return4_WhenDivide12And3()
        {
            //arrange
            var calc = new Calc();
            var outer = new Mock<IOut>();
            calc.Out = outer.Object;

            //act
            calc.Divide(12, 3);

            //assert
            Assert.That(calc.Result, Is.EqualTo("4"));

        }
        [Test]
        public void Should_ReturnNaN_WhenDivide12And0()
        {
            //arrange
            var calc = new Calc();
            var outer = new Mock<IOut>();
            calc.Out = outer.Object;

            //act
            calc.Divide(12, 0);

            //assert
            Assert.That(calc.Result, Is.EqualTo(float.PositiveInfinity.ToString()));

        }
        
    }
}

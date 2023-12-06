using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Tests
{
    [TestClass()]
    public class MatheTests
    {
        [TestMethod()]
        public void SummierenTest()
        {
            ///AAA
            //Arrange
            int ersteZahl = 5;
            int zweiteZahl = 10;
            int expected = 15;

            //Act
            int actual = Mathe.Summieren(ersteZahl, zweiteZahl);
           
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SummierenTest2()
        {
            ///AAA
            //Arrange
            int ersteZahl = 5;
            int zweiteZahl = -10;
            int expected = -5;

            //Act
            int actual = Mathe.Summieren(ersteZahl, zweiteZahl);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtrahierenTest()
        {
            ///AAA
            //Arrange
            int ersteZahl = 5;
            int zweiteZahl = 10;
            int expected = -5;
           
            //Act
            int actual = Mathe.Subtrahieren(ersteZahl, zweiteZahl);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplizierenTest()
        {
            ///AAA
            //Arrange
            int ersteZahl = 5;
            int zweiteZahl = 10;
            int expected = 50;

            //Act
            int actual = Mathe.Multiplizieren(ersteZahl, zweiteZahl);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DividierenTest()
        {
            ///AAA
            //Arrange
            int ersteZahl = 10;
            int zweiteZahl = 5;
            int expected = 2;

            //Act
            int actual = Mathe.Dividieren(ersteZahl, zweiteZahl);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DividierenDurchNull()
        {
            ///AAA
            //Arrange
            int ersteZahl = 10;
            int zweiteZahl = 0;

            Assert.ThrowsException<ArgumentException>(
                () =>
                { Mathe.Dividieren(ersteZahl, zweiteZahl); }
                );            
        }
    }
}
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static IncreasingSequenceLibrary.IncreasingSequence;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace IncreasingSequenceLibraryTest
{
    [TestClass]
    public class IncreasingSequenceTest
    {
        [TestMethod]
        public void CheckSequence_132_ReturnedTrue()
        {
            //arrange
            int number = 132;
            bool expected = true;

            //act
            bool actual = CheckSequence(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckSequence_7_ReturnedTrue()
        {
            //arrange
            int number = 7;
            bool expected = false;

            //act
            bool actual = CheckSequence(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIncreasingSequenceDigits_1347_ReturnedTrue()
        {
            //arrange
            int number = 1347;
            bool expected = true;

            //act
            bool actual = CheckIncreasingSequenceDigits(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIncreasingSequenceDigits_1547_ReturnedFalse()
        {
            //arrange
            int number = 1547;
            bool expected = false;

            //act
            bool actual = CheckIncreasingSequenceDigits(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void CheckIncreasingSequenceDigits_Minus8_ValidationException()
        {
            //arrange
            int number = -8;
            bool expected = false;

            //act + assert
            CheckIncreasingSequenceDigits(number);
        }

        [TestMethod]
        public void CheckDescendingSequenceDigits_631_ReturnedTrue()
        {
            //arrange
            int number = 631;
            bool expected = true;

            //act
            bool actual = CheckDescendingSequenceDigits(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckDescendingSequenceDigits_857_ReturnedFalse()
        {
            //arrange
            int number = 857;
            bool expected = false;

            //act
            bool actual = CheckDescendingSequenceDigits(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void CheckDescendingSequenceDigits_4_ValidationException()
        {
            //arrange
            int number = 4;
            bool expected = false;

            //act + assert
            CheckDescendingSequenceDigits(number);
        }
    }
}
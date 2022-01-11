using Microsoft.VisualStudio.TestTools.UnitTesting;
using HabitTracker;

namespace HabitTrackerTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void WhenQuantityInputIsCorrect()
        {
            bool expectedResult = true;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("4");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenQuantityInputIsNegative()
        {
            bool expectedResult = false;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("-4");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenQuantityInputIsEmpty()
        {
            bool expectedResult = false;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenQuantityInputIsNotNumeric()
        {
            bool expectedResult = false;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("blah");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenQuantityInputIsZero()
        {
            bool expectedResult = true;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("0");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenQuantityInputIsDecimal()
        {
            bool expectedResult = true;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("4.5");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenQuantityInputIsCrazyNumber()
        {
            bool expectedResult = false;

            HabitTrackerService habitTrackerService = new();

            bool result = habitTrackerService.ValidateQuantityInput("493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432493848934394894342342342342342342342342332423423423423423423423423423423423423432");

            Assert.AreEqual(expectedResult, result);
        }
    }
}
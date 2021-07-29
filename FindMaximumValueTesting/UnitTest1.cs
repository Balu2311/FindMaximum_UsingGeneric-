using FindMaximumValue_UsingGeneric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumValueTesting
{
    [TestClass]
    public class UnitTest1
    {
        // Givens the maximum number first position.     
        [TestMethod]
        public void GivenMaxNumber_FirstPosition()
        {
            int result = MaximumNumberCheck.MaximumIntegerNumber(40, 20, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        // Givens the maximum number second position.
        [TestMethod]
        public void GivenMaxNumber_SecondPosition()
        {
            int result = MaximumNumberCheck.MaximumIntegerNumber(10, 40, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        // Givens the maximum number third position.
        [TestMethod]
        public void GivenMaxNumber_ThirdPosition()
        {
            int result = MaximumNumberCheck.MaximumIntegerNumber(10, 20, 40);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

        // Given the maximum float number first position.
        [TestMethod]
        public void GivenMaxFloatNumber_FirstPosition()
        {
            double result = MaximumNumberCheck.MaximumFloatNumber(55.5, 20.2, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
        // Given the maximum float number second position.
        public void GivenMaxFloatNumber_SecondPosition()
        {
            double result = MaximumNumberCheck.MaximumFloatNumber(20.2, 55.5, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
        // Given the maximum float number third position.
        public void GivenMaxFloatNumber_ThirdPosition()
        {
            double result = MaximumNumberCheck.MaximumFloatNumber(20.2, 33.3, 55.5);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
    }
}

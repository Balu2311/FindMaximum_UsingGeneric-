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
            int result = MaximumNumberCheck.findMaximum(40, 20, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        // Givens the maximum number second position.
        [TestMethod]
        public void GivenMaxNumber_SecondPosition()
        {
            int result = MaximumNumberCheck.findMaximum(10, 40, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        // Givens the maximum number third position.
        [TestMethod]
        public void GivenMaxNumber_ThirdPosition()
        {
            int result = MaximumNumberCheck.findMaximum(10, 20, 40);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }

        // Given the maximum float number first position.
        [TestMethod]
        public void GivenMaxFloatNumber_FirstPosition()
        {
            double result = MaximumNumberCheck.findMaximum(55.5, 20.2, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
        // Given the maximum float number second position.
        public void GivenMaxFloatNumber_SecondPosition()
        {
            double result = MaximumNumberCheck.findMaximum(20.2, 55.5, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
        // Given the maximum float number third position.
        public void GivenMaxFloatNumber_ThirdPosition()
        {
            double result = MaximumNumberCheck.findMaximum(20.2, 33.3, 55.5);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }

        // Given the maximum string first position.
        public void GivenMaxString_FirstPosition()
        {
            string result = MaximumNumberCheck.findMaximum("Peach", "Apple", "Banana");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }
        // Given the maximum string second position.
        public void GivenMaxString_SecondPosition()
        {
            string result = MaximumNumberCheck.findMaximum("Apple", "Peach", "Banana");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }
        // Given the maximum string third position.
        public void GivenMaxString_ThirdPosition()
        {
            string result = MaximumNumberCheck.findMaximum("Apple", "Banana", "Peach");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }
    }
}

using FindMaximumValue_UsingGeneric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumValueTesting
{
    [TestClass]
    public class UnitTest2
    {
        // Givens the maximum number first position.  
        [TestMethod]
        public void GivenMaxNumber_FirstPosition()
        {
            int result = GenricMaximum<int>.testMaximum(40, 20, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        // Givens the maximum number second position.
        [TestMethod]
        public void GivenMaxNumber_SecondPosition()
        {
            int result = GenricMaximum<int>.testMaximum(10, 40, 30);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        // Givens the maximum number third position.
        [TestMethod]
        public void GivenMaxNumber_ThirdPosition()
        {
            int result = GenricMaximum<int>.testMaximum(10, 20, 40);
            int maxNumber = 40;
            Assert.AreEqual(maxNumber, result);
        }
        
        // Given the maximum float number first position.
        [TestMethod]
        public void GivenMaxFloatNumber_FirstPosition()
        {
            double result = GenricMaximum<double>.testMaximum(55.5, 20.2, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
        // Given the maximum float number second position.
        public void GivenMaxFloatNumber_SecondPosition()
        {
            double result = GenricMaximum<double>.testMaximum(20.2, 55.5, 33.3);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }
        // Given the maximum float number third position.
        public void GivenMaxFloatNumber_ThirdPosition()
        {
            double result = GenricMaximum<double>.testMaximum(20.2, 33.3, 55.5);
            double maxNumber = 55.5;
            Assert.AreEqual(maxNumber, result);
        }

        // Given the maximum string first position.
        public void GivenMaxString_FirstPosition()
        {
            string result = GenricMaximum<string>.testMaximum("Peach", "Apple", "Banana");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }
        // Given the maximum string second position.
        public void GivenMaxString_SecondPosition()
        {
            string result = GenricMaximum<string>.testMaximum("Apple", "Peach", "Banana");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }
        /// Given the maximum string third position.
        public void GivenMaxString_ThirdPosition()
        {
            string result = GenricMaximum<string>.testMaximum("Apple", "Banana", "Peach");
            string maxString = "Peach";
            Assert.AreEqual(maxString, result);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_MainInTheWest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_false()
        {
            //arrange
            var input = new string[] { string.Empty };
            var kata = new Kata();
            //actual
            var bucketHasGold = kata.CheckTheBucket(input);
            //assert
            Assert.AreEqual(false,bucketHasGold);
        }

        [TestMethod]
        public void Input_1gold_Should_Be_true()
        {
            var input = new string[] { "gold" };
            var kata = new Kata();
            var bucketHasGold = kata.CheckTheBucket(input);
            Assert.AreEqual(true, bucketHasGold);
        }
    }
}

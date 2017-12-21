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
    }
}

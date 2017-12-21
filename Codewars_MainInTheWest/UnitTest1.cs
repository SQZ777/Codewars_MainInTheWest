using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_MainInTheWest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_false()
        {
            Assert.AreEqual(false,new Kata().CheckTheBucket(new string[] { string.Empty }));
        }

        [TestMethod]
        public void Input_1gold_Should_Be_true()
        {
            Assert.AreEqual(true, new Kata().CheckTheBucket(new string[] { "gold" }));
        }
    }
}

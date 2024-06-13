using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwapVariablesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSwapValues()
        {
            int a = 20;
            int b = 50;
            (a, b) = (b, a);
            Assert.AreEqual(a, 50);
            Assert.AreEqual(b, 20);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace shirtSalesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateShirtSales()
        {
            string clientName = "Jane Doe";
            int quantity = 15;

            int pricePerShirt = quantity < 12 ? 1083 : 1000;
            int totalPrice = quantity * pricePerShirt;

            Assert.AreEqual(pricePerShirt, 1000);
            Assert.AreEqual(totalPrice, 15000);
        }
    }
}

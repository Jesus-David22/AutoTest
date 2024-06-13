using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace salespersonSalaryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateSalary()
        {
            string name = "John Doe";
            int itemsSold = 20;
            double totalSales = 2800.00;
            double fixedSalary = 1200.00;
            double commissionPerItem = 70.00;
            
            double commission = itemsSold * commissionPerItem;
            double finalSalary = fixedSalary + commission + (totalSales * 0.05);

            Assert.AreEqual(commission, 1400.00);
            Assert.AreEqual(finalSalary, 4400.00);
        }
    }
}

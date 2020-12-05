using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Tests
{
  [TestClass()]
  [TestCategory("Slow")]
  public class SalesOrderManagerTests
  {
    [TestMethod()]
    public void GetLatestSalesOrderHeaderByCustomerIDTest()
    {
      System.Threading.Thread.Sleep(1000);
    }

    [TestMethod()]
    public void UpdateCreditCardInfoTest()
    {
      // Assert.Inconclusive("Not implemented yet");
    }

    [TestMethod()]
    public void UpdateShippingInfoTest()
    {
      System.Threading.Thread.Sleep(1000);
    }

    [TestMethod()]
    public void AddToSalesOrderTest()
    {
      System.Threading.Thread.Sleep(1000);
    }
  }
}
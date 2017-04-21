using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.Tests
{
  [TestClass()]
  public class AddressManagerTests
  {
    [TestMethod()]
    public void GetAddressTest()
    {

    }

    [TestMethod()]
    public void GetFirstAddressTest()
    {

    }

    [TestMethod()]
    public void GetStateProvinceFromCodeTest()
    {

    }

    [TestMethod()]
    public void GetBillAddressByCustomerIDTest()
    {

    }

    [TestMethod()]
    public void GetAddressByIDTest()
    {

    }

    [TestMethod()]
    public void SaveChangesTest()
    {

    }

    [TestMethod()]
    public void CloneAddressManagerTest()
    {
      System.Threading.Thread.Sleep(1000);

      AdventureWorksDataModel.Address desAddress;
      desAddress = AdventureWorksDataModel.Address.CreateAddress(42, "1 Microsoft Way", "Redmond", "98052", System.Guid.NewGuid(), System.DateTime.Now);
      AdventureWorksDataModel.Address tarAddress = new AdventureWorksDataModel.Address();
      AdventureWorksDataModel.Entities entities = new AdventureWorksDataModel.Entities();
      try
      {
        EpicAdventureWorks.AddressManager.Clone(desAddress, tarAddress, entities);
      }
      catch (System.Exception) {}
    }

    [TestMethod()]
    public void AddToAddressTest()
    {

    }
  }
}

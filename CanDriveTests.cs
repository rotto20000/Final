
[TestClass]
public class CanDriveTests
{
    [TestMethod]
    public void Method1()
    {
        Assert.IsFalse(CanDriveHelper.canDrive(0));
    }

    [TestMethod]
    public void Method2()
    {
        Assert.IsFalse(CanDriveHelper.canDrive(15));
    }

    [TestMethod]
    public void Method3()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(16));
    }

    [TestMethod]
    public void Method4()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(17));
    }

    [TestMethod]
    public void Method5()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(100));
    }
}

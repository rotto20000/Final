
[TestClass]
public class CanDriveTests
{

    [TestMethod]
    public void Method1()
    {
        Assert.IsFalse(CanDriveHelper.canDrive(-1));
    }

    [TestMethod]
    public void Method2()
    {
        Assert.IsFalse(CanDriveHelper.canDrive(0));
    }

    [TestMethod]
    public void Method3()
    {
        Assert.IsFalse(CanDriveHelper.canDrive(1));
    }

    [TestMethod]
    public void Method4()
    {
        Assert.IsFalse(CanDriveHelper.canDrive(15));
    }

    [TestMethod]
    public void Method5()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(16));
    }

    [TestMethod]
    public void Method6()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(17));
    }

    [TestMethod]
    public void Method7()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(99));
    }

    [TestMethod]
    public void Method8()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(100));
    }

    [TestMethod]
    public void Method9()
    {
        Assert.IsTrue(CanDriveHelper.canDrive(101));
    }
}

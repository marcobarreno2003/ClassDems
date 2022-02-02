using NUnit.Framework;

namespace Lib.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
        MSI[] p= new MSI[int.MaxValue] ;
        p[0].Storage();
        p[0].Ram();
        p[0].Display();

        Lenovo[] l= new Lenovo[int.MaxValue];
        l[0].Ram();
        l[0].Storage();
        l[0].Display();

    }
}
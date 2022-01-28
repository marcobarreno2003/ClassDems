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
    }
    [Test]
    public void TestEmptyList()
    {
        StringArrayList list = new StringArrayList(5);
        Assert.AreEqual(0, list.GetLength());
        Assert.AreEqual(5, list.GetCapacity());
    }
    [Test]
    public void TestAddingOneItem()
    {
        StringArrayList list = new StringArrayList();
        list.Append("Item 1");
        Assert.AreEqual(1, list.GetLength());
        

    }

}
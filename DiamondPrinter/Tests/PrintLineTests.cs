using NUnit.Framework;

namespace DiamondPrinter.Tests;

public class PrintLineTests
{

    [Test]
    public void PrintLine_in_A_diamond()
    {
        Assert.AreEqual("A", Printer.PrintLine('A', 'A'));
    }

    [Test]
    public void PrintLine_in_B_diamond()
    {
        Assert.AreEqual(" A ", Printer.PrintLine('B', 'A'));
        Assert.AreEqual("B B", Printer.PrintLine('B', 'B'));
    }

    [Test]
    public void PrintLine_in_C_diamond()
    {
        Assert.AreEqual("  A  ", Printer.PrintLine('C', 'A'));
        Assert.AreEqual(" B B ", Printer.PrintLine('C', 'B'));
        Assert.AreEqual("C   C", Printer.PrintLine('C', 'C'));
    }


    [Test]
    public void Given_A_Then_Print_A()
    {
        var expected = "A";
        Assert.AreEqual(expected, Printer.PrintDiamond('A'));
    }
}
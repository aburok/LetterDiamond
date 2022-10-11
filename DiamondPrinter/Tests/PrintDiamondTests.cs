using NUnit.Framework;

namespace DiamondPrinter.Tests;

public class PrintDiamondTests {

    [Test]
    public void Given_B_Then_Print_ABB()
    {
        var expected =
            " A \r\n" +
            "B B\r\n" +
            " A ";
        Assert.AreEqual(expected, Printer.PrintDiamond('B'));
    }

    [Test]
    public void Given_C_Then_Print_ABBCC()
    {
        var expected =
            "  A  \r\n" +
            " B B \r\n" +
            "C   C\r\n" +
            " B B \r\n" +
            "  A  ";
        Assert.AreEqual(expected, Printer.PrintDiamond('C'));
    }

    [Test]
    public void Given_F_Then_Print_ABBCCDDEEFF()
    {
        var expected =
            "     A     \r\n" +
            "    B B    \r\n" +
            "   C   C   \r\n" +
            "  D     D  \r\n" +
            " E       E \r\n" +
            "F         F\r\n" +
            " E       E \r\n" +
            "  D     D  \r\n" +
            "   C   C   \r\n" +
            "    B B    \r\n" +
            "     A     ";

        Assert.AreEqual(expected, Printer.PrintDiamond('F'));
    }
}
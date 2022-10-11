using NUnit.Framework;

namespace DiamondPrinter;

public class Tests
{
    [Test]
    public void Given_A_Then_Print_A()
    {
        var expected = "A";
        Assert.AreEqual(expected, Printer.PrintDiamond('A'));
    }

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

    [Test]
    public void GetLetterPositions_in_A_diamond()
    {
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('A', 'A', 0));
    }

    [Test]
    public void GetLetterPositions_in_B_diamond_Then_3()
    {
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('A', 'B', 0));
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('A', 'B', 1));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('A', 'B', 2));

        Assert.IsTrue(Printer.ShouldLetterBeInColumn('B', 'B', 0));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('B', 'B', 1));
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('B', 'B', 2));
    }

    [Test]
    public void GetLetterPositions_in_C_diamond_Then_3()
    {
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('A', 'C', 0));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('A', 'C', 1));
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('A', 'C', 2));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('A', 'C', 3));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('A', 'C', 4));

        Assert.IsFalse(Printer.ShouldLetterBeInColumn('B', 'C', 0));
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('B', 'C', 1));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('B', 'C', 2));
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('B', 'C', 3));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('B', 'C', 4));

        Assert.IsTrue(Printer.ShouldLetterBeInColumn('C', 'C', 0));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('C', 'C', 1));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('C', 'C', 2));
        Assert.IsFalse(Printer.ShouldLetterBeInColumn('C', 'C', 3));
        Assert.IsTrue(Printer.ShouldLetterBeInColumn('C', 'C', 4));
    }
}
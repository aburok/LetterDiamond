using NUnit.Framework;

namespace DiamondPrinter.Tests;

public class LetterPositionTests
{
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
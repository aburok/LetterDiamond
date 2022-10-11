using System.Text;

namespace DiamondPrinter;

public static class Printer
{
    private static readonly string EmptySpace = " ";
    public static string PrintDiamond(char mainLetter)
    {
        var lines = GetTopHalfOfDiamond(mainLetter);

        var linesToMirror = lines.Take(lines.Count - 1);
        var mirroredLines = linesToMirror.Reverse();
        lines.AddRange(mirroredLines);

        return string.Join(Environment.NewLine, lines);
    }

    private static List<string> GetTopHalfOfDiamond(char mainLetter)
    {
        var lines = new List<string>();

        for (var letter = 'A'; letter <= mainLetter; letter++)
        {
            lines.Add(PrintLine(mainLetter, letter));
        }

        return lines;
    }

    public static string PrintLine(char mainLetter, char letter)
    {
        var distanceFromA = (mainLetter - 'A');
        var diamondWidth = distanceFromA * 2 + 1;
        
        var lineBuilder = new StringBuilder();
        for (var column = 0; column < diamondWidth; column++)
        {
            var character = ShouldLetterBeInColumn(letter, mainLetter, column) ? $"{letter}" : EmptySpace; 
            lineBuilder.Append(character);
        }

        return lineBuilder.ToString();
    }

    public static bool ShouldLetterBeInColumn(char letter, char mainLetter, int column)
    {
        var mainLetterDistanceFromA = mainLetter - 'A';
        var letterDistanceFromA = letter - 'A';
        var distanceFromLeftBorder = mainLetterDistanceFromA - letterDistanceFromA;
        var width = mainLetterDistanceFromA * 2 + 1;
        var distanceFromRightBorder = width - 1 - distanceFromLeftBorder;
        return column == distanceFromLeftBorder || column == distanceFromRightBorder;
    }
}
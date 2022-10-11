// See https://aka.ms/new-console-template for more information

using DiamondPrinter;

string name = Environment.GetCommandLineArgs()[1];
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Please provide a letter from A-Z.");
    return;
}

var letter = name.First();
if (letter < 'A' || letter > 'Z')
{
    Console.WriteLine("Please provide a letter from A-Z.");
    return;
}

var diamond = Printer.PrintDiamond(letter);
Console.WriteLine($"Diamond from letter '{letter}'.");
Console.WriteLine(diamond);

Console.WriteLine("Press Enter to finish.");
Console.ReadLine();
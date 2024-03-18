namespace ExtensionMethodsDemoPrep2024;

class Program
{
    static void Main(string[] args)
    {

        var square1 = new Square(3);
        var square2 = new Square(4);
        var square3 = new Square(5);
        var square4 = square1.Add(square2.Add(square3));
        Console.WriteLine(square4.Side);

        int x = 5;
        Console.WriteLine(x.Square());

        var square = new Square(5);
        square.Display();
        square.Display(true);

        var range = Enumerable.Range(0, 10)
            .Where(x => x % 2 == 0)
            .Reverse();

        range.ToList().ForEach(item => Console.Write(item));

        var range2 = range.Select(s => new { Original = s, Squared = s.Square() });
        range2.ToList().ForEach(item => Console.WriteLine($"Original: {item.Original}; Squared: {item.Squared}"));
    }
}


int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };

var pairs = from a in numbersA
            from b in numbersB
                // where a < b
            select (a, b);



Console.WriteLine("PAIRS WHERE A < B");
foreach (var pair in pairs)
{
    Console.WriteLine($"{pair.a} is less than {pair.b}");
}

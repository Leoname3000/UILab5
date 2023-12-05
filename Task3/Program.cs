namespace Task3;
internal class Program
{
	private static void Main(string[] args)
	{
		var triangle = new TriangleColor("Треугольник", 3, 4, 5, ConsoleColor.Red);

		((Figure)triangle).Print();
		Console.WriteLine();

		((Triangle)triangle).Print();
		Console.WriteLine();

		triangle.Print();
		Console.WriteLine();

		Console.WriteLine($"Area: {triangle.Area2}");
	}
}
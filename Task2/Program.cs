namespace Task2;
internal class Program
{
	private static void Main(string[] args)
	{
		var book = new BookGenrePubl("1985", "Стивен Кинг", 599, "Комедия", "СПб пресс");

		((Book)book).Print();
		Console.WriteLine();

		((BookGenre)book).Print();
		Console.WriteLine();

		book.Print();
		Console.WriteLine();
	}
}
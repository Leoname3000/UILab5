using System;
namespace Task2
{
	public class BookGenre : Book
	{
		string Genre { get; set; }

		public BookGenre(string name, string author, int price, string genre) : base(name, author, price)
		{
			Genre = genre;
		}

		public new void Print()
		{
			base.Print();
			Console.WriteLine($"жанр {Genre}");
		}
	}
}


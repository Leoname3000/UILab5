using System;
namespace Task2
{
	public class Book
	{
		public string Name { get; private set; }
		public string Author { get; private set; }
		public int Price { get; private set; }

		public Book(string name, string author, int price)
		{
			Name = name;
			Author = author;
			Price = price;
		}

		public void Print()
		{
			Console.WriteLine($"Книга {Name}:");
			Console.WriteLine($"автор {Author}");
			Console.WriteLine($"цена {Price} рублей");
		}
	}
}


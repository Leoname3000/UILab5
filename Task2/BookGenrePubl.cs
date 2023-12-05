using System;
namespace Task2
{
	public sealed class BookGenrePubl : BookGenre
	{
		string Publ { get; set; }

		public BookGenrePubl(string name, string author, int price, string genre, string publ) : base(name, author, price, genre)
		{
			Publ = publ;
		}

		public new void Print()
		{
			base.Print();
			Console.WriteLine($"издатель {Publ}");
		}
	}
}


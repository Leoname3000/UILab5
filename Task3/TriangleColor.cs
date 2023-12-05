using System;
namespace Task3
{
	public class TriangleColor : Triangle
	{
		ConsoleColor color;
		public ConsoleColor Color
		{
			get { return color; }
		}

		public TriangleColor(string name, double a, double b, double c, ConsoleColor color) : base(name, a, b, c)
		{
			this.color = color;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Color: {Color}");
		}
	}
}


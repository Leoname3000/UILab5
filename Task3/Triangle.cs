using System;
namespace Task3
{
	public class Triangle : Figure
	{
		double a, b, c;

		public Triangle(string name, double a, double b, double c) : base(name)
		{
			SetABC(a, b, c);
		}

		public void GetABC(out double a, out double b, out double c)
		{
			(a, b, c) = (this.a, this.b, this.c);
		}

		public void SetABC(in double a, in double b, in double c)
		{
			(this.a, this.b, this.c) = (a, b, c);
		}

		public override double Area2
		{
			get
			{
				double p = (a + b + c) / 2;
				double mult = p * (p - a) * (p - b) * (p - c);
				return Math.Sqrt(mult);
			}
		}

		public override double Area()
		{
			return Area2;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"a = {a}, b = {b}, c = {c}");
		}
	}
}


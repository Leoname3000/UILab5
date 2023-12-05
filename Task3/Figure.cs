using System;
namespace Task3
{
	public abstract class Figure
	{
		string name;
		public string Name
		{
			get { return name; }
		}

		public Figure(string name)
		{
			this.name = name;
		}

		public abstract double Area2 { get; }
		public abstract double Area();

		public virtual void Print()
		{
			Console.WriteLine($"Name: {Name}");
		}
	}
}


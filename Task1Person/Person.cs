using System;
namespace Task1Person
{
	public class Person
	{
		public string Name { get; private set; }
		public string Surname { get; private set; }

		static List<Person> allPersons = new List<Person>();

		public Person(string name, string surname)
		{
			Name = name;
			Surname = surname;

			allPersons.Add(this);
		}

		~Person()
		{
			allPersons.Remove(this);
		}

		public static List<Person> getAll()
		{
			return allPersons;
		}

		public static Person RandomPerson()
		{
			Random random = new Random();
			int index = random.Next(0, allPersons.Count);
			return allPersons[index];
		}

		public virtual void Print()
		{
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			return $"{Name} {Surname}";
		}

		public override bool Equals(object? obj)
		{
			if (obj == null) return false;
			if (obj.GetType() != GetType()) return false;
			var other = (Person)obj;
			return other.Name == Name && other.Surname == Surname;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Name, Surname);
		}

		public virtual Person Clone()
		{
			return new Person(Name, Surname);
		}
	}
}


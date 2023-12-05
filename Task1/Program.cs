using Task1Person;
using Task1Teacher;
using Task1Student;
using Task1StudentWithAdvisor;

internal class Program
{
	private static void Main(string[] args)
	{
		Teacher teacher = new Teacher("Михал", "Саныч");
		var s1 = new StudentWithAdvisor("Ваня", "Иванов", 1, teacher);
		var s2 = new StudentWithAdvisor("Аня", "Иванова", 2, teacher);
		var s3 = new StudentWithAdvisor("Даня", "Диванов", 3, teacher);
		var s4 = new StudentWithAdvisor("Вася", "Ивасов", 4, teacher);
		teacher.Students.Add(s1);
		teacher.Students.Add(s2);
		teacher.Students.Add(s3);
		teacher.Students.Add(s4);

		foreach (var p in Person.getAll())
			p.Print();

		Console.WriteLine("\nСледующий курс:");
		foreach (var p in Person.getAll())
		{
			if (p is Student)
				((Student)p).Year += 1;
			p.Print();
		}

		Console.WriteLine("\nСлучайный человек:");
		Person.RandomPerson().Print();

		Console.WriteLine("\nClone Equals:");
		var clone = Person.getAll()[2].Clone();
		if (clone.Equals(Person.getAll()[2]))
		{
			clone.Print();
		}
	}
}
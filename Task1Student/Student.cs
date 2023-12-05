using System;
using Task1Person;
namespace Task1Student
{
	public class Student : Person
	{
		int year;
		public int Year {
			get
			{
				return year;
			}
			set
			{
				if (value < 1)
					year = 1;
				else if (value > 6)
					year = 6;
				else
					year = value;
			}
		}

		static List<Student> allStudents = new List<Student>();

		public Student(string name, string surname, int year) : base(name, surname)
		{
			Year = year;
			allStudents.Add(this);
		}

		~Student()
		{
			allStudents.Remove(this);
		}

		public static Student RandomStudent()
		{
			Random random = new Random();
			int index = random.Next(0, allStudents.Count);
			return allStudents[index];
		}

		public override string ToString()
		{
			return base.ToString() + $", курс: {Year}";
		}

		public override Student Clone()
		{
			return new Student(Name, Surname, Year);
		}
	}
}


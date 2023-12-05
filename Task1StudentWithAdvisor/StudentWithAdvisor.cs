using System;
using Task1Student;
using Task1Teacher;
namespace Task1StudentWithAdvisor
{
	public class StudentWithAdvisor : Student
	{
		public Teacher Advisor { get; private set; }

		public StudentWithAdvisor(string name, string surname, int year, Teacher advisor) : base(name, surname, year)
		{
			advisor.Students.Add(this);
			Advisor = advisor;
		}

		~StudentWithAdvisor()
		{
			Advisor.Students.Remove(this);
		}

		public override string ToString()
		{
			return base.ToString() + $", учитель: {Advisor}";
		}

		public override StudentWithAdvisor Clone()
		{
			var clone = new StudentWithAdvisor(Name, Surname, Year, Advisor);
			Advisor.Students.Add(clone);
			return clone;
		}
	}
}


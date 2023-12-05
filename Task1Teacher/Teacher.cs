using System;
using Task1Person;
using Task1Student;
namespace Task1Teacher
{
	public class Teacher : Person
	{
		static List<Teacher> allTeachers = new List<Teacher>();
		public List<Student> Students { get; private set; }

		public Teacher(string name, string surname) : base(name, surname)
		{
			Students = new List<Student>();
			allTeachers.Add(this);
		}

		~Teacher()
		{
			allTeachers.Remove(this);
		}

		public static Teacher RandomTeacher()
		{
			Random random = new Random();
			int index = random.Next(0, allTeachers.Count);
			return allTeachers[index];
		}

		public override Teacher Clone()
		{
			var newStudents = new List<Student>();
			foreach (var s in Students)
				newStudents.Add(s);

			var clone = new Teacher(Name, Surname);
			clone.Students = newStudents;
			return clone;
		}
	}
}


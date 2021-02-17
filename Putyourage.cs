using System;

namespace Putyourage
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Put your age");
			int age = int.Parse(Console.ReadLine());

			if (age >= 0 && age <= 10)
			{

				Console.WriteLine("you are a child!");
			}
			else if (age >= 12 && age <= 19)
			{
				Console.WriteLine("You are an adolescent!");
			}
			else if (age >= 19 && age <= 70)
			{

				Console.WriteLine("You are an adult!");
			}
			else
			{
				Console.WriteLine("You are elder!");
			}

			Console.ReadLine();
		}
	}
}
























		
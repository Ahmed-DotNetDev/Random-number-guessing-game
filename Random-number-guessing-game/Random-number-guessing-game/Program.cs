using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_number_guessing_game
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int RandomNumber = random.Next(1, 10);
			int GuessNumber = 0;
			while (GuessNumber != RandomNumber)
			{
				Console.WriteLine("I am thinking of a number between 1 →→ 100.  Can you guess what it it: ? ");
				
				while (GuessNumber < RandomNumber)
				{
					GuessNumber = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Increase your value ++++");

				}

				while (GuessNumber > RandomNumber)
				{
					GuessNumber = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("decrease your value ----");

				}
			}
			while (GuessNumber == RandomNumber)
			{
				Console.WriteLine(" Done ✔ ");
				break;
			}
		}
	}
}

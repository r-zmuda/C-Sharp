using System;

namespace Chapter08Assignment02
{
    class Program
	{
		//Number of games of craps to play
		const int GAMES = 1000000;

		private enum Status { Continue, Win, Lose } //Game status
		private static Random rand = new Random(); //Random number generator
		private static int winCount, loseCount, rollCount, rollTotal; //Counters
		private static int[] winRound = new int[22]; //Track when round is won
		private static int[] loseRound = new int[22]; //Track when round is lost

		static void Main(string[] args)
		{	
			//Let the games begin
			for (int n = 0; n < GAMES; n++)
			{
				PlayCraps();
			}

			//Get win rate, average rolls
			double winRate = (winCount * 100.00) / GAMES;
			double average = (rollTotal * 1.00) / GAMES;

			//Display results
			Console.WriteLine("*** Many Games of Craps ***");
			Console.WriteLine($"Simulating {GAMES} games of Craps...");
			Console.WriteLine();
			Console.WriteLine($"Games Won: {winCount}");
			Console.WriteLine($"Games Lost: {loseCount}");
			Console.WriteLine($"Win Rate: {winRate:F2}%");
			Console.WriteLine($"Total Rolls: {rollTotal}");
			Console.WriteLine($"Average Game Length: {average:F2} rolls");
			Console.WriteLine();
			Console.WriteLine($"{"Roll#"}{"Won",10}{"Lost",10}");
			for (int n = 1; n < winRound.Length - 1; n++)
			{
				Console.WriteLine($"{n,2}{winRound[n],13}{loseRound[n],10}");
			}
			Console.WriteLine($"{"21+"}{winRound[21],12}{loseRound[21],10}");
			Console.WriteLine();
		}

		//Play a game of craps (no text output)
		static void PlayCraps()
		{
			Status gameStatus = Status.Continue;
			int myPoint = 0;
			int sumOfDice = RollDice();
			rollCount = 1;

			//Phase 1 (first roll)
			switch (sumOfDice)
			{
				//Win case
				case 7:
				case 11:
					gameStatus = Status.Win;
					break;
				//Lose case
				case 2:
				case 3:
				case 12:
					gameStatus = Status.Lose;
					break;
				//Else case
				default:
					gameStatus = Status.Continue;
					myPoint = sumOfDice;
					break;
			}

			//Phase 2 (subsequent rolls)
			while (gameStatus == Status.Continue)
			{
				sumOfDice = RollDice();

				//Match point, win case
				if (sumOfDice == myPoint)
				{
					gameStatus = Status.Win;
				}
				//Roll 7, lose case
				else if(sumOfDice == 7)
				{
					gameStatus = Status.Lose;
				}
			}

			//Display result, add to WL counter
			if (gameStatus == Status.Win)
			{
				winCount++;
				rollTotal += rollCount;
				if (rollCount <= 20)
				{
					winRound[rollCount]++;
				}
				else
				{
					winRound[21]++;
				}
			}
			else
			{
				loseCount++;
				rollTotal += rollCount;
				if (rollCount <= 20)
				{
					loseRound[rollCount]++;
				}
				else
				{
					loseRound[21]++;
				}
			}
		}

		//Roll 2 dice, calculate sum
		static int RollDice()
		{
			//Calculate sum
			int r1 = rand.Next(1, 7);
			int r2 = rand.Next(1, 7);
			int sum = r1 + r2;

			//Increment counter
			rollCount++;

			//Return sum
			return sum;
		}
	}
}

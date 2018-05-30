using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
	class Program {

		Random rand = new Random();

		int RollDie() {
			return rand.Next(1, 7);
		}

		void PlayPigDice() {
			int score = 0;
			int dienum = RollDie();
			int rollcount = 0;
			while (score < 501) {
				score = 0;
				dienum = RollDie();

				while (dienum != 1) {
					score += dienum;
					dienum = RollDie();
				}
				rollcount++;
				Console.WriteLine(rollcount + " " + score);
			}
		}

		void Run() {
			bool quit = false;
			while (!quit) {
				PlayPigDice();

				Console.WriteLine("Do you want to quit?");
				string answer = Console.ReadLine().ToUpper();
				if (answer.StartsWith("Y")) {
					quit = true;
				}
			}
		}
		/// <summary>
		/// Dice Game
		/// roll one die
		/// if the number is equal to 1, game over.
		/// otherwise, add roll to a total
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args) {

			(new Program()).Run();

		}
	}
}

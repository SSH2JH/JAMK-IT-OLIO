using System;
/// <summary>
/// A simple example of Blackjack card game
/// Alla olevassa esimerkissä käyttäjältä kysytään yksi luku väliltä 1-21. Luku tarkistetaan
/// että se on annetulla välillä. Jollei se ole niin käyttäjälle annetaan ilmoitusasiasta, ja ohjelman suoritus päättyy.
/// Tee ohjelmaan seuraavat muutokset: 1) Muuta ohjelmaa että käyttäjältä kysytään lukua niin kauan että se on annetulta väliltä
/// 2) Tee ohjelmaan muutos että käyttäjä voi pelata niin kauan kunnes hän antaa syötteeksi: X tai exit.
/// Jos käyttäjä antaa jonkin muun merkkijonon joka ei ole kokonaisluku käyttäjälle näytetään ohje sallituista syötteistä.
/// 3) Tee muutos että myös pöydän korttien arvo arvotaan väliltä 10-21. Näytä arvottu luku tuloksen yhteydessä.
/// </summary>
namespace JAMK.IT {
	class BlackJack {
		static void Main()
		{
			string userInput;
			int i = 1;
			while (i == 1) {
				Console.Write("\nWhich game do you wish to play (1) Lotto or (2) BlackJack (x) Exit >");
				userInput = Console.ReadLine();
				switch (userInput) {
					case "1":
						JAMK.IT.Lotto.LottoGame();
						break;
					case "2":
						BlackJackGame();
						break;
					case "x":
						i = 0;
						break;
					default:
						Console.WriteLine("Wrong input!");
						break;
				}
			}
		}
		static void BlackJackGame()
		{
			int myNumber;
			int theirNumber;
			string UserInput;
			bool isNumeric;
			Random rnd = new Random();
			myNumber = rnd.Next(10,21);
			while (true) {
				System.Console.WriteLine("*** BlackJack! ***");
				System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
				//reading and converting 
				UserInput = System.Console.ReadLine();
				//comparing that given umber is valid
				isNumeric = int.TryParse(UserInput, out theirNumber);
				if (isNumeric == true) {
					if (theirNumber < 1 || theirNumber > 21) {
						Console.WriteLine("The given number is out of limits, try again.");
					} else {
						//comparing
						if (theirNumber >= myNumber && theirNumber <= 21) {
							System.Console.WriteLine("You win.");
						} else {
							System.Console.WriteLine("You lose.");
						}
					}
				} else if (UserInput == "X" || UserInput == "exit" ) {
					break;
				} else {
					Console.Write("Your input was invalid!\n" +
								"Correct input options are:\n" +
								"\t1-21\n" +
								"\tX & exit for exiting the application\n");
				}
			}
		}
	}
}
/*
 * Tekijä: Juuso Huppunen
 * AsioID: K8960
 * Kurssi: TTOS0200
 * Kuvaus:
 *		Luo ohjelma, randomoi 7 uniikkia
 *		lukua 40:stä vaihtoehdosta.
 *		Anna käyttäjälle myös mahdollisuus
 *		valita kuinka monta lottoriviä arvotaan
 * Pvm: 10.1.2016 
 */

using System;
using System.Linq;

namespace JAMK.IT {
	public class Lotto {
		public static void LottoGame()
		{
			// Lottonumeroiden muuttujien luonti ja randomointigeneraattorin asetus
			const int a = 7;
			Random rnd = new Random();
			int[] Numbers = new int[40];
			int[] WinNumbers = new int[a];
			int tmp;

			// Kyselee käyttäjältä rivien määrän
			Console.Write("How many lotto lines you wish to print (enter a number) >");
			int b = int.Parse(Console.ReadLine());
			int c = 0;

			// Pääsilmukka joka suoriutuu haluttujen rivien määrän avulla
			while (c <= b) {
				// Aloittaa Numbers taulukon arvot
				for (int i = 0; i < Numbers.Length; i++) {
					Numbers[i] = i;
				}

				// Täällä hoituu randomointi
				for (int i = 0; i < a; i++) {
					tmp = rnd.Next(Numbers[39]); // Asettaa randomoitu luku tmp-muuttujaan
												 // Mikäli randomoitu liku toistuu voittonumerot taulukossa se randoidaan uudestaan
					if (WinNumbers.Contains(tmp)) {
						i--;
					}
					else {
						WinNumbers[i] = tmp; // Muussa tapauksessa se tallennetaan WinNumbers-taulukkoon
					}
				}
				// Asettaa luvut suuruusjärjestykseen
				Array.Sort(WinNumbers);

				// Tulostaa luvut
				Console.WriteLine("\n-----------------------------------------------");
				for (int i = 0; i < a; i++) {
					Console.Write(WinNumbers[i] + " ");
				}
				c++;
			}
		}
	}
}
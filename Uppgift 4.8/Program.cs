using System;

namespace Uppgift4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng:");
            string text = Console.ReadLine();
            Console.WriteLine("Skriv en sträng med exakt två tecken:");
            string text2 = Console.ReadLine();

            char tecken1 = text2[0];
            char tecken2 = text2[1];
            bool teckenhittade1 = false;
            bool teckenhittade2 = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == tecken1)
                {
                    teckenhittade1 = true;
                }
                if (text[i] == tecken2)
                {
                    teckenhittade2 = true;
                }
            }
            if (teckenhittade1 && teckenhittade2)
            {
                Console.WriteLine("Din text \"" + text + "\" innehåller " + text2);
            }
            else
            {
                Console.WriteLine("Din text \"" + text + "\" innehåller EJ " + text2);
            }
        }
    }
}
using System.ComponentModel.Design;

namespace krokkospill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poengsum = 0;
            Random random = new Random();

            while (true)
            {
                int tall1 = random.Next(1, 12);
                int tall2 = random.Next(1, 12);
                Console.WriteLine("< er mindre enn, > er større enn, = er det samme");

                Console.WriteLine($"{tall1} _ {tall2}");

                Console.WriteLine("Skriv inn <, > eller =: ");
                string brukerInput = Console.ReadLine();

                if (brukerInput == "<" && tall1 < tall2)
                {
                    Console.WriteLine("Riktig! Du fikk et poeng.");
                    poengsum++;
                }
                else if (brukerInput == ">" && tall1 < tall2)
                {
                    Console.WriteLine("Riktig! Du fikk et poeng.");
                    poengsum++;
                }
                else if (brukerInput == "=" && tall1 == tall2)
                {
                    Console.WriteLine("Riktig! Du fikk et poeng.");
                    poengsum++;
                }
                else
                {
                    Console.WriteLine("Feil! Du mister et poeng.");
                    poengsum--;
                }

                Console.WriteLine($"Din poengsum er: {poengsum}");
                Console.WriteLine("Trykk Enter for å fortsette eller skriv noe annet for å avslutte.");

                string fortsett = Console.ReadLine();
                if (!fortsett.Equals(""))
                {
                    break;
                }

                Console.Clear();
            }
        }
    }
}
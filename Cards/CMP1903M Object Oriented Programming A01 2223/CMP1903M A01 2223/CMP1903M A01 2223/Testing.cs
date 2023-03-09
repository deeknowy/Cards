using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            Console.WriteLine("Initial pack:");
            PrintCards(pack);

            pack.shuffleCardPack(0);
            Console.WriteLine("\nPack after Fisher-Yates shuffle:");
            PrintCards(pack);

            pack.shuffleCardPack(1);
            Console.WriteLine("\nPack after Riffle shuffle:");
            PrintCards(pack);

            pack.shuffleCardPack(2);
            Console.WriteLine("\nPack after no shuffle:");
            PrintCards(pack);

            Console.WriteLine("\nDealing one card:");
            Console.WriteLine(pack.Deal());

            Console.WriteLine("\nDealing five cards:");
            var hand = pack.DealCard(5);
            foreach (var card in hand)
            {
                Console.WriteLine(card);
            }

        }

        static void PrintCards(Pack pack)
        {
            for (int i = 0; i < 51; i++)
            {
                Console.Write("{0,-19}", pack.Deal());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
        }
    }
}

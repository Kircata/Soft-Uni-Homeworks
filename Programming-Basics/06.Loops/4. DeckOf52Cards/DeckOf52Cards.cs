using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DeckOf52Cards

    {
        static void Main()
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine(i + "♣" + i + "♦" + i + "♥" + i + "♠");
            }
            for (int j = 1; j < 4; j++)
            {
                switch (j)
                {
                    case 1: Console.WriteLine("J" + "♣" + "J" + "♦" + "J" + "♥" + "J" + "♠");
                        break;
                    case 2: Console.WriteLine("Q" + "♣" + "Q" + "♦" + "Q" + "♥" + "Q" + "♠");
                        break;
                    case 3: Console.WriteLine("K" + "♣" + "K" + "♦" + "K" + "♥" + "K" + "♠");
                        break;
                    case 4: Console.WriteLine("A" + "♣" + "A" + "♦" + "A" + "♥" + "A" + "♠");
                        break;
                    default:
                        break;
                }
            }
          

        }
    }


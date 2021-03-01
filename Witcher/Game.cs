using System;
using System.Collections.Generic;
using System.Threading;

namespace Witcher
{
    class Game
    {
        public List<Witcher> players = new List<Witcher> ();
        Witcher player1;
        Witcher player2;
        Random rnd = new Random();
        ConsoleColor currentForeground = Console.ForegroundColor;
        bool random_choice()
        {
            if (players.Count >= 2)
            {
                int count = players.Count;
                int index1 = rnd.Next(0, count);
                int index2 = rnd.Next(0, count);
                while (index1 == index2)
                {
                    index2 = rnd.Next(0, count);
                }

                player1 = players[index1];
                player2 = players[index2];
                return true;
            }
            else
                return false;
        }

        public void start_tournament()
        {
            if (!random_choice()) Console.WriteLine("not enough players");
            else
            {
                Console.WriteLine("Player 1");
                player1.info();
                Console.WriteLine("Player 2");
                player2.info();



                Console.WriteLine("FIGHT!");
                start_fight();
            }

        }
        void start_fight()
        {
            while (player1.currentLife > 0 && player2.currentLife >0) {
                Console.WriteLine("player 1 turn");
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Console.WriteLine($"fighter deals damage {calculate_force(ref player1, ref player2)}");
                Console.WriteLine($"victim life is {player2.currentLife}" );


                if (player2.currentLife < 1) break;


                Console.WriteLine();
                Console.ForegroundColor = currentForeground;
                Console.WriteLine("player 2 turn");
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);

                }
                Console.WriteLine();
                Console.WriteLine($"fighter deals damage {calculate_force(ref player2, ref player1)}");
                Console.WriteLine($"victim life is {player1.currentLife}" );
                Console.WriteLine();
                Console.ForegroundColor = currentForeground;
            }

            Console.ForegroundColor = currentForeground;
            Console.WriteLine();
            Console.WriteLine("Results:");
            if (player1.currentLife < 1)
            {
                Console.WriteLine($"Player 2 - {player2.name} - wins");
                player2.win_count++;
            }
            else
            {
                Console.WriteLine($"Player 1 - {player1.name} - wins");
                player1.win_count++;
            }
            player1.currentLife = player1.life;
            player2.currentLife = player2.life;
        }

        double calculate_force( ref Witcher fighter, ref Witcher victim)
        {
            fighter.calculate_force();
            victim.calculate_protect();


            double result = fighter.force - fighter.force * victim.protect / 100;
            victim.currentLife -= result;
            return result;
        }
    }
}

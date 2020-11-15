using Game_Of_Cards;
using Game_Of_Cards.Interfaces;
using Game_Of_Cards.RulesEngine;
using System;
using System.Collections.Generic;

namespace GameOfCards_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("TiME tO pLaY!\r\n\r\nEnter your name: ");

            var username = Console.ReadLine();
            var player = new Player(username);

            var dealer = new Dealer("Dealer");

            var rules = new IRule[]
            {
                new Game2117Rules(new List<IPlayer> { player, dealer })
            };

            var scoreboard = new ScoreBoard(rules);
            scoreboard.AddPlayer(dealer);
            scoreboard.AddPlayer(player);

            Console.WriteLine("\r\nHello {0}" +
                "\r\nRuLEs:" +
                "\r\n* You only have 21 liVes." +
                "\r\n* The Dealer only have 17 liVes." +
                "\r\n* Game ends as soon as ones lives are done." +
                "\r\n" +
                "\r\n" +
                "Play Directions:" +
                "\r\no Press Y to play your turn." +
                "\r\no Press D to give the Dealer a play turn.", username);

            Console.WriteLine("\r\n\r\nReaDy tO pLaY?\r\n> Press Y to start playing.\r\n> Press Enter to exit the game");
            var startGameKey = Console.ReadKey();

            if (startGameKey.Key == ConsoleKey.Y)
            {
                var game = new GameOfCards(scoreboard);

                game.DealTo(player);
                Console.WriteLine("\r\nYour score: {0}\r\nNumber of Plays: {1}", player.Score, player.Hand.Count);

                do
                {
                    Console.Write("\r\n\r\nPlay again? Y/D: ");

                    var hand = player.Hand;
                    var playAgain = Console.ReadKey();
                    if (playAgain.Key == ConsoleKey.Y)
                    {
                        game.DealTo(player);
                        Console.WriteLine("\r\nYour score: {0}\r\nNumber of Plays: {1}", player.Score, hand.Count);
                    }
                    else if (playAgain.Key == ConsoleKey.D)
                    {
                        game.DealTo(dealer);
                        Console.WriteLine("\r\nDealer score: {0}\r\nNumber of Plays: {1}", dealer.Score, dealer.Hand.Count);
                    }

                } while (!scoreboard.IsGameOver);

                Console.WriteLine("\r\nGAmE OvEr!!!");

                if (scoreboard.Winner == player)
                {
                    Console.WriteLine("\r\n\r\nYoU wOn!!!\r\n\r\nYour score: {0}\r\nNumber of Plays: {1}", player.Score, player.Hand.Count);
                }
                else
                {
                    Console.WriteLine("DeAlEr wOn!!!\r\nDealer score: {0}\r\nNumber of Plays: {1}", dealer.Score, dealer.Hand.Count);
                }
                Console.ReadLine();
            }
            Console.WriteLine("See you again, sOOn!");
        }
    }
}

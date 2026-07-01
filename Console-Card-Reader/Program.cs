using System;
using System.Collections.Generic; // Added for List
using ConsoleCards;

namespace ProgrammingAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input) && input[0] != 'q')
            {
                Deck mydeck = new Deck();
                mydeck.Shuffle();

                int RankValue(string rankName)
                {
                    if (string.IsNullOrEmpty(rankName)) return 0;
                    switch (rankName.ToLower())
                    {
                        case "ace": return 14;
                        case "two": return 2;
                        case "three": return 3;
                        case "four": return 4;
                        case "five": return 5;
                        case "six": return 6;
                        case "seven": return 7;
                        case "eight": return 8;
                        case "nine": return 9;
                        case "ten": return 10;
                        case "jack": return 11;
                        case "queen": return 12;
                        case "king": return 13;
                        default: return 0;
                    }
                }

                List<Card>[] players = new List<Card>[4];
                for (int i = 0; i < 4; i++)
                {
                    players[i] = new List<Card>();
                    for (int j = 0; j < 3; j++)
                    {
                        Card temp = mydeck.TakeTopCard();
                        temp.FlipOver();
                        players[i].Add(temp);
                        Console.WriteLine($"Player {i + 1} card {j + 1}: {temp.Rank} of {temp.Suit}");
                    }
                }

                int highestRank = -1;
                string winner = "No one";

                for (int i = 0; i < players.Length; i++)
                {
                    foreach (Card card in players[i])
                    {
                        int currentRank = RankValue(card.Rank.ToString());
                        if (currentRank > highestRank)
                        {
                            highestRank = currentRank;
                            winner = $"Player {i + 1}";
                        }
                    }
                }

                Console.WriteLine(winner + " has the highest card!");
                input = Console.ReadLine();
            }
        } // Closes Main
    } // Closes Program class
} // Closes Namespace

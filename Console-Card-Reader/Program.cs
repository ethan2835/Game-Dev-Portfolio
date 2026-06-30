using System;
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

                int highestRank = -1;
                string winner = "No one";

                // helper function
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

                // deal cards (3 each now)
                Card p1_card1 = mydeck.TakeTopCard();
                Card p2_card1 = mydeck.TakeTopCard();
                Card p3_card1 = mydeck.TakeTopCard();
                Card p4_card1 = mydeck.TakeTopCard();

                Card p1_card2 = mydeck.TakeTopCard();
                Card p2_card2 = mydeck.TakeTopCard();
                Card p3_card2 = mydeck.TakeTopCard();
                Card p4_card2 = mydeck.TakeTopCard();

                Card p1_card3 = mydeck.TakeTopCard();
                Card p2_card3 = mydeck.TakeTopCard();
                Card p3_card3 = mydeck.TakeTopCard();
                Card p4_card3 = mydeck.TakeTopCard();

                // flip cards
                p1_card1.FlipOver(); p1_card2.FlipOver(); p1_card3.FlipOver();
                p2_card1.FlipOver(); p2_card2.FlipOver(); p2_card3.FlipOver();
                p3_card1.FlipOver(); p3_card2.FlipOver(); p3_card3.FlipOver();
                p4_card1.FlipOver(); p4_card2.FlipOver(); p4_card3.FlipOver();

                // print cards
                Console.WriteLine(p1_card1.Rank + " of " + p1_card1.Suit);
                Console.WriteLine(p1_card2.Rank + " of " + p1_card2.Suit);
                Console.WriteLine(p1_card3.Rank + " of " + p1_card3.Suit);

                Console.WriteLine(p2_card1.Rank + " of " + p2_card1.Suit);
                Console.WriteLine(p2_card2.Rank + " of " + p2_card2.Suit);
                Console.WriteLine(p2_card3.Rank + " of " + p2_card3.Suit);

                Console.WriteLine(p3_card1.Rank + " of " + p3_card1.Suit);
                Console.WriteLine(p3_card2.Rank + " of " + p3_card2.Suit);
                Console.WriteLine(p3_card3.Rank + " of " + p3_card3.Suit);

                Console.WriteLine(p4_card1.Rank + " of " + p4_card1.Suit);
                Console.WriteLine(p4_card2.Rank + " of " + p4_card2.Suit);
                Console.WriteLine(p4_card3.Rank + " of " + p4_card3.Suit);

                // Winner logic - inside the loop
                if (RankValue(p1_card1.Rank.ToString()) > highestRank) { highestRank = RankValue(p1_card1.Rank.ToString()); winner = "Player 1"; }
                if (RankValue(p1_card2.Rank.ToString()) > highestRank) { highestRank = RankValue(p1_card2.Rank.ToString()); winner = "Player 1"; }
                if (RankValue(p1_card3.Rank.ToString()) > highestRank) { highestRank = RankValue(p1_card3.Rank.ToString()); winner = "Player 1"; }

                if (RankValue(p2_card1.Rank.ToString()) > highestRank) { highestRank = RankValue(p2_card1.Rank.ToString()); winner = "Player 2"; }
                if (RankValue(p2_card2.Rank.ToString()) > highestRank) { highestRank = RankValue(p2_card2.Rank.ToString()); winner = "Player 2"; }
                if (RankValue(p2_card3.Rank.ToString()) > highestRank) { highestRank = RankValue(p2_card3.Rank.ToString()); winner = "Player 2"; }

                if (RankValue(p3_card1.Rank.ToString()) > highestRank) { highestRank = RankValue(p3_card1.Rank.ToString()); winner = "Player 3"; }
                if (RankValue(p3_card2.Rank.ToString()) > highestRank) { highestRank = RankValue(p3_card2.Rank.ToString()); winner = "Player 3"; }
                if (RankValue(p3_card3.Rank.ToString()) > highestRank) { highestRank = RankValue(p3_card3.Rank.ToString()); winner = "Player 3"; }

                if (RankValue(p4_card1.Rank.ToString()) > highestRank) { highestRank = RankValue(p4_card1.Rank.ToString()); winner = "Player 4"; }
                if (RankValue(p4_card2.Rank.ToString()) > highestRank) { highestRank = RankValue(p4_card2.Rank.ToString()); winner = "Player 4"; }
                if (RankValue(p4_card3.Rank.ToString()) > highestRank) { highestRank = RankValue(p4_card3.Rank.ToString()); winner = "Player 4"; }

                Console.WriteLine(winner + " has the highest card!");

                // Don't add or modify any code below this comment
                input = Console.ReadLine();
            }
        }
    }
}
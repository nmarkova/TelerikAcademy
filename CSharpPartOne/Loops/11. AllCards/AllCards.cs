// 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case. 

using System;

class AllCards
{
    static void Main()
    {
        string[] ranks = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[] colors = { "Clubs", "Diamonds", "Hearts", "Spades" };
        foreach (var rank in ranks)
        {
            foreach (var color in colors)
            {
                Console.WriteLine(rank + " of " + color);
            }
        }
    }
}

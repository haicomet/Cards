using Cards2;
using System;

// loop while there's more input
string? input = Console.ReadLine();

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck deck = new Deck();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)

List<Card>[] players = new List<Card>[4];

for (int i = 0; i < 4; i++)
{
    players[i] = new List<Card>();
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        players[j].Add(deck.TakeTopCard());
    }
}

// deal 1 more card to players 2 and 3
players[1].Add(deck.TakeTopCard());
players[2].Add(deck.TakeTopCard());

// flip all the cards over
for (int i = 0; i < 4; i++)
{
    foreach (Card card in players[i])
    {
        card.FlipOver();
    }
   
}
// print the cards for player 1
// print the cards for player 2
// print the cards for player 3
// print the cards for player 4

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Player {i + 1}'s cards:");
    foreach (Card card in players[i])
    {
        Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
    Console.WriteLine();
}

{ /*Deck deck = new Deck();
deck.Shuffle();

Card card = deck.TakeTopCard();
Console.WriteLine($"Top Card: {card.Rank} of {card.Suit}");

//card.Rank = Rank.Ace;
// card.Rank cannot be changed because it is readonly

Console.WriteLine($"Cards left in deck: ");
deck.Print();
*/
}

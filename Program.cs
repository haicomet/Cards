using Cards2;

Deck deck = new Deck();
deck.Shuffle();

Card card = deck.TakeTopCard();
Console.WriteLine($"Top Card: {card.Rank} of {card.Suit}");

//card.Rank = Rank.Ace;
// card.Rank cannot be changed because it is readonly

Console.WriteLine($"Cards left in deck: ");
deck.Print();
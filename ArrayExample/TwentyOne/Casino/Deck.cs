using System;
using System.Collections.Generic;
using System.Text;

namespace Casino.TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card
                    {
                        Face = (Face)i,
                        Suit = (Suit)j
                    };
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 3)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> temporaryList = [];
                Random random = new();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);

                    temporaryList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = temporaryList;
            }
        }
    }
}

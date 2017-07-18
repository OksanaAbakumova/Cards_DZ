using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Cards
{
    enum Suits
    {
        Hearts, Clubs, Spades, Diamonds
    }

    enum Ratings
    {
        Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 2, Queen = 3, King = 4, Ace = 11
    }

    struct Card
    {
        public Suits Suit;
        public Ratings Rating;
    }

    struct Deck
    {
        public Card[] Cards;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Enum.GetValues(typeof(Suits))-приводит значения Enum к массиву и позволяет работать с ним в цикле
            /*
            Deck Deck = new Deck();
            Deck.Cards = new Card[36];
            
            for (int s = 0; s < 4; s++)
            {
                int i = s * 9;

                for (int r = 0; r < 9; r++)
                {
                    Deck.Cards[i].Suit = (Suits) Enum.GetValues(typeof(Suits)).GetValue(s);  // приведение типа к Enum
                    Deck.Cards[i].Rating = (Ratings) Enum.GetValues(typeof(Ratings)).GetValue(r);

                    i++;
                }
            }
            // Вывод упорядоченной колоды карт

          /* for (int z = 1; z <= 36; z++)
            {
                Console.WriteLine("--- " + z + " ---");
                Console.WriteLine(Deck.Cards[z - 1].Suit);
                Console.WriteLine(Deck.Cards[z - 1].Rating);
            }

            Console.WriteLine("----------"); */

            //Перемешать колоду карт
            /*
            Random random = new Random();

            for (int i = Deck.Cards.Length-1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                // exchange perm[j] and perm[i]
                Card temp = Deck.Cards[j];
                Deck.Cards[j] = Deck.Cards[i];
                Deck.Cards[i] = temp;
            } */

            //Вывод перемешенной колоды карт

            /* for (int z = 1; z <= 36; z++)
             {
                 Console.WriteLine("---index " + (z-1) + " ---");
                 Console.WriteLine(Deck.Cards[z - 1].Suit);
                 Console.WriteLine(Deck.Cards[z - 1].Rating);
             } */

            //Найти позиции всех тузов в колоде
            /*
                        int indexH = 0;
                        int indexC = 0;
                        int indexS = 0;
                        int indexD = 0;


                        for (int i = 0; i < 36; i++)
                        {
                            if ((Deck.Cards[i].Suit == Suits.Hearts) && (Deck.Cards[i].Rating == Ratings.Ace))
                                    indexH = i;
                            if ((Deck.Cards[i].Suit == Suits.Clubs) && (Deck.Cards[i].Rating == Ratings.Ace))
                                indexC = i;
                            if ((Deck.Cards[i].Suit == Suits.Spades) && (Deck.Cards[i].Rating == Ratings.Ace))
                                indexS = i;
                            if ((Deck.Cards[i].Suit == Suits.Diamonds) && (Deck.Cards[i].Rating == Ratings.Ace))
                                indexD = i;
                        } */
            /*
            Console.WriteLine("---------");
            Console.WriteLine("Ace Hearts index: "+ indexH);
            Console.WriteLine("Ace Clubs index: " + indexC);
            Console.WriteLine("Ace Spades index: " + indexS);
            Console.WriteLine("Ace Diamonds index: " + indexD);
            */

            //Переместить все пиковые карты в начало колоды
            /*

            int index = 0;
            for (int i = 0; i < 36; i++)
            {
                if (Deck.Cards[i].Suit == Suits.Spades)
                {
                    Card temp = Deck.Cards[i];
                    Deck.Cards[i] = Deck.Cards[index];
                    Deck.Cards[index] = temp;
                    index++;
                }
                
            }  */

            // Сохранить колоду карт в файл

            //Считать колоду карт из файла

            //Считать с клавиатуры 2 числа, 1е(length) - длина массива, 
            //2е(max) значение максимального элемента массива. Сгенерировать такой массив 
            //чтобы в нем были все элементы от max - length до max, но в произвольном порядке

            Console.WriteLine("Введите размер массивов");
            int a = int.Parse(Console.ReadLine());
            int[] perm = new int[a];


            Console.WriteLine("Введите значение максимального элемента массива");
            int max = int.Parse(Console.ReadLine());

            Random r = new Random();

            int y = 0;
            for (int i = (max - a + 1); i <= max; i++)
            {
                perm[y] = i;
                y++;
            }

            for (int i = a - 1; i >= 1; i--)
            {
                int j = r.Next(a);
                // exchange perm[j] and perm[i]
                int temp = perm[j];
                perm[j] = perm[i];
                perm[i] = temp;
            }

            for (int i = 0; i < a; i++)
                Console.WriteLine(perm[i]);


            // Сортировка вставками


        }
    }
}

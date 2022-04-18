using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HIGH_OR_LOW
{
    internal class Program
    {

        public enum CardSort
        {
            Hearts,
            Diamonds,
            Spades,
            Clover

        }
        static void Main(string[] args)
        {
            Console.Title = "High or Low";
            List<int> tal = new List<int>();
            char[] symbol = { 'J', 'Q', 'K', 'A' };
            bool back = true;
            while (true)
            {

                Console.Clear();
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Leaderboard");
                Console.WriteLine("3. Info");
                Console.WriteLine("4. Exit");
                Console.Write("Answer: ");
                back = true;
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        string gamemode;

                        while (true)
                        {
                            Console.Clear();
                            Console.Write("one or two players: ");
                            try
                            {
                                gamemode = Console.ReadLine();
                                if (gamemode == "one")
                                {
                                    gamemode = "one";
                                    break;
                                }
                                else if (gamemode == "two")
                                {
                                    gamemode = "two";
                                    break;
                                }
                                else if (gamemode == "1")
                                {
                                    gamemode = "1";
                                    break;
                                }
                                else if (gamemode == "2")
                                {
                                    gamemode = "2";
                                    break;
                                }

                            }
                            catch
                            {
                                Console.WriteLine("one or two");
                            }

                        }
                        if (gamemode == "one" || gamemode == "1")
                        {
                            Console.Clear();
                            string playerAnswer = "";
                            int current = 0;
                            int previous = 0;
                            int points = 0;
                            int points1 = 0;
                            int points2 = 0;
                            int points3 = 0;
                            int points4 = 0;
                            int extraPoints = 50;
                            int totalpoints = 0;
                            int round = 0;
                            int color1 = 0;
                            int cardsLeft = 52;
                            string color;
                            string previousCard = "";
                            string currentCard = "";
                            bool alive = true;
                            bool pair = false;
                            Random card = new Random();
                            Cards allCards;
                            List<Cards> chunk = new List<Cards>(52);


                            for (int i = 1; i <= 13; i++)
                            {
                                for (int j = 1; j <= 4; j++)
                                {
                                    allCards = new Cards(i, j);
                                    chunk.Add(allCards);
                                }
                            }

                            Console.WriteLine("The dealer puts 13 cards on the tabel and flips up the first card");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();


                            alive = true;

                            while (alive)
                            {
                                while (alive)
                                {
                                    round++;
                                    cardsLeft--;
                                    int index = card.Next(0, chunk.Count);
                                    List<Cards> first = new List<Cards>();
                                    if (round == 1)
                                    {
                                        first.Add(chunk.ElementAt(index));
                                        chunk.RemoveAt(index);
                                        foreach (Cards firstCard in first)
                                        {
                                            color1 = firstCard.Color();
                                            previous = firstCard.Number();
                                        }
                                        first.RemoveAt(0);
                                    }
                                    else
                                    {
                                        previous = current;
                                    }
                                    if (round == 13)
                                    {
                                        points1 = points;
                                        if (pair == false)
                                        {
                                            if (round == 13 && points1 == 12)
                                            {
                                                totalpoints = points1 + extraPoints;
                                                Console.WriteLine("All right for this round now you get 50 extrapoints");
                                            }
                                            else
                                            {
                                                totalpoints = points1;
                                            }
                                        }
                                        else
                                        {
                                            points1 = 0;
                                            Console.WriteLine("You got a pair your score is now 0 for this round");
                                            Console.WriteLine("Press enter to continue");
                                            Console.ReadLine();
                                            pair = false;
                                        }
                                        Console.WriteLine("All 13/52 cards played now the dealer placed 13 more on the table");
                                        Console.WriteLine("Press enter to continue");
                                        Console.ReadLine();

                                    }
                                    else if (round == 26)
                                    {
                                        points2 = points - points1;
                                        if (pair == false)
                                        {
                                            if (round == 26 && points2 == 12)
                                            {
                                                totalpoints = points2 + extraPoints;
                                            }
                                            else
                                            {
                                                totalpoints = points2;
                                            }
                                        }
                                        else
                                        {
                                            points2 = 0;
                                            Console.WriteLine("You got a pair your score is now 0 for this round");
                                            Console.WriteLine("Press enter to continue");
                                            Console.ReadLine();
                                            pair = false;
                                        }
                                        Console.WriteLine("All {26/52 cards played now the dealer placed 13 more on the table");
                                        Console.WriteLine("Press enter to continue");
                                        Console.ReadLine();

                                    }
                                    else if (round == 39)
                                    {
                                        points3 = points - points2;
                                        if (pair == false)
                                        {
                                            if (round == 39 && points3 == 12)
                                            {
                                                totalpoints = points3 + extraPoints;
                                            }
                                            else
                                            {
                                                totalpoints = points3;
                                            }
                                        }
                                        else
                                        {
                                            points3 = 0;
                                            Console.WriteLine("You got a pair your score is now 0 for this round");
                                            Console.WriteLine("Press enter to continue");
                                            Console.ReadLine();
                                            pair = false;
                                        }
                                        Console.WriteLine("All 39/52 cards played now the dealer placed 13 more on the table");
                                        Console.WriteLine("Press enter to continue");
                                        Console.ReadLine();
                                    }
                                    else if (round == 52)
                                    {
                                        points4 = points - points3;
                                        if (pair == false)
                                        {

                                            if (round == 52 && points4 == 12)
                                            {
                                                totalpoints = points4 + extraPoints;
                                            }
                                            else
                                            {
                                                totalpoints = points4;
                                            }
                                        }
                                        else
                                        {
                                            points4 = 0;
                                            Console.WriteLine("You got a pair your score is now 0 for this round");
                                            Console.WriteLine("Press enter to continue");
                                            Console.ReadLine();
                                            pair = false;
                                        }
                                        Console.WriteLine("All 52/52 cards played now the dealer placed 13 more on the table");
                                        Console.WriteLine("Press enter to continue");
                                        Console.ReadLine();
                                    }
                                    if (cardsLeft == 0)
                                    {
                                        alive = false;
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.Write("Save score yes or no:");
                                            string saveScore;
                                            try
                                            {
                                                saveScore = Console.ReadLine();
                                                if (saveScore == "yes")
                                                {
                                                    Console.Clear();
                                                    tal.Add(totalpoints);
                                                    break;
                                                }
                                                else if (saveScore == "no")
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("yes or no");
                                            }
                                        }
                                        break;
                                    }

                                    while (alive)
                                    {
                                        Console.Clear();

                                        if (color1 == 1)
                                        {
                                            color = "Hearts";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Hearts);
                                                previousCard = symbol[0] + " of " + color;

                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Hearts);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Hearts);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Hearts);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Hearts);
                                                previousCard = previous.ToString() + " of " + color;
                                            }

                                        }
                                        else if (color1 == 2)
                                        {
                                            color = "Diamonds";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Diamonds);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Diamonds);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Diamonds);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Diamonds);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Diamonds);
                                                previousCard = previous.ToString() + " of " + color;
                                            }


                                        }
                                        else if (color1 == 3)
                                        {
                                            color = "Spades";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Spades);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Spades);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Spades);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Spades);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Spades);
                                                previousCard = previous.ToString() + " of " + color;
                                            }


                                        }
                                        else if (color1 == 4)
                                        {
                                            color = "Clover";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Clover);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Clover);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Clover);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Clover);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Clover);
                                                previousCard = previous.ToString() + " of " + color;
                                            }
                                        }
                                        Console.Write("High or Low: ");
                                        playerAnswer = Console.ReadLine();
                                        try
                                        {
                                            if (playerAnswer == "high" || playerAnswer == "low")
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Need to be high or low");
                                            Console.ReadLine();
                                        }
                                    }
                                    round++;
                                    int pos = card.Next(0, chunk.Count);
                                    List<Cards> second = new List<Cards>();
                                    second.Add(chunk.ElementAt(pos));
                                    chunk.RemoveAt(pos);
                                    foreach (Cards secondCard in second)
                                    {
                                        color1 = secondCard.Color();
                                        current = secondCard.Number();
                                    }
                                    second.RemoveAt(0);
                                    if (playerAnswer == "high" && current > previous || current == 1 || previous == 1)
                                    {
                                        points++;
                                        Console.WriteLine("you guessed right!");
                                        Console.WriteLine("Points: " + points);
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        if (color1 == 1)
                                        {
                                            color = "Hearts";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Hearts);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Hearts);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Hearts);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Hearts);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Hearts);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 2)
                                        {
                                            color = "Diamonds";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Diamonds);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Diamonds);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Diamonds);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Diamonds);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Diamonds);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 3)
                                        {
                                            color = "Spades";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Spades);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Spades);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Spades);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Spades);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Spades);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 4)
                                        {
                                            color = "Clover";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Clover);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Clover);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Clover);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Clover);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Clover);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                    }
                                    else if (playerAnswer == "low" && current < previous || current == 1 || previous == 1)
                                    {
                                        points++;
                                        Console.WriteLine("you guessed right!");
                                        Console.WriteLine("Points: " + points);
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        if (color1 == 1)
                                        {
                                            color = "Hearts";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Hearts);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Hearts);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Hearts);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Hearts);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Hearts);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 2)
                                        {
                                            color = "Diamonds";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Diamonds);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Diamonds);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Diamonds);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Diamonds);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Diamonds);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 3)
                                        {
                                            color = "Spades";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Spades);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Spades);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Spades);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Spades);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else                                  
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Spades);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 4)
                                        {
                                            color = "Clover";
                                            if (current == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Clover);
                                                currentCard = symbol[0] + " of " + color;
                                            }
                                            else if (current == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Clover);
                                                currentCard = symbol[1] + " of " + color;
                                            }
                                            else if (current == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Clover);
                                                currentCard = symbol[2] + " of " + color;
                                            }
                                            else if (current == 14 || current == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Clover);
                                                currentCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Previous: " + current + " of " + CardSort.Clover);
                                                currentCard = current.ToString() + " of " + color;
                                            }
                                        }
                                    }
                                    else if (current == previous)
                                    {
                                        pair = true;
                                    }
                                    else
                                    {
                                            Console.WriteLine("You guessed wrong!");
                                            Console.WriteLine("Previous: " + previousCard + "\nCurrent: " + currentCard);
                                            Console.ReadLine();                                       
                                            break;
                                    }
                                    Console.ReadKey();
                                }
                            }
                        }
                        else if (gamemode == "two" || gamemode == "2")
                        {
                            Console.Clear();
                            string playerOneAnswer = "", playerTwoAnswer = "";
                            int current = 0;
                            int previous = 0;
                            int player1 = 0;
                            int player11 = 0;
                            int player12 = 0;
                            int player13 = 0;
                            int player14 = 0;
                            int player2 = 0;
                            int player21 = 0;
                            int player22 = 0;
                            int player23 = 0;
                            int player24 = 0;
                            int totalPointsPlayer1 = 0;
                            int totalPointsPlayer2 = 0;
                            int extraPoints = 50;
                            int round = 0;
                            int color1 = 0;
                            int totalCards = 0;
                            int cardsLeft = 52;
                            string color;
                            string previousCard = "";
                            string currentCard = "";
                            bool alive = true;
                            bool pair = false;
                            bool p1 = false, p2 = false;

                            Random card = new Random();
                            Cards allCards;
                            List<Cards> chunk = new List<Cards>(52);

                            alive = true;


                            for (int i = 1; i <= 13; i++)
                            {
                                for (int j = 1; j <= 4; j++)
                                {
                                    allCards = new Cards(i, j);
                                    chunk.Add(allCards);
                                }
                            }

                            Console.WriteLine("The dealer puts 13 cards on the tabel and flips up the first card");


                            while (alive)
                            {

                                while (alive)
                                {
                                    round++;
                                    cardsLeft--;
                                    totalCards++;
                                    int index = card.Next(0, chunk.Count);
                                    List<Cards> first = new List<Cards>();
                                    if (round == 1)
                                    {
                                        first.Add(chunk.ElementAt(index));
                                        chunk.RemoveAt(index);
                                        foreach (Cards firstCard in first)
                                        {
                                            color1 = firstCard.Color();
                                            previous = firstCard.Number();
                                        }
                                        first.RemoveAt(0);
                                    }
                                    else
                                    {
                                        previous = current;
                                    }
                                    if (round == 13)
                                    {
                                        player11 = player1;
                                        player21 = player2;
                                        if (pair == false)
                                        {
                                            if (round == 13 && player11 == 13)
                                            {
                                                totalPointsPlayer1 = player11 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer1 = player11;
                                            }
                                            if (round == 13 && player21 == 13)
                                            {
                                                totalPointsPlayer2 = player21 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer2 = player21;
                                            }
                                        }
                                        else
                                        {
                                            player11 = 0;
                                            player21 = 0;
                                            pair = false;
                                        }
                                        Console.WriteLine("All 13/52 cards played now the dealer placed 13 more on the table");
                                        Console.ReadLine();
                                    }
                                    else if (round == 26)
                                    {
                                        player12 = player1 - player11;
                                        player22 = player2 - player21;
                                        if (pair == false)
                                        {
                                            if (round == 26 && player11 == 13)
                                            {
                                                totalPointsPlayer1 = player12 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer1 = player12;
                                            }
                                            if (round == 13 && player21 == 13)
                                            {
                                                totalPointsPlayer2 = player22 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer2 = player22;
                                            }
                                        }
                                        else
                                        {
                                            player12 = 0;
                                            player22 = 0;
                                            pair = false;
                                        }
                                        Console.WriteLine("All 26/52 cards played now the dealer placed 13 more on the table");
                                        Console.ReadLine();


                                    }
                                    else if (round == 39)
                                    {
                                        player13 = player1 - player12;
                                        player23 = player2 - player22;
                                        if (pair == false)
                                        {
                                            if (round == 26 && player13 == 13)
                                            {
                                                totalPointsPlayer1 = player13 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer1 = player13;
                                            }
                                            if (round == 13 && player23 == 13)
                                            {
                                                totalPointsPlayer2 = player23 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer2 = player23;
                                            }
                                        }
                                        else
                                        {
                                            player13 = 0;
                                            player23 = 0;
                                            pair = false;
                                        }
                                        Console.WriteLine("All 39/52 cards played now the dealer placed 13 more on the table");
                                        Console.ReadLine();
                                    }
                                    else if (round == 52)
                                    {
                                        player14 = player1 - player13;
                                        player24 = player2 - player23;
                                        if (pair == false)
                                        {
                                            if (round == 26 && player14 == 13)
                                            {
                                                totalPointsPlayer1 = player14 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer1 = player14;
                                            }
                                            if (round == 13 && player24 == 13)
                                            {
                                                totalPointsPlayer2 = player24 + extraPoints;
                                            }
                                            else
                                            {
                                                totalPointsPlayer2 = player24;
                                            }
                                        }
                                        else
                                        {
                                            player14 = 0;
                                            player24 = 0;
                                            pair = false;
                                        }
                                        Console.WriteLine("All 52/52 cards played now the dealer placed 13 more on the table");
                                        Console.ReadLine();
                                    }
                                    if (cardsLeft == 0)
                                    {
                                        alive = false;
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.Write("Player1 Save score yes or no:");
                                            string saveScore;
                                            try
                                            {
                                                saveScore = Console.ReadLine();
                                                if (saveScore == "yes")
                                                {
                                                    Console.Clear();
                                                    tal.Add(totalPointsPlayer1);
                                                    break;
                                                }
                                                else if (saveScore == "no")
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("yes or no");
                                            }
                                        }
                                        while (true)
                                        {
                                            Console.Clear();
                                            Console.Write("Player2 Save score yes or no:");
                                            string saveScore;
                                            try
                                            {
                                                saveScore = Console.ReadLine();
                                                if (saveScore == "yes")
                                                {
                                                    Console.Clear();
                                                    tal.Add(totalPointsPlayer2);
                                                    break;
                                                }
                                                else if (saveScore == "no")
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("yes or no");
                                            }
                                        }
                                        break;
                                    }

                                    while (alive)
                                    {
                                        Console.Clear();
                                        if (color1 == 1)
                                        {
                                            color = "Hearts";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Hearts);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Hearts);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Hearts);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Hearts);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Hearts);
                                                previousCard = previous.ToString() + " of " + color;
                                            }
                                        }
                                        else if (color1 == 2)
                                        {
                                            color = "Diamonds";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Diamonds);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Diamonds);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Diamonds);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Diamonds);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Diamonds);
                                                previousCard = previous.ToString() + " of " + color;
                                            }


                                        }
                                        else if (color1 == 3)
                                        {
                                            color = "Spades";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Spades);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Spades);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Spades);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Spades);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Spades);
                                                previousCard = previous.ToString() + " of " + color;
                                            }


                                        }
                                        else if (color1 == 4)
                                        {
                                            color = "Clover";
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            if (previous == 11)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[0], CardSort.Clover);
                                                previousCard = symbol[0] + " of " + color;
                                            }
                                            else if (previous == 12)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[1], CardSort.Clover);
                                                previousCard = symbol[1] + " of " + color;
                                            }
                                            else if (previous == 13)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[2], CardSort.Clover);
                                                previousCard = symbol[2] + " of " + color;
                                            }
                                            else if (previous == 14 || previous == 1)
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", symbol[3], CardSort.Clover);
                                                previousCard = symbol[3] + " of " + color;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Clover);
                                                previousCard = previous.ToString() + " of " + color;
                                            }
                                        }
                                        Console.WriteLine("High or Low: ");
                                        while (alive)
                                        {
                                            try
                                            {
                                                Console.Write("Player1: ");
                                                playerOneAnswer = Console.ReadLine();
                                                if (playerOneAnswer == "high" || playerOneAnswer == "low")
                                                {
                                                    p1 = true;
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Need to be high or low");
                                                Console.ReadLine();
                                            }
                                        }


                                        while (alive)
                                        {
                                            try
                                            {
                                                Console.Write("Player2: ");
                                                playerTwoAnswer = Console.ReadLine();
                                                if (playerTwoAnswer == "high" || playerTwoAnswer == "low")
                                                {
                                                    p2 = true;
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Need to be high or low");
                                                Console.ReadLine();
                                            }
                                        }
                                        if (p1 == p2 == true)
                                        {
                                            break;
                                        }

                                    }
                                    round++;
                                    int pos = card.Next(0, chunk.Count);
                                    List<Cards> second = new List<Cards>();
                                    second.Add(chunk.ElementAt(pos));
                                    chunk.RemoveAt(pos);

                                    foreach (Cards secondCard in second)
                                    {
                                        color1 = secondCard.Color();
                                        current = secondCard.Number();
                                    }
                                    second.RemoveAt(0);
                                    Console.Clear();
                                    if ((playerOneAnswer == "high" && current > previous) || (playerOneAnswer == "high" && current > previous) && (playerTwoAnswer == "high" && current > previous) || (playerTwoAnswer == "high" && current > previous))
                                    {
                                        player1++;
                                        player2++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player1 points: " + player1 + " Player2 points: " + player2);

                                    }
                                    else if ((playerOneAnswer == "low" && current < previous) && (playerTwoAnswer == "low" && current < previous))
                                    {
                                        player1++;
                                        player2++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player1 points: " + player1 + " Player2 points: " + player2);
                                    }
                                    else if ((playerOneAnswer == "high" && current > previous) && (playerTwoAnswer == "low" && current > previous))
                                    {
                                        player1++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player1 points: " + player1);
                                    }
                                    else if ((playerOneAnswer == "low" && current > previous) && (playerTwoAnswer == "high" && current > previous))
                                    {
                                        player2++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player2 points: " + player2);
                                    }
                                    else if ((playerOneAnswer == "low" && current < previous) && (playerTwoAnswer == "high" && current < previous))
                                    {
                                        player1++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player1 points: " + player1);
                                    }
                                    else if ((playerOneAnswer == "high" && current < previous) && (playerTwoAnswer == "low" && current < previous))
                                    {
                                        player2++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player2 points: " + player2);
                                    }
                                    else if (current == previous)
                                    {
                                        pair = true;
                                    }
                                    else if (current == 1 || previous == 1)
                                    {
                                        player1++;
                                        player2++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player1 points: " + player1 + " Player2 points: " + player2);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You guessed wrong!");
                                        Console.WriteLine("Previous: " + previousCard + "\nCurrent: " + currentCard);
                                        Console.ReadLine();
                                        break;
                                    }
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                    else if (answer == 2)
                    {
                        Console.Clear();
                        int[] arr = new int[tal.Count];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = tal.ElementAt(i);
                        }
                        for (int i = 0; i < arr.Length; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                if (arr[j] < arr[i])
                                {
                                    int temp = arr[i];
                                    arr[i] = arr[j];
                                    arr[j] = temp;
                                }
                            }
                        }
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }
                        Console.ReadLine();
                    }
                    else if (answer == 3)
                    {

                        while (back)
                        {
                            Console.Clear();
                            Console.WriteLine("1.How to play");
                            Console.WriteLine("2. About Me");
                            Console.WriteLine("3. Go back");
                            Console.WriteLine("4. Exit");
                            Console.Write("Answer: ");
                            try
                            {
                                int infoAanswer = int.Parse(Console.ReadLine());
                                switch (infoAanswer)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Spelet ”High or Low” använder en vanlig kortlek med 52 kort utan jokrar och hela kortleken används \nuppdelat i fyra omgångar (13 kort per omgång). Spelet börjar med att blanda kortleken och sedan i första omgång läggs ut 13 kort med baksidan upp, därefter vänds det första kortet. \nSen ska spelaren avgöra om nästa kort är högre eller lägre tills alla 13 kort är passerade. Man får en poäng för varje rätt gissning och klarar man alla gissningar vinner man 50 poäng extra. Gissar man fel sparas de rätta gissningarna för den omgången. Spelet fortsätter med nästa omgång med 13 kort från samma kortlek som är en upprepning av första omgången. Ess fungerar som trumf för spelaren d v s det är både högst och lägst. Spelaren förlorar dock om det blir par.");
                                        Console.WriteLine("Programmet ska kunna användas av minst två spelare och det ska finnas en ”Highscore” lista.");
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("This is written by a passionat padawan programmer that idk dont give a shit");
                                        Console.ReadLine();
                                        break;
                                    case 3:
                                        back = false;
                                        break;
                                    case 4:
                                        Environment.Exit(0);
                                        break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("1, 2, 3, 4 are you stupid or something");
                            }
                            Console.ReadLine();
                        }

                    }
                    else if (answer == 4)
                    {
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    Console.WriteLine("type 1, 2, 3 or 4");
                    Console.ReadLine();
                }
            }
        }
    }
}

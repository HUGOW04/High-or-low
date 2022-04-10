using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            while (true)
            {

                Console.Clear();
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Leaderboard");
                Console.WriteLine("3. Info");
                Console.WriteLine("4. Exit");
                Console.Write("Answer: ");
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        string gamemode;

                        while (true)
                        {
                            Console.WriteLine("one or two players");
                            try
                            {
                                gamemode = Console.ReadLine();
                                if(gamemode == "one")
                                {
                                    gamemode = "one";
                                    break;
                                }
                                else if(gamemode == "two")
                                {
                                    gamemode = "two";
                                    break;
                                }

                            }
                            catch
                            {
                                Console.WriteLine("one or two");
                            }

                        }
                        if(gamemode == "one")
                        {
                            Console.Clear();
                            string playerAnswer = "";
                            int current = 0;
                            int previous = 0;
                            int points = 0;
                            int round = 0;
                            int color1 = 0;
                            int color2 = 0;
                            int totalCards = 0;
                            int cardsLeft = 52;
                            string color;
                            string previousCard = "";
                            Random card = new Random();
                            Cards allCards;
                            bool alive = true;
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
                            Console.ReadLine();
                            Console.Clear();

                            alive = true;

                            while (alive)
                            {
                                while (alive)
                                {

                                    totalCards++;
                                    cardsLeft -= 2;
                                    round++;
                                    int index = card.Next(0, chunk.Count);
                                    List<Cards> first = new List<Cards>();
                                    first.Add(chunk.ElementAt(index));
                                    chunk.RemoveAt(index);
                                    foreach (Cards firstCard in first)
                                    {
                                        color1 = firstCard.Color();
                                        previous = firstCard.Number();
                                    }
                                    first.RemoveAt(0);
                                    if (round == 13)
                                    {
                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();
                                    }
                                    else if (round == 26)
                                    {

                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();

                                    }
                                    else if (round == 39)
                                    {
                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();
                                    }
                                    else if (round == 52)
                                    {
                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();
                                    }
                                    if (cardsLeft == 40)
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
                                                    tal.Add(points);
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
                                    }

                                    while (alive)
                                    {

                                        Console.Clear();

                                        if (color1 == 1)
                                        {
                                            color = "Hearts";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Hearts);


                                        }
                                        else if (color1 == 2)
                                        {
                                            color = "Diamonds";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Diamonds);

                                        }
                                        else if (color1 == 3)
                                        {
                                            color = "Spades";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Spades);

                                        }
                                        else if (color1 == 4)
                                        {
                                            color = "Clover";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Clover);

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
                                    int pos = card.Next(0, chunk.Count);
                                    List<Cards> second = new List<Cards>();
                                    second.Add(chunk.ElementAt(pos));
                                    chunk.RemoveAt(pos);

                                    foreach (Cards secondCard in second)
                                    {
                                        color2 = secondCard.Color();
                                        current = secondCard.Number();
                                    }
                                    second.RemoveAt(0);
                                    if (playerAnswer == "high" && current > previous)
                                    {
                                        points++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Points: " + points);

                                    }
                                    else if (playerAnswer == "low" && current < previous)
                                    {
                                        points++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Points: " + points);
                                    }
                                    else
                                    {

                                        if (color2 == 1)
                                        {
                                            Console.WriteLine("Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + "\nCurrent: " + current + " of " + CardSort.Hearts);
                                            Console.ReadLine();
                                        }
                                        else if (color2 == 2)
                                        {
                                            Console.WriteLine("Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + "\nCurrent: " + current + " of " + CardSort.Diamonds);
                                            Console.ReadLine();
                                        }
                                        else if (color2 == 3)
                                        {
                                            Console.WriteLine("Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + "\nCurrent: " + current + " of " + CardSort.Spades);
                                            Console.ReadLine();
                                        }
                                        else if (color2 == 4)
                                        {
                                            Console.WriteLine("Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + "\nCurrent: " + current + " of " + CardSort.Clover);
                                            Console.ReadLine();
                                        }
                                        break;
                                    }
                                    Console.ReadKey();
                                }
                            }
                        }
                        else if(gamemode == "two")
                        {
                            Console.Clear();
                            string playerOneAnswer = "", playerTwoAnswer = "";
                            int current = 0;
                            int previous = 0;
                            int player1 = 0;
                            int player2 = 0;
                            int round = 0;
                            int color1 = 0;
                            int color2 = 0;
                            int totalCards = 0;
                            int cardsLeft = 52;
                            string color;
                            string previousCard = "";
                            bool alive = true;

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
                                round++;
                                cardsLeft -= 2;
                                totalCards++;

                                while (alive)
                                {
                                    int index = card.Next(0, chunk.Count);
                                    List<Cards> first = new List<Cards>();
                                    first.Add(chunk.ElementAt(index));
                                    chunk.RemoveAt(index);
                                    foreach (Cards firstCard in first)
                                    {
                                        color1 = firstCard.Color();
                                        previous = firstCard.Number();
                                    }
                                    first.RemoveAt(0);
                                    if (round == 13)
                                    {

                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();
                                    }
                                    else if (round == 26)
                                    {

                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();


                                    }
                                    else if (round == 39)
                                    {

                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();
                                    }
                                    else if (round == 52)
                                    {

                                        Console.WriteLine("All {0}/52 cards played now the dealer placed 13 more on the table", totalCards);
                                        Console.ReadLine();
                                    }
                                    if (cardsLeft == 0)
                                    {
                                        break;
                                    }

                                    while (alive)
                                    {


                                        Console.Clear();
                                        if (color1 == 1)
                                        {
                                            color = "Hearts";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Hearts);
                                        }
                                        else if (color1 == 2)
                                        {
                                            color = "Diamonds";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Diamonds);

                                        }
                                        else if (color1 == 3)
                                        {
                                            color = "Spades";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Spades);

                                        }
                                        else if (color1 == 4)
                                        {
                                            color = "Clover";
                                            previousCard = previous.ToString() + " at " + color;
                                            Console.WriteLine("Cards left: {0}", cardsLeft);
                                            Console.WriteLine("Current Card: {0} of {1}", previous, CardSort.Clover);

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
                                    int pos = card.Next(0, chunk.Count);
                                    List<Cards> second = new List<Cards>();
                                    second.Add(chunk.ElementAt(pos));
                                    chunk.RemoveAt(pos);

                                    foreach (Cards secondCard in second)
                                    {
                                        color2 = secondCard.Color();
                                        current = secondCard.Number();
                                    }
                                    second.RemoveAt(0);
                                    Console.Clear();
                                    if ((playerOneAnswer == "high" && current > previous) && (playerTwoAnswer == "high" && current > previous))
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
                                    else if ((playerOneAnswer == "low" && current < previous) && (playerTwoAnswer == "high" && current > previous))
                                    {
                                        player1++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player1 points: " + player1);
                                    }
                                    else if ((playerOneAnswer == "high" && current > previous) && (playerTwoAnswer == "low" && current < previous))
                                    {
                                        player2++;
                                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                                        Console.WriteLine("Player2 points: " + player2);
                                    }
                                    else
                                    {

                                        if (color2 == 1)
                                        {
                                            Console.WriteLine("Player1 and Player2 guessed wrong!" + " Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + " Current: " + current + " of " + CardSort.Hearts);
                                            Console.ReadLine();
                                        }
                                        else if (color2 == 2)
                                        {
                                            Console.WriteLine("Player1 and Player2 guessed wrong!" + " Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + " Current: " + current + " of " + CardSort.Diamonds);
                                            Console.ReadLine();
                                        }
                                        else if (color2 == 3)
                                        {
                                            Console.WriteLine("Player1 and Player2 guessed wrong!" + " Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + " Current: " + current + " of " + CardSort.Spades);
                                            Console.ReadLine();
                                        }
                                        else if (color2 == 4)
                                        {
                                            Console.WriteLine("Player1 and Player2 guessed wrong!" + " Round: " + round);
                                            Console.WriteLine("Previous: " + previousCard + " Current: " + current + " of " + CardSort.Clover);
                                            Console.ReadLine();
                                        }
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
                        foreach (var item in tal)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();
                    }
                    else if (answer == 3)
                    {

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1.How to play");
                            Console.WriteLine("2. About Me");
                            Console.WriteLine("3. Exit");
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
                                        Environment.Exit(0);
                                        break;

                                }
                            }
                            catch
                            {
                                Console.WriteLine("1, 2, 3 are you stupid or something");
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

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
        static void Meny()
        {
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

                        Play();
                    }
                    else if (answer == 2)
                    {
                        //LeaderBoard();
                    }
                    else if (answer == 3)
                    {

                        Info();

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
        static void LeaderBoard(int point)
        {
            while (true)
            {
                List<int> scoreBoard = new List<int>();
                scoreBoard.Add(point);
                Console.Clear();
                Console.WriteLine("1. Highscore");
                Console.WriteLine("2. Go back");
                Console.WriteLine("3. Exit");
                Console.Write("Answer: ");
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            for (int i = 0; i < scoreBoard.Count; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    int value = scoreBoard.ElementAt(j);
                                    int value2 = scoreBoard.ElementAt(i);
                                    if (value > value2)
                                    {
                                        int temp = value;
                                        value = value2;
                                        value2 = temp;
                                    }
                                }
                            }
                            foreach (var item in scoreBoard)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 2:
                            Meny();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("1, 2, 3");
                }
                Console.ReadLine();
            }


        }
        static void Play()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. SinglePlayer");
                Console.WriteLine("2. 2 Players");
                Console.WriteLine("3. Go back");
                Console.WriteLine("4. Exit");
                Console.Write("Answer: ");
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            SinglePlayer();
                            break;
                        case 2:
                            TwoPlayers();
                            break;
                        case 3:
                            Meny();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("1, 2, 3 or 4 are you stupid or something");
                }
                Console.ReadLine();
            }
        }
        static void Info()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.How to play");
                Console.WriteLine("2. About Me");
                Console.WriteLine("3. Go back");
                Console.WriteLine("4. Exit");
                Console.Write("Answer: ");
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            HowToPlay();
                            break;
                        case 2:
                            About();
                            break;
                        case 3:
                            Meny();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("1, 2, 3 or 4 are you stupid or something");
                }
                Console.ReadLine();
            }

        }
        static void HowToPlay()
        {
            Console.Clear();
            Console.WriteLine("Spelet ”High or Low” använder en vanlig kortlek med 52 kort utan jokrar och hela kortleken används \nuppdelat i fyra omgångar (13 kort per omgång). Spelet börjar med att blanda kortleken och sedan i första omgång läggs ut 13 kort med baksidan upp, därefter vänds det första kortet. \nSen ska spelaren avgöra om nästa kort är högre eller lägre tills alla 13 kort är passerade. Man får en poäng för varje rätt gissning och klarar man alla gissningar vinner man 50 poäng extra. Gissar man fel sparas de rätta gissningarna för den omgången. Spelet fortsätter med nästa omgång med 13 kort från samma kortlek som är en upprepning av första omgången. Ess fungerar som trumf för spelaren d v s det är både högst och lägst. Spelaren förlorar dock om det blir par.");
            Console.WriteLine("Programmet ska kunna användas av minst två spelare och det ska finnas en ”Highscore” lista.");
            Console.ReadLine();
            Info();
        }
        static void About()
        {
            Console.Clear();
            Console.WriteLine("This is written by a passionat padawan programmer that idk dont give a shit");
            Console.ReadLine();
            Info();
        }


        static void SinglePlayer()
        {

            Console.Clear();
            string answer;
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



            while (true)
            {
                while (true)
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
                    if (cardsLeft == 0)
                    {
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

                                    LeaderBoard(points);
                                    break;
                                }
                                else if (saveScore == "no")
                                {
                                    Meny();
                                    break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("yes or no");
                            }
                        }
                    }

                    while (true)
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
                        answer = Console.ReadLine();
                        try
                        {
                            if (answer == "high" || answer == "low")
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
                    if (answer == "high" && current > previous)
                    {
                        points++;
                        Console.WriteLine("Cards left: {0}", cardsLeft + " Round: " + round);
                        Console.WriteLine("Points: " + points);

                    }
                    else if (answer == "low" && current < previous)
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
        static void TwoPlayers()
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

            bool p1 = false, p2 = false;

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


            while (true)
            {
                round++;
                cardsLeft -= 2;
                totalCards++;

                while (true)
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
                        Meny();
                    }

                    while (true)
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
                        while (true)
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


                        while (true)
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
        static void Main(string[] args)
        {
            Console.Title = "High or Low";
            Meny();
        }
    }
}

// See https://aka.ms/new-console-template for more information

using System;

namespace math_quizzer
{
    //Main program
    internal class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            GetAppinfo();

            Console.WriteLine("What is your name?");

            string customer_name = Console.ReadLine();

            Console.WriteLine("Hello! " + customer_name + " let's play math quiz...");
            while (true)
            {
                int score = 0;
                int total = 5;
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                for (int i = 0; i < total; i++)
                {
                    Random rand = new Random();
                    int number1 = rand.Next(1, 10);
                    int number2 = rand.Next(number1, 100);

                    int operation = rand.Next(1, 5);

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("Add the numbers: " + number2 + " and " + number1);
                            string ans = Console.ReadLine();
                            int ians = Convert.ToInt32(ans);
                            bool check = (ians == number2 + number1);
                            score = output(check, score, total);
                            break;
                        case 2:
                            Console.WriteLine("Subtract the numbers: " + number2 + " - " + number1);
                            string anss = Console.ReadLine();
                            int ianss = Convert.ToInt32(anss);
                            check = (ianss == number2 - number1);
                            score = output(check, score, total);
                            break;
                        case 3:
                            Console.WriteLine("Multiply the numbers: " + number2 + " * " + number1);
                            string ansm = Console.ReadLine();
                            int iansm = Convert.ToInt32(ansm);
                            check = (iansm == number2 * number1);
                            score = output(check, score, total);
                            break;
                        case 4:
                            Console.WriteLine("find the reminder: " + number2 + " / " + number1);
                            string ansd = Console.ReadLine();
                            int iansd = Convert.ToInt32(ansd);
                            check = (iansd == number2 % number1);
                            score = output(check, score, total);
                            break;
                    }
                }
                watch.Stop();
                var time_taken = watch.Elapsed;
                int time_elapsed = (time_taken.Minutes * 60) + time_taken.Seconds;
                Console.WriteLine("Your final score is {0}/{1}", score, total);
                Console.WriteLine("Time taken: {0} seconds", time_elapsed);
                Console.WriteLine("would you like to play again [Y or N]");
                string play_again = Console.ReadLine().ToUpper();
                if (play_again == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                Console.WriteLine("Let's go!");
            }
        }
        static void GetAppinfo()
        {
            //set app vars
            string appname = "Math quizzer";
            string appversion = "1.0";
            string appauthor = "Sid";

            //change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("{0}: version {1} by {2}", appname, appversion, appauthor);

            Console.ResetColor();
        }
        // Output statements for wrong answer
        static void wrong_answer(int score, int total)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Answer! your score is {0}/{1}", score, total);
            Console.ResetColor();
        }
        // Output statements for right answer
        static void right_answer(int score, int total)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Right Answer! your score is {0}/{1}", score, total);
            Console.ResetColor();
        }
        // Output interface function
        static int output(bool check, int score, int total)
        {
            if (check)
            {
                score += 1;
                right_answer(score, total);
            }
            else
            {
                wrong_answer(score, total);
            }
            return score;
        }
    }
}
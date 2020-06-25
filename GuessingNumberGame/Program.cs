using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think in a number and write it down in any piece of paper, i will guess it in few steps");
            Console.WriteLine("I will give you a number and you are gonna give some info");
            Console.WriteLine("If my guessing is correct then input  <Y> ");
            Console.WriteLine("If my guessing is wrong and your number is lower than the one I told  you. the input  <L>");
            Console.WriteLine("If my guessing is wrong and your number is lower than the one I told  you. the input  <H>");

            Console.WriteLine("Now to make this game more intreresting give me the limit number of the guessing");
            Console.WriteLine("for example you are gonna think  in a number beteween 1 and <The limit number>");

            Console.WriteLine(" So... Give me please the limit number, it can be as high as you want");

            var limitNumber = int.Parse(Console.ReadLine());
            var normalSteps = limitNumber;
            var startPoint = 0;
            var foundNumber = true;
            var myList = new List<int>();
            var repeatVariable = 1;


            Console.WriteLine($"Ok, so you want me to Guess a number between 1 and {limitNumber }");

            do
            {
                Console.WriteLine($"is your number :  {((limitNumber - startPoint)/2) + startPoint} ?");


                var userResponse = Console.ReadLine().ToLower();

                if (userResponse == "y")
                {
                    Console.WriteLine("I told you I was going to guess");
                    foundNumber = false;

                }else if(userResponse == "l")
                {
                  // myList.Add()
                    repeatVariable++;

                    if( limitNumber - startPoint > 1)
                    {
                        Console.WriteLine("Ok lets try again");
                        limitNumber = (limitNumber / 2) + (startPoint / 2);
                    }
                    else
                    {
                         Console.WriteLine($"is your number :  {limitNumber} ?");
                         userResponse = Console.ReadLine().ToLower();
                        while (userResponse != "y" )
                        {
                            limitNumber--;
                            repeatVariable++;

                        }
                        Console.WriteLine("I told you I was going to guess");
                        foundNumber = false;


                    }

                }

                else if (userResponse == "h")
                {
                    repeatVariable++;

                    if (limitNumber - startPoint > 1)
                    {
                        Console.WriteLine("Ok lets try again");
                        startPoint = ((limitNumber - startPoint) / 2) + startPoint;
                    }
                    else
                    {
                        Console.WriteLine($"is your number :  {limitNumber} ?");
                        userResponse = Console.ReadLine().ToLower();
                        while (userResponse != "y")
                        {
                            limitNumber++;
                            repeatVariable++;

                        }

                        Console.WriteLine("I told you I was going to guess");
                        foundNumber = false;


                    }

                }
                else
                {
                    Console.WriteLine("Sorry i dont get it");
                }
            } while (foundNumber );

            Console.WriteLine($"For a normal code it would take {normalSteps} steps, but for me it just took {repeatVariable}");
            Console.WriteLine("and that is cuz I am a TrueCoder ");

            

            




            
        }
    }
}

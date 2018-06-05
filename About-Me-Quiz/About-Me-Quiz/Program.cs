using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to the game
            Console.WriteLine("Welcome to my Guessing Game.");
            Console.WriteLine("I will ask you 5 questions about me and your try to answer them correctly!");
            Console.Write("Hit Enter to Play");
            Console.ReadLine();
            //Invoke the first question
            guessMyMiddleName();
            hitEnter();
            //Invoke the second question and save the returned string into colorResult
            string colorResult = guessFavoriteColor();
            Console.WriteLine(colorResult);
            hitEnter();
            //Invoke the third question and pass its returned bool to another method
            bool petResult = guessMyPets();
            showPetResult(petResult);
            hitEnter();
            //Invoke the fourth question
            int sibilingResult = guessMySibling();
            Console.WriteLine($"You think I have {sibilingResult}? I'm an only child.");
            hitEnter();
            //Invoke the last question
            guessMyBirthPlace();
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();

        }

        //the continue method that comes after each question. Also clears the terminal
        static void hitEnter()
        {
            Console.Write("Hit Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }

        static void guessMyMiddleName()
        {
            // Changes this flag to false when user inputs a viable answer which will stop the do while loop.
            bool flag = true;
            do
            {
                Console.Clear();
                //Prints Question to Console
                Console.WriteLine("Guess my Middle Name!");
                Console.WriteLine("1) Tanaka");
                Console.WriteLine("2) Katsumata");
                Console.WriteLine("3) William");
                //Reads the user's input and saves it
                string userAns = Console.ReadLine();
                //Checks the user input to see if it is correct 
                if (userAns == "2")
                {
                    Console.WriteLine("Correct!");
                    flag = false;
                }
                else if (userAns == "1" || userAns == "3")
                {
                    Console.WriteLine("Incorrect, it's actually Katsumata");
                    flag = false;
                }
                //Catch all 
                else
                {
                    Console.WriteLine("Please Answer 1, 2, or 3");
                    Console.ReadLine();
                }
            } while (flag);
        }
        
        //Question 2 that returns a srting. Return string depends on the correct answer.
        static string guessFavoriteColor()
        {
            Console.WriteLine("What is my favorite color?");
            string userAns = Console.ReadLine();
            if (userAns.ToLower() == "red")
            {
                return "Red IS my favorite color!";
            }
            else
            {
                return $"Sorry, {userAns} is not my favorite color";
            }
        }

        //Question 3 that returns a boolean depending on the correct answer
        static bool guessMyPets()
        {
            Console.WriteLine("Dog or Cat? Which do you think I own?");
            string userAns = Console.ReadLine();
            if (userAns.ToLower() == "dog")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Using the boolean returned by the guessMyPets method as an arguement, prints answer result on the terminal 
        static void showPetResult(bool doIPet)
        {
            if (doIPet == true)
            {
                Console.WriteLine("Yep! In fact, I own two dogs. Shiba and a Husky/Jindo mix");
            }
            else
            {
                Console.WriteLine("Nope, I have two doggos.");
            }
        }

        //Question 4 that returns the user input as an integer
        static int guessMySibling()
        {
            Console.WriteLine("How many siblings do you think I have?");
            string userAns = Console.ReadLine();
            //Parse the string into an int
            int userNum = Int32.Parse(userAns);
            return userNum;
        }

        static void guessMyBirthPlace()
        {
            Console.WriteLine("Where do you think I was born?");
            Console.WriteLine("1) Tokyo Japan");
            Console.WriteLine("2) Seattle WA");
            Console.WriteLine("3) Pittsburgh PA");
            Console.WriteLine("4) Denver Colorado");
            string userAns = Console.ReadLine();
            if (userAns == "3")
            {
                Console.WriteLine("Correct! I was born in Pittsburgh. GO STEELERS! lol jk I like SeaHawks more");
            }
            else if (userAns == "1" || userAns == "2" || userAns == "4")
            {
                Console.WriteLine("Incorrect, I was born in Pittsburgh.");
            }
            else
            {
                Console.WriteLine("Not a valid input");
            }
        }
    }
}

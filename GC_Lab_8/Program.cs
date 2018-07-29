using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GC_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Terrell");
            names.Add("Samantha");
            names.Add("Kristen");
            names.Add("Chris");
            names.Add("Ash");
            names.Add("Drew");
            names.Add("Terri");
            names.Add("Jacob");
            names.Add("Tesla");
            names.Add("Boi");
            names.Add("Austin Powers");
            names.Add("Chief QueeT");
            names.Add("Big Dog Bark");
            names.Add("21 Average");
            names.Add("What's your name again");
            names.Add("Zack");
            names.Add("Jesse");
            names.Add("Ray");
            names.Add("Bodum");
            names.Add("Patrick");
            List<string> homeTown = new List<string>();
            homeTown.Add("Detroit MI");
            homeTown.Add("Ann-Dan MI");
            homeTown.Add("Plaztic Beach");
            homeTown.Add("New Port Rhode Island ");
            homeTown.Add("Pallet Town");
            homeTown.Add("Break Yo Code Island");
            homeTown.Add("Detroit MI");
            homeTown.Add("Somewhere in Africa");
            homeTown.Add("Somewhere in Africa");
            homeTown.Add("Terrell's Mind");
            homeTown.Add("Great Britain");
            homeTown.Add("Sooo Close");
            homeTown.Add("Dog Island");
            homeTown.Add("Sound Cloud");
            homeTown.Add("Who cares");
            homeTown.Add("Detroit MI");
            homeTown.Add("Royal Oak. MI");
            homeTown.Add("Charlesville");
            homeTown.Add("Rock Heaven");
            homeTown.Add("Somewhere");
            List<string> favFood = new List<string>();
            favFood.Add("Hard Drugs");
            favFood.Add("Pizza");
            favFood.Add("Rice I think");
            favFood.Add("Tacos");
            favFood.Add("Tacos");
            favFood.Add("Happiness");
            favFood.Add("Coffee");
            favFood.Add("Powder");
            favFood.Add("Chicken");
            favFood.Add("Cheese Feet");
            favFood.Add("Hair");
            favFood.Add("inappropriate");
            favFood.Add("Dog Food");
            favFood.Add("Not Lyrics");
            favFood.Add("Who cares");
            favFood.Add("Face Cream");
            favFood.Add("Books");
            favFood.Add("Tacos");
            favFood.Add("Pasta");
            favFood.Add("Something");
            int input = GetVaildNumInput(@"^\d{1,2}", "Pick a number and learn about a person:");
            string ans = GetVaildInput(@"^[yY]|[nN]{1}$", $"You picked {names[input]}, would you like to learn more about this person(y/n)");
            if (ans.ToLower() == "y")
            {
                Console.WriteLine($"{names[input]} is from {homeTown[input]} and his or here favorite food is {favFood[input]} ");
            }
            ans = GetVaildInput(@"^[yY]|[nN]{1}$", "Would you like to add any more information about this student(y/n)");
            if (ans.ToLower() == "y")
            {
                AddFacts(@"^.{1,20}$", "Would you like to input information about the Favorite Color or about Their Favorite Number");
            }

        }
        public static int GetVaildNumInput(string pattern, string userMessage, string errorMessage = "Wrong Input Try Again")
        {
            Console.WriteLine(userMessage);
            string input = Console.ReadLine();
            while (!(Regex.IsMatch(input, pattern))|| int.Parse(input) > 20)
            {
                Console.WriteLine(errorMessage);
                input = Console.ReadLine();

            }

            return int.Parse(input);

        }
       public static string GetVaildInput(string pattern, string userMessage, string errorMessage = "Wrong Input Try Again")
        {
            Console.WriteLine(userMessage);
            string input = Console.ReadLine();
            while (!(Regex.IsMatch(input, pattern)))
            {
                Console.WriteLine(errorMessage);
                input = Console.ReadLine();

            }
            return input;
        }
        public static void AddFacts(string pattern, string userMessage, string errorMessage = "Wrong Input Try Again")
        {
            Console.WriteLine(userMessage);
            string input = Console.ReadLine();
            while (!(Regex.IsMatch(input, pattern)))
            {
                Console.WriteLine(errorMessage);
                input = Console.ReadLine();

            }
            int sum = 0;
            if (input.ToLower() == "favorite color" || input.ToLower() == "color")
            {
                List<string> favorColor = new List<string>();
                Console.WriteLine("Enter their favorite color:");
                favorColor.Add(Console.ReadLine());
                Console.WriteLine($"Their favorite color is {favorColor[0]}");
                sum += 1;
                string ans = GetVaildInput(@"^[yY]|[nN]{1}$", "Would you like to add any more information about this student's favorite number(y/n)");
                if (ans.ToLower() == "y")
                {
                    int inputnum = GetVaildNumInput(@"^\d{0,20}$", "What is their favorite number?");
                    Console.WriteLine($"Their favorite number is {inputnum}");
                }
            }
            else if (input.ToLower() == "favorite number" || input.ToLower() == "number")
            {
                List<string> favorNumber = new List<string>();
                Console.WriteLine("Enter their favorite number:");
                favorNumber.Add(Console.ReadLine());
                Console.WriteLine($"Their favorite number is {favorNumber[0]}");
                sum += 1;
                string ans = GetVaildInput(@"^[yY]|[nN]{1}$", "Would you like to add any more information about this student's favorite color(y/n)");
                if (ans.ToLower() == "y")
                {
                    int inputnum = GetVaildNumInput(@"^\d{1,20}$", "What is their favorite number?");
                    Console.WriteLine($"Their favorite number is {inputnum}");
                }
            }
        }
        
    }
}

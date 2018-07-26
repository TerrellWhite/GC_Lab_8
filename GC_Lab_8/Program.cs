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
            string [] names = { "Terrell", "Samantha", "Kristen", "Chris", "Ash", "Drew", "Terri", "Jacob", "Tesla", "Boi", "Austin Powers", "Chief QueeT", "Big Dog Bark", "21 Average", "What's your name again", "Zack", "Jesse","Ray","Bodum","Patrick" };
            string[] hometown = { "Detroit MI", "Ann-Dan MI", "Plaztic Beach", "New Port Rhode Island ", "Pallet Town", "Break Yo Code Island", "Detroit MI", "Somewhere in Africa", "Somewhere in Africa", "Terrell's Mind", "Great Britain", "Sooo Close", "Dog Island", "Sound Cloud", "Who cares", "Detroit MI", "Royal Oak. MI", "Charlesville", "Rock Heaven", "Somewhere" };
            string[] favFood = { "Hard Drugs", "Pizza", "Rice I think", "Tacos", "Tacos", "Happiness", "Coffee", "Powder", "Chicken", "Cheese Feet", "Hair", "inappropriate", "Dog Food", "Not Lyrics", "Who cares", "Face Cream", "Books", "Tacos", "Pasta", "Something" };
            int input = GetVaildNumInput(@"^\d{1,2}", "Pick a number and learn about a person:");
            string ans = GetVaildInput(@"^[yY]|[nN]{1}$", $"You picked {names[input]}, would you like to learn more about this person(y/n)");
            if (ans.ToLower() == "y")
            {
                Console.WriteLine($"{names[input]} is from {hometown[input]} and his or here favorite food is {favFood[input]} ");
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
    }
}

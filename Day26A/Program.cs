using System.Text.RegularExpressions;

namespace Day26A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string email = "abc@yahoo.com";

            if (Regex.IsMatch(email, @"^[a-zA-Z0-9@.]+$"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
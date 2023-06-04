﻿using System.Text.RegularExpressions;

namespace Day26A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string email = "abc111@abc.com";

            if (Regex.IsMatch(email, "^[a - zA - Z0 - 9._ % +-] +@[a - zA - Z0 - 9.-] +.[a-zA - Z]{ 2,4}$"))
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
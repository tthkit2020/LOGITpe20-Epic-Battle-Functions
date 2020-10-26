using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = {"Voldemort", "Darth Vader", "Sauron", "Joker", "Harley Quinn"};

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            
                       
            int heroHP = GenerateHP();
            int villainHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} HP will fight {villain} " +
                $"{villainHP} HP");

            while(heroHP > 0 && villainHP > 0)
            {
                //Random rnd = new Random();
                //heroHP = heroHP - rnd.Next(0, 4);
                //villainHP = villainHP - rnd.Next(0, 4);
                heroHP = heroHP - Hit(hero);
                villainHP = villainHP - Hit(villain);
            }

            if(heroHP == 0)
            {
                Console.WriteLine("Dark Side wins!");
            } else
            {
                Console.WriteLine($"{hero} saves the day!");
            }
        }

        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }

        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }

        public static int Hit(string character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");
            if(strike == 4)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit!");
            } else if(strike == 0)
            {
                Console.WriteLine($"Bad luck! {character} missed the target!");
            }
            return strike;
        }
        
    }
}

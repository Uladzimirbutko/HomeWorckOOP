using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Homework_Candy_Present 
{
    class Program 
    {
         static void Main(string[] args) 
         {
            Console.WriteLine("Hello! You got into the program for choosing a New Year's gift.");
            Present();
            SortCandy();
         }

        private static void SortCandy() 
        {
            var candyList = new List<Candy> 
            {
                new KitKat ("KitKat", weight: 45, sugar: Math.Round(27.9/0.45,2)),
                new ChocoPie("ChocoPie", weight: 28, sugar: Math.Round(22.12/0.28,2)),
                new Snickers("SNICKERS", weight: 18, sugar: Math.Round(10.12/0.18,2)),
                new Twix("TWIX minis",weight:10,sugar:Math.Round(6.5/0.1,2)),
                new CrazyBee("Crazy Bee", weight:7, sugar:Math.Round(5.55/0.07,2))
            };

            
            foreach (var result in candyList) 
            {
                    if (result.Sugar > 70) 
                    {
                        Console.WriteLine($"Sugar content more 70g.: {result.Name} {result.Sugar}g.");
                    }
            }

            Console.WriteLine("Sorting the list by candy name.");
            var resultName = from candySort in candyList
                orderby candySort.Name
                select candySort;
            foreach (var u in resultName)
            {
                Console.WriteLine($" {u.Name} \t {u.Weight} \t {u.Sugar}");
            }

            Console.WriteLine("Sorting the list by candy weight.");
            var resultWeight = from candySort in candyList
                orderby candySort.Weight
                select candySort;
            foreach (var u in resultWeight) 
            {
                Console.WriteLine($" {u.Name} \t {u.Weight} \t {u.Sugar}");
            }

            Console.WriteLine("Sorting the list by candy sugar content per 100g.");
            var resultSugar = from candySort in candyList
                orderby candySort.Sugar
                select candySort;
            foreach (var u in resultSugar) 
            {
                Console.WriteLine($" {u.Name} \t {u.Weight} \t {u.Sugar}");
            }
        }

        private static void Present() {
            var candy = new Candy[5];
            candy[0] = new KitKat("KitKat ", weight: 45, sugar: 27.9);
            candy[1] = new ChocoPie("ChocoPie", weight: 28, sugar: 22.12);
            candy[2] = new Snickers("SNICKERS", weight: 18, sugar: 10.12);
            candy[3] = new Twix("TWIX minis", weight: 10, sugar: 6.5);
            candy[4] = new CrazyBee("Crazy Bee", weight: 7, sugar: 5.55);

            Console.WriteLine("Your gift contains:");
            Console.WriteLine($" {candy[0].Name} \tWeight: {candy[0].Weight}гр. \tSugar content in one candy: {candy[0].Sugar}g.");
            Console.WriteLine($" {candy[1].Name} \tWeight: {candy[1].Weight}гр. \tSugar content in one candy: {candy[1].Sugar}g.");
            Console.WriteLine($" {candy[2].Name} \tWeight: {candy[2].Weight}гр. \tSugar content in one candy: {candy[2].Sugar}g.");
            Console.WriteLine($" {candy[3].Name} \tWeight: {candy[3].Weight}гр. \tSugar content in one candy: {candy[3].Sugar}g.");
            Console.WriteLine($" {candy[4].Name} \tWeight: {candy[4].Weight}гр. \tSugar content in one candy: {candy[4].Sugar}g.");
            Console.WriteLine("We have 3 gifts for you:\n 1 - 300g.\n 2 - 500g.\n 3 - 1000g.");
            try {
                var input = int.Parse(Console.ReadLine() ?? string.Empty);
                switch (input) {
                    case 1: {
                        Boxing();
                        Console.WriteLine($"In the gift: 1 - {candy[0].Name}, 3 - {candy[1].Name}, 3 - {candy[2].Name}, 4 - {candy[3].Name}, 11 - {candy[4].Name}. The gift weight 300g.");
                        break;
                    }
                    case 2: {
                        Boxing();
                        Console.WriteLine($"In the gift: 3 - {candy[0].Name}, 5 - {candy[1].Name}, 6 - {candy[2].Name}, 4 - {candy[3].Name}, 11 - {candy[4].Name}. The gift weight 500g.");
                        break;
                    } 
                    case 3: {
                        Boxing();
                        Console.WriteLine($"In the gift: 5 - {candy[0].Name}, 10 - {candy[1].Name}, 10 - {candy[2].Name}, 14 - {candy[3].Name}, 25 - {candy[4].Name}. The gift weight 1000g.");
                        break;
                    } 
                    default: {
                        Console.WriteLine("The input was entered incorrect. Try again.");
                        Present();
                        break;
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"{ex.Message}. Please try again");
                Present();
            }
        }

        private static void Boxing() 
        {
                Console.WriteLine("Wait - the elves to collect your gift");
                for (int i = 0; i < 101; i++) 
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("Collected " +i);
                    Thread.Sleep(10);
                }
                Console.WriteLine("\nYour gift is collected!");
        }
    }

    
}


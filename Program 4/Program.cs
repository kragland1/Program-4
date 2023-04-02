// Grading ID: R2226
// Program 4
// Due: 4/18/22
// CIS 199 - 02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    internal class Program
    {
        // PreCondition: None
        // PostCondition: Creating many superhero objects using the Superhero class structure.
        static void Main(string[] args)
        {
            //creating the superhero objects.
            Superhero superhero1 = new Superhero("Batman", "Gotham City", "Expert Martial Artist", "Genius", 1939); //  Batman Information
            Superhero superhero2 = new Superhero("Spider-Man", "Queens, New York City", "Super Strength", "Wall Crawling Ability", 1962); // Spider-Man information
            Superhero superhero3 = new Superhero("Daredevil", "Hells Kitchen, New York City", "Enhanced Senses", "Great Martial Artist", 1964); // Daredevil information
            Superhero superhero4 = new Superhero("Superman", "Krypton", "Super Strength", "Super Speed", 1938); // Superman Information
            Superhero superhero5 = new Superhero("The Flash", "Central City", "Super Speed", "Super Speed Thinking", 1940); // The Flash Information

            superhero4.FirstSuperPower = "Heat Vision"; // This is set here to hard code the first superpower for the Superman object/
            superhero5.OnPlanetEarth(); // Used to change the information for "The Flash" information to say that he is on earth.
            superhero3.OnPlanetEarth(); // Used to change the information for the "Daredevil" information to say that he is on earth.

            // created a 5 element Superhero array.
            Superhero[] superheroes = new Superhero[5];
            
            //initializing the array with the types that was decalred for the objects.
            superheroes[0] = superhero1;
            superheroes[1] = superhero2;
            superheroes[2] = superhero3;
            superheroes[3] = superhero4;
            superheroes[4] = superhero5;

            PrintSuperHero(superheroes); // calls the array and outputs it the way that the PrintSuperHero method organized the data.

        }
        //PreCondition: None
        //PostCondition: Used to print the information from the array using a static void print method and a foreach loop.
        public static void PrintSuperHero(Superhero[] superheroes)
        {
            // Processes each element in the array with a loop
            foreach (Superhero hero in superheroes)
            {
                WriteLine($"{hero}"); // calls on the ToString from the Superhero class to the main one.
            }
        }
        
    }
}

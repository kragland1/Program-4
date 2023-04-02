using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class Superhero
    {
        private int year;// From the year 0 to beyond.

        bool _PlanetEarth;// A bool operator for whether a hero is on the planet earth or not.

        // PreCondition: None
        // PostCondition: The _supername string has been returned.
        public string SuperheroName { get; set; } // PreCondition: None; PostCondition: The _supername string is set to the value specified

        // PreCondition: None
        // PostCondition: The _birthCity string has been returned.
        public string BirthCity { get; set; } // PreCondition: None; PostCondition: The _birthCity string is set to the value specified

        // PreCondition: None
        // PostCondition: The second string has been returned.
        public string SecondSuperPower { get; set; } // PreCondition: None; PostCondition: The second string is set to the value specified

        // PreCondition: None
        // PostCondition: The first string has been returned.
        public string FirstSuperPower { get; set; } // PreCondition: None; PostCondition: The first string is set to the value specified

        // PreCondtion: None
        // PostCondition: The Superhero is made using objects that provide the specified name, birth city, first superpower, second superpower and the year that superhero was created.
        public Superhero(string _supername, string _birthCity, string first, string second, int year)
        {
            SuperheroName = _supername; // Set using the SuperheroName property
            BirthCity = _birthCity; // Set using the BirthCity property
            FirstSuperPower = first; // Set using the FirstSuperPower property
            SecondSuperPower = second; // Set using the SecondSuperPower property
            BirthYear = year; // Set using the BirthYear property
        }

        // PreCondition: None
        // PostCondition: The Initial Property uses the SuperheroName property value and chooses the first initial of the string name.
        public char Initial
        {
            get { return SuperheroName[0]; } // This will return the Superhero Name's first initial.
        }

        public const int Default = 1999; // This sets a default integer for 1999

        public int BirthYear
        {
            // PreCondition: None
            // PostCondition: Returns the year
            get { return year; }

            // PreCondition: 0 <= value 
            // PostCondition: The year has been set to the specified value.
            set
            {
                if (value >= 0)
                {
                    year = value;
                }
                else //When the value is not greater than 0 or it is not a number then set the Default to 1999.
                {
                    year = Default;
                }
            }
        }

        //PreCondition: None
        //PostCondition: Makes the _PlanetEarth bool variable true if the superhero is declared to be On Earth.
        public void OnPlanetEarth()
        {
            _PlanetEarth = true;
        }

        // PreCondition: None
        // PostCondition: Makes the _PlanetEarth bool variable false if the superhero is declared to not be on Earth.
        public void OffPlanetEarth()
        {
            _PlanetEarth = false;
        }

        //PreCondition: None
        //PostCondition: Returns the bool _PlanetEarth
        public bool IsOnPlanetEarth()
        {
            return _PlanetEarth;
        }

        //PreCondition: None
        //PostCondition: Returns the superhero information as a formatted string.
        public override string ToString()
        {
            string NL = Environment.NewLine;// This is used to create a line for each string.
            return $"Name: {SuperheroName} {NL}" + $"City: {BirthCity} {NL}" + $"First Super Power: {FirstSuperPower} {NL}" + $"Born in: {BirthYear} {NL}" + $"Second Super Power: {SecondSuperPower} {NL}" + $"Planet Earth: {_PlanetEarth} {NL}" + $"Initial: {Initial} {NL}";
        }
    }
}

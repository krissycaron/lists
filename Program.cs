using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the method list of type = string
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
        
            List<string> planetList2 = new List<string>(){"Neptune", "Uranus"};
            
            planetList.AddRange(planetList2);
            // everytime you want to console you must forEach over the data you want printed out. 
                planetList.Insert(1,"Venus");
                planetList.Insert(3,"Earth");
                planetList.Insert(8,"Pluto");
            foreach(string planetsPrinting in planetList){
                // Console.WriteLine(planetsPrinting);
            }
            //must print out the string of "rocky Planet" in the rocky planets list
            List<string> rockyPlanets = planetList.GetRange(0,4);
            foreach(string rockyPlanet in rockyPlanets){
                Console.WriteLine(rockyPlanet);
            }
        }
    }
}

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
        
            List<string> planetList2 = new List<string>(){"neptune", "uranus"};
            
            planetList.AddRange(planetList2);
            
            foreach(string planetsPrinting in planetList){
                Console.WriteLine(planetsPrinting);
            }


        }
    }
}

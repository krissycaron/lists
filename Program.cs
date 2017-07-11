using System;

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

        }
    }
}

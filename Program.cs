using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>()
      { "Mercury",
        "Mars"
       };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");



      List<string> twoPlanets = new List<string>()
    { "Uranus",
       "Venus"
    };
      planetList.AddRange(twoPlanets);

      planetList.Insert(0, "Earth");


      planetList.Add("Pluto");
      List<string> rockyList = planetList.GetRange(1, 3);


      //   rockyList.ForEach(planet => Console.WriteLine(planet));
      planetList.Remove("Pluto");
      planetList.ForEach(planet => Console.WriteLine(planet));

    }



  }
}

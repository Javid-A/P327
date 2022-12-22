using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Delegates
{
    internal class Country
    {
        public string Name;
        public int TotalPopulation { get=> TotalPopulations(); }

        public City[] Cities;

        public Country(string name)
        {
            Name = name;
            Cities = Array.Empty<City>();
        }

        public City[] FindAllByPopulation(int min, int max)
        {
            City[] cities = Array.Empty<City>();
            foreach (City city in Cities)
            {
                if(city.Population>=min && city.Population <= max)
                {
                    Array.Resize(ref cities, cities.Length + 1);
                    cities[cities.Length - 1] = city;
                }
            }
            return cities;
        }

        public void Add(City city)
        {
            Array.Resize(ref Cities, Cities.Length + 1);
            Cities[Cities.Length - 1] = city;
        }

        public int TotalPopulations()
        {
            int result=default;
            foreach (var item in Cities)
            {
                result += item.Population;
            }
            return result;
        }
    }
}

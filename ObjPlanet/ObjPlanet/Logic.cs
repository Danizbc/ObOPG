using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjPlanet
{
    class Logic
    {
        
        List<Planet> planetLists = new List<Planet>();
        List<Planet> planetDiameters = new List<Planet>();

        Planet planet = new Planet(1);



        public List<Planet> PlanetLists
        {
            get { return planetLists; }
            set
            {
                planetLists = value;
            }
        }

        public List<Planet> PlanetDiameters
        {
            get { return planetDiameters; }
            set
            {
                PlanetDiameters = value;
            }
        }
        
        //Constructor
        public Logic()
        {
            for (int i = 0; i < planet.PlanetNames.Count; i++)
            {
                planetLists.Add(planet = new Planet(i));
            }
        }


        //Methods

        //add planet with default value.
        public void AddPlanet()
        {
            planetLists.Add(planet = new Planet());
        }

        //removing planet
        public bool RemovePlanet(int id)
        {
            try
            {
                planetLists.RemoveAt(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //get all planets within wished diameters
        public void Diameter()
        {
            for (int i = 0; i < planetLists.Count; i++)
            {
                if (planetLists[i].Diameter > 10000 && planetLists[i].Diameter < 50000)
                {
                    planetDiameters.Add(planetLists[i]);
                }
            }

        }



    }
}

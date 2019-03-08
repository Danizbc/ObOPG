using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjPlanet
{
    class Planet
    {
        //Attribute
        private string name;
        private List<string> planetNames = new List<string> {"Mecury","Venus","Earth","Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDays;
        private double distanceToSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemparature;
        private int numberOfMoons;
        private bool ringSystem;



       //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<string> PlanetNames
        {
            get { return planetNames; }
            set
            {
                planetNames = value;
            }
        }

        public double Mass
        {
            get { return mass; }
            set
            {
                mass = value;
            }
        }

        public double Diameter
        {
            get { return diameter; }
            set
            {
                diameter = value;
            }
        }

        public double Density
        {
            get { return density; }
            set
            {
                density = value;
            }
        }

        public double Gravity
        {
            get { return gravity; }
            set
            {
                gravity = value;
            }
        }

        public double RotationPeriod
        {
            get { return rotationPeriod; }
            set
            {
                rotationPeriod = value;
            }
        }

        public double LengthOfDays
        {
            get { return lengthOfDays; }
            set
            {
                lengthOfDays = value;
            }
        }

        public double DistanceToSun
        {
            get { return distanceToSun; }
            set
            {
                distanceToSun = value;
            }
        }

        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set
            {
                orbitalPeriod = value;
            }
        }

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set
            {
                orbitalVelocity = value;
            }
        }

        public double MeanTemparature
        {
            get { return meanTemparature; }
            set
            {
                meanTemparature = value;
            }
        }

        public int NumberOfMoons
        {
            get {return numberOfMoons; }
            set
            {
                numberOfMoons = value;
            }
        }

        public bool RingSystem
        {
            get { return ringSystem; }
            set
            {
                ringSystem = value;
            }
        }


        //Constructors
        public Planet()
        {
            Name = "";
            Mass = 0 ;
            Diameter = 0;
            Density = 0;
            Gravity = 0;
            RotationPeriod = 0;
            LengthOfDays = 0;
            DistanceToSun = 0;
            OrbitalPeriod = 0;
            OrbitalVelocity = 0;
            MeanTemparature = 0;
            NumberOfMoons = 0;
            RingSystem = false;
        }

        public Planet(int id)
        {
            Name = planetNames[id];

            switch (id)
            {
                case 0:
                    Mass = 0.330;
                    Diameter = 4879;
                    Density = 5427;
                    gravity = 3.7;
                    RotationPeriod = 1407.6;
                    LengthOfDays = 4222.6;
                    DistanceToSun = 57.9;
                    OrbitalPeriod = 88.0;
                    OrbitalVelocity = 47.6;
                    MeanTemparature = 167;
                    NumberOfMoons = 0;
                    RingSystem = false;     

                    break;

                case 1:
                    Mass = 4.87;
                    Diameter = 12104;
                    Density = 5243;
                    gravity = 8.9;
                    RotationPeriod = -5832.5;
                    LengthOfDays = 2802.0;
                    DistanceToSun = 108.2;
                    OrbitalPeriod = 224.7;
                    OrbitalVelocity = 35.0;
                    MeanTemparature = 464;
                    NumberOfMoons = 0;
                    RingSystem = false;
                    break;

                case 2:
                    Mass = 5.97;
                    Diameter = 12756;
                    Density = 5514;
                    gravity = 9.8;
                    RotationPeriod = 23.9;
                    LengthOfDays = 24.0;
                    DistanceToSun = 149.6;
                    OrbitalPeriod = 365.2;
                    OrbitalVelocity = 29.8;
                    MeanTemparature = 15;
                    NumberOfMoons = 1;
                    RingSystem = false;
                    break;

                case 3:
                    Mass = 0.642;
                    Diameter = 6792;
                    Density = 3933;
                    gravity = 3.7;
                    RotationPeriod = 24.6;
                    LengthOfDays = 24.7;
                    DistanceToSun = 227.9;
                    OrbitalPeriod = 687.0;
                    OrbitalVelocity = 24.1;
                    MeanTemparature = -65;
                    NumberOfMoons = 2;
                    RingSystem = false;
                    break;

                case 4:
                    Mass = 1898;
                    Diameter = 142984;
                    Density = 1326;
                    gravity = 23.1;
                    RotationPeriod = 9.9;
                    LengthOfDays = 9.9;
                    DistanceToSun = 778.6;
                    OrbitalPeriod = 4331;
                    OrbitalVelocity = 13.1;
                    MeanTemparature = -110;
                    NumberOfMoons = 67;
                    RingSystem = true;
                    break;

                case 5:
                    Mass = 568;
                    Diameter = 120536;
                    Density = 687;
                    gravity = 9.0;
                    RotationPeriod = 10.7;
                    LengthOfDays = 10.7;
                    DistanceToSun = 1433.5;
                    OrbitalPeriod = 10747;
                    OrbitalVelocity = 9.7;
                    MeanTemparature = -140;
                    NumberOfMoons = 62;
                    RingSystem = true;
                    break;

                case 6:
                    Mass = 86.8;
                    Diameter = 51118;
                    Density = 1271;
                    gravity = 8.7;
                    RotationPeriod = -17.2;
                    LengthOfDays = 17.2;
                    DistanceToSun = 2872.5;
                    OrbitalPeriod = 30589;
                    OrbitalVelocity = 6.8;
                    MeanTemparature = -195;
                    NumberOfMoons = 27;
                    RingSystem = true;
                    break;

                case 7:
                    Mass = 102;
                    Diameter = 49528;
                    Density = 1638;
                    gravity = 11.0;
                    RotationPeriod = 16.1;
                    LengthOfDays = 16.1;
                    DistanceToSun = 4495.1;
                    OrbitalPeriod = 59.8;
                    OrbitalVelocity = 5.4;
                    MeanTemparature = -200;
                    NumberOfMoons = 14;
                    RingSystem = true;
                    break;

                case 8:
                    Mass = 0.0146;
                    Diameter = 2370;
                    Density = 2095;
                    gravity = 0.7;
                    RotationPeriod = -153.3;
                    LengthOfDays = 153.3;
                    DistanceToSun = 5906.4;
                    OrbitalPeriod = 90.56;
                    OrbitalVelocity = 4.7;
                    MeanTemparature = -220;
                    NumberOfMoons = 5;
                    RingSystem = false;
                    break;



                default:
                    break;
            }
        }

        //Method
        public string PrintPlanetInfo()
        {

            return $"Name = {Name}\n" +
                $"Mass = {Mass}\n" +
                $"Diameter = {Diameter}\n" +
                $"Density = {Density}\n" +
                $"Gravity = {Gravity}\n" +
                $"Rotation period = {RotationPeriod}\n" +
                $"Day length = {LengthOfDays}\n" +
                $"Distance to sun = {DistanceToSun}\n" +
                $"Orbital period = {OrbitalPeriod}\n" +
                $"Mean temparature = {MeanTemparature}\n" +
                $"Number of moons = {numberOfMoons}\n" +
                $"Ring system = {RingSystem.ToString()}\n" +
                $"Press any key to continue";
        }

        
    }
}

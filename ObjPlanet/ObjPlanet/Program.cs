using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            //attribute
            bool runWhileTrue = true;

            Logic logic = new Logic();




            while (runWhileTrue == true)
            {
                Console.Clear();
                Console.WriteLine("Press [0] add planet\nPress [1] to delete planet \nPress [2] Print planet info\nPress [3] for planets within 10k-50k Diameters5\nPress [X] to exit.");
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();

                /*
                 * Case 0 adding planets
                 * case 1 deleting planets
                 * case 2 print out planet info
                 * case 3 print all planets within 10k-50k
                 * case x exiting application
                 */
                switch (char.ToLower(input.KeyChar))
                {
                    case '0':
                        try
                        {


                            logic.AddPlanet();

                            Console.Write("Now we need to input some data.\nFirst give your planet a name.\nName : ");
                            logic.PlanetLists.Last().Name = Console.ReadLine();

                            Console.Write("input Diameter : ");
                            logic.PlanetLists.Last().Diameter = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input Density : ");
                            logic.PlanetLists.Last().Density = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input Gravity : ");
                            logic.PlanetLists.Last().Gravity = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input RotationPeriod : ");
                            logic.PlanetLists.Last().RotationPeriod = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input LengthOfDays : ");
                            logic.PlanetLists.Last().LengthOfDays = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input DistanceToSun : ");
                            logic.PlanetLists.Last().DistanceToSun = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input OrbitalPeriod : ");
                            logic.PlanetLists.Last().OrbitalPeriod = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input OrbitalVelocity : ");
                            logic.PlanetLists.Last().OrbitalVelocity = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input MeanTemparature : ");
                            logic.PlanetLists.Last().MeanTemparature = Convert.ToDouble(Console.ReadLine());

                            Console.Write("input NumberOfMoons : ");
                            logic.PlanetLists.Last().NumberOfMoons = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Does it have Ring system?\nPress [Y] for yes\nPress [N] for no");

                            ConsoleKeyInfo inputtwo = Console.ReadKey();
                            switch (char.ToLower(inputtwo.KeyChar))
                            {
                                case 'y':
                                    logic.PlanetLists.Last().RingSystem = true;
                                    break;

                                case 'n':
                                    logic.PlanetLists.Last().RingSystem = false;
                                    break;

                                default:
                                    logic.PlanetLists.Last().RingSystem = false;
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case '1':
                        Console.WriteLine("Write id of the planet you want to delete");
                        for (int i = 0; i < logic.PlanetLists.Count; i++)
                        {
                            Console.WriteLine($"id = {i} Name = {logic.PlanetLists[i].Name} ");
                        }

                        int removeID = Convert.ToInt32(Console.ReadLine());

                        if (logic.RemovePlanet(removeID) == true)
                        {
                            Console.WriteLine("Planet removed");
                        }
                        else
                        {
                            Console.WriteLine("Wrong input try again");
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;


                    case '2':
                        try
                        {
                            Console.Write("Print info about planets.\n");
                            for (int i = 0; i < logic.PlanetLists.Count; i++)
                            {
                                Console.WriteLine($"Write [{i}] {logic.PlanetLists[i].Name} info ");
                            }
                            Console.Write("Write -1 to exit\nWrite : ");

                            int temp = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            if (temp == -1)
                            {

                            }
                            else
                            {
                                Console.WriteLine(logic.PlanetLists[temp].PrintPlanetInfo());
                                Console.ReadKey();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                            Console.ReadKey();
                        }
                        break;

                    case '3':
                        try
                        {
                            logic.Diameter();

                            Console.Write("Print info about planets.\n");
                            for (int i = 0; i < logic.PlanetDiameters.Count; i++)
                            {
                                Console.WriteLine($"Write [{i}] {logic.PlanetDiameters[i].Name} info ");
                            }
                            Console.Write("Write -1 to exit\nWrite : ");

                            int temp = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            if (temp == -1)
                            {

                            }
                            else
                            {
                                Console.WriteLine(logic.PlanetDiameters[temp].PrintPlanetInfo());
                                Console.ReadKey();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                            Console.ReadKey();
                        }
                        break;

                    case 'x':
                        runWhileTrue = false;
                        break;

                    default:

                        break;
                }
            }
        }
    }
}

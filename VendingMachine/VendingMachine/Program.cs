using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Figgle;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //it will save file into default location


            //Attributes
            bool poweringOn = true;
            bool adminLogin = false;
            string loginPass = "";
            int timer = 0;
            int productID = 0;
            int userMoney = 0;

            //object
            VendingMachine vending = new VendingMachine();

            //thread run until true, fun powering on display, u can outcomment it to test faster.
            Console.WriteLine(FiggleFonts.Small.Render("Powering on"));
            string testing = FiggleFonts.KeyboardSmall.Render(".");

            

            while (poweringOn)
            {
               
                Console.Write($"| ____   ____   ____   ____   ____   ____ | {timer}% \n");
                timer += 20;
                Thread.Sleep(100);
                if (timer >= 101)
                {
                    poweringOn = false;
                }

            }
            Console.Clear();
            //loggin in as admin first time
            Console.Write(FiggleFonts.Doom.Render("Vending is ready\n") + "Enter password) for Admin or enter no code and press enter for user option.\n\nWrite password : ");
            loginPass = Console.ReadLine();
            if (loginPass == vending.Pass)
            {
                adminLogin = true;

                while (adminLogin == true)
                {
                    //giving user input then run that option in vending.adminmenu got try catch to catch fails
                    Console.Clear();
                    Console.WriteLine(vending.PrintAdminMenu());
                    ConsoleKeyInfo input = Console.ReadKey();
                    Console.Clear();
                    switch (char.ToLower(input.KeyChar))
                    {
                        case 'x':
                            Console.WriteLine(vending.AdminMenu(input.KeyChar, 0, 0));

                            break;

                        case 'z':
                            try
                            {
                                Console.WriteLine(vending.AdminMenu(input.KeyChar, 0, 0));
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message);
                            }
                            break;

                        case 'c':

                            try
                            {
                                Console.WriteLine(vending.PrintProducts());

                                Console.Write("Input ID of product you want to change price on.\n" +
                                    "input :  ");
                                productID = Int32.Parse(Console.ReadLine());

                                Console.Write("Input new price.\n" +
                                              "input : ");
                                userMoney = Int32.Parse(Console.ReadLine());

                                Console.WriteLine(vending.AdminMenu(input.KeyChar, userMoney, productID));

                            }
                            catch (FormatException e)
                            {

                                Console.WriteLine(e.Message);
                            }


                            break;

                        case 'l':
                            adminLogin = false;
                            break;

                        case 'p':
                            Console.WriteLine(vending.PrintProducts());

                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }

                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                }



            }
            //User menu buy product, return money, if not enough money return money, and u can start all over .
            while (true)
            {
                productID = 99;
                userMoney = 1000;
                try
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Doom.Render("Vending Menu"));
                    Console.Write(vending.PrintProducts() + "" +
                        "Input product number : ");

                    productID = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine(vending.PrintOneP(productID));

                    Console.Write("Input money now.\n" +
                                  "Input : ");

                    userMoney = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine($"Are you sure you want to buy\n{vending.PrintOneP(productID)}\n" +
                                 $"Press [Y] to buy.\n" +
                                 $"Press [N] to cancel.");

                    ConsoleKeyInfo input = Console.ReadKey();

                    Console.Clear();

                    if (char.ToLower(input.KeyChar) == 'y')

                    {
                        Console.WriteLine(vending.VendingMenu('c', productID, userMoney, loginPass));
                    }
                    else
                    {
                        Console.WriteLine($"Money returned = {userMoney}.");
                    }
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
        }
    }
}

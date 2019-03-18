using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine
{
    class VendingMachine
    {
        //Attribute

        private Candy candy;
        private Drink drink;
        private Product temp;
        private SafeBox safeBox = new SafeBox();

        private Stack<Product> slots;
        private List<Stack<Product>> vendingSlots = new List<Stack<Product>>();
        private List<Candy> removedCandies = new List<Candy>();
        private List<Drink> removedDrinks = new List<Drink>();

        private int moneyBox = 0;
        private int returnMoney = 0;
        private bool buyCompletet = false;
        private string returnString = "";
        private string pass = "adminadminadmin";


        //Properties
        public string Pass
        {
            get
            {
                return pass;
            }
        }

        //Constructor
        public VendingMachine()
        {
            for (int i = 0; i < 6; i++)
            {
                vendingSlots.Add(slots = new Stack<Product>());
            }
            FillProduct();

        }


        //Methods

        /// <summary>
        /// Input ProductNumber 0-1-2 candy. 3-4-5 drinks
        /// </summary>
        /// <param name="productNumber"></param>
        /// <returns></returns>
        private string PushProduct(int productNumber, int money)
        {
            PickProduct(productNumber);

            InsertCoin(money);

            if (buyCompletet == true)
            {
                switch (temp.ID)
                {
                    case 0:
                        removedCandies.Add((Candy)temp);
                        break;

                    case 1:
                        removedDrinks.Add((Drink)temp);
                        break;
                    default:
                        break;
                }
                return $"You bought {temp.Name}.\n" +
                       $"Money returned = {returnMoney}";
            }
            else
            {
                return "You didnt have enough money, insert more or pick another product";
            }
        }
        /// <summary>
        /// requirres money, if money is bigger than temp price then calculate and return money, save spend money into moneybox
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        private int InsertCoin(int money)
        {
            if (temp.Price <= money)
            {
                returnMoney = money -= temp.Price;

                moneyBox += temp.Price;

                buyCompletet = true;

                return returnMoney;
            }
            else
            {
                buyCompletet = false;
                return money;
            }
        }

        /// <summary>
        /// 0-2 candy.. 3-5 soda
        /// </summary>
        /// <param name="product"></param>
        private int PickProduct(int product)
        {
            if (vendingSlots[product].Peek().ID == 0)
            {
                candy = (Candy)vendingSlots[product].Pop();
            }
            temp = vendingSlots[product].Pop();

            return temp.Price;
        }

        /// <summary>
        /// Empy the all stacks in the list and add 5 new product in each stack
        /// </summary>
        private void FillProduct()
        {
            EmptyVending();

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int cpCount = 0; cpCount < 5; cpCount++)
                        {
                            vendingSlots[0].Push(candy = new Candy("Chocolate Platypus", 10, "Xl"));
                        }
                        break;

                    case 1:
                        for (int fbCount = 0; fbCount < 5; fbCount++)
                        {
                            vendingSlots[1].Push(candy = new Candy("Foam banana", 5, "Xl"));
                        }
                        break;

                    case 2:
                        for (int fdCount = 0; fdCount < 5; fdCount++)
                        {
                            vendingSlots[2].Push(candy = new Candy("Foam Duck", 15, "Giant"));
                        }
                        break;

                    case 3:
                        for (int clCount = 0; clCount < 5; clCount++)
                        {
                            vendingSlots[3].Push(drink = new Drink("Cola", 10, 0.5));
                        }
                        break;

                    case 4:
                        for (int ftcount = 0; ftcount < 5; ftcount++)
                        {
                            vendingSlots[4].Push(drink = new Drink("Fanta", 10, 0.5));
                        }
                        break;
                    case 5:
                        for (int fbdCount = 0; fbdCount < 5; fbdCount++)
                        {
                            vendingSlots[5].Push(drink = new Drink("Foam Banana Drink", 15, 0.5));
                        }
                        break;


                    default:

                        break;
                }
            }
        }

        /// <summary>
        /// Empty vending machine clearing all stacks
        /// </summary>
        private void EmptyVending()
        {
            for (int i = 0; i < vendingSlots.Count; i++)
            {

                vendingSlots[i].Clear();

            }
        }

        /// <summary>
        /// input product id and price, adjust all products of that type price
        /// </summary>
        /// <param name="product"></param>
        /// <param name="newprice"></param>
        /// <returns></returns>
        private string ChangePrice(int product, int newprice)
        {
            string tempName = "";

            foreach (Product item in vendingSlots[product])
            {
                item.Price = newprice;
                tempName = item.Name;
            }

            return $"All {tempName} price has been chanced to {newprice}";
        }

        /// <summary>
        /// Check if list is empty if it is return fall
        /// </summary>
        /// <returns></returns>
        private bool CountCheck()
        {
            int productCount = 0;

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                for (int k = 0; k < vendingSlots[i].Count; k++)
                {

                    productCount++;

                }
            }
            if (productCount < 30)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public string VendingMenu(char userInput, int productID, int userMoney, string admin)
        {

            returnString = PushProduct(productID, userMoney);
            if (moneyBox > 0)
            {
                safeBox.Safe(moneyBox);
            }
            return returnString;
        }

        /// <summary>
        /// print out products name and price
        /// </summary>
        /// <returns></returns>
        public string PrintProducts()
        {
            returnString = "";

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                returnString += $"Product ID = {i}.\n" +
                                $"Name = {vendingSlots[i].Peek().Name}.\n" +
                                $"price = {vendingSlots[i].Peek().Price}.\n\n";
            }

            return returnString;
        }

        /// <summary>
        /// Print out 1 product and price
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public string PrintOneP(int productID)
        {
            returnString = $"Name = {vendingSlots[productID].Peek().Name}.\n" +
                           $"Price = {vendingSlots[productID].Peek().Price}.";
            return returnString;
        }

        /// <summary>
        /// Print out adminmenu
        /// </summary>
        /// <returns></returns>
        public string PrintAdminMenu()
        {

            return Figgle.FiggleFonts.Small.Render("Admin Menu  \n") +
                   "Press [X] to fill vending machine.\n" +
                   "Press [Z] to empty machine.\n" +
                   "Press [C] to change price.\n" +
                   "Press [P] to print products.\n" +
                   "Press [S] to empty moneybox into safe.\n" +
                   "Press [L] to exit admin menu.";
        }


        /// <summary>
        /// Adminmen, switch case, x fill, z  empty machine, c change price, s empty moneybox into safeboxs
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="priceChange"></param>
        /// <param name="productID"></param>
        /// <returns></returns>
        public string AdminMenu(char userInput, int priceChange, int productID)
        {
            switch (char.ToLower(userInput))
            {

                case 'x':
                    if (CountCheck() == false)
                    {
                        FillProduct();
                        returnString = "Filled up all products";
                    }
                    else
                    {
                        returnString = "Vending machine is already full";
                    }

                    break;

                case 'z':
                    EmptyVending();
                    returnString = "Machine is empty";
                    break;

                case 'c':
                    returnString = ChangePrice(productID, priceChange);
                    break;

                case 's':
                    if (safeBox.Safe(moneyBox))
                    {
                        returnString = $"Money saved = {moneyBox}";
                    }
                    else
                    {
                        returnString = "Something went wrong";
                    }

                    break;

                default:


                    break;
            }

            return returnString;
        }

    }
}

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
        Stack<Product> slots;

        Candy candy;

        Drink drink;

        Product temp;

        List<Stack<Product>> vendingSlots = new List<Stack<Product>>();

        List<Candy> removedCandies = new List<Candy>();

        List<Drink> removedDrinks = new List<Drink>();

        private int moneyBox = 0;

        private int returnMoney = 0;

        private bool buyCompletet = false;

        //Properties


        //Constructor
        public VendingMachine()
        {
            for (int i = 0; i < 6; i++)
            {
                vendingSlots.Add(slots = new Stack<Product>());
            }
            FillProduct();

        }

        /// <summary>
        /// Input ProductNumber 0-1-2 candy. 3-4-5 drinks
        /// </summary>
        /// <param name="productNumber"></param>
        /// <returns></returns>
        public string PushProduct(int productNumber, int money)
        {
            PickObject(productNumber);

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
                return $"You bought {temp.Name}.\n Money returned = {returnMoney}";
            }
            else
            {
                return "You didnt have enough money, insert more or pick another product";
            }
        }

        private int InsertCoin(int money)
        {
            if (temp.Price <= money)
            {
                returnMoney = money -= temp.Price;
                buyCompletet = true;
                return returnMoney;
            }
            else
            {
                buyCompletet = false;
                return money;
            }
        }

        //Methods
        /// <summary>
        /// 0-2 candy.. 3-5 soda
        /// </summary>
        /// <param name="product"></param>
        private int PickObject(int product)
        {
            temp = vendingSlots[product].Pop();

            return temp.Price;
        }


        public void FillProduct()
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

        public void EmptyVending()
        {
            for (int i = 0; i < vendingSlots.Count; i++)
            {

                vendingSlots[i].Clear();

            }
        }

    }
}

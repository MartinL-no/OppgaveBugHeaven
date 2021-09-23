using System;

namespace BugAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {           
            var shop = new Shop();
            var customer = new Customer();
            while (true)
            {
                shop.PrintItems();
                Console.WriteLine();
                Console.WriteLine("What do you want to buy?");
                Console.WriteLine("if finished shopping, write 0");
                Console.WriteLine();

                var itemNumber = Console.ReadLine();
                if (itemNumber == "0")
                {
                    shop.CheckOut(customer);
                }

                customer.AddItemToShoppingCart(shop.ShopItems.Find(item => item.Id == itemNumber));
                customer.PrintItemsInCart();

            }
        }
    }
}

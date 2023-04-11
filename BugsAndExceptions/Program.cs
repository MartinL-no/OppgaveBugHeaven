using System;

namespace BugsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {           
            var shop = new Shop();

            var bankInformation = new BankInformation("ACC1234", "DNB", "nok", 1000);
            var address = new Address("Storgata", "City Of Oslo", "Oslo", "14");
            var customer = new Customer("Terje", address, bankInformation);
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
                else
                {
                    var item = shop.ShopItems.Find(item => item.Id == itemNumber);
                    customer.AddItemToShoppingCart(shop.ShopItems.Find(item => item.Id == itemNumber));
                    customer.PrintItemsInCart();
                }
            }
        }
    }
}

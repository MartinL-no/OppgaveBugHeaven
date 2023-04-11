using System;
using System.Collections.Generic;
using System.Text;

namespace BugsAndExceptions
{
    public class Customer
    {
        public string Name { get; set; }
        public Address CustomerAddress { get; set; }
        public BankInformation CustomerBankInfo {get;set;} 
        public List<ShopItem> ShoppingCart { get; set; }
        public int ShoppingListTotal => ShoppingCart.Sum(i => i.Price);
        public List<ShopItem> Inventory { get; set; }

        protected Customer()
        {
            ShoppingCart = new List<ShopItem>();
            Inventory = new List<ShopItem>();
        }
        public Customer(string name, Address address, BankInformation bankInfo)
            : this()
        {
            Name = name;
            CustomerAddress = address;
            CustomerBankInfo = bankInfo;
        }
        
        public void AddItemToShoppingCart(ShopItem item)
        {
            ShoppingCart.Add(item);
        }
        public void RemoveItemFromShoppingCart(ShopItem item)
        {
            ShoppingCart.Remove(item);
        }
        public void PrintItemsInCart()
        {
            var noItems = ShoppingCart.Count == 0 ? "no items" : "";
            Console.WriteLine($"ShoppingCart now has: {noItems}");

            foreach(var Item in ShoppingCart)
            {
                Console.WriteLine(Item.ItemName);
            }
            Console.WriteLine("Shopping cart total: " + ShoppingListTotal);
            Console.WriteLine();
        }
        public void BuyItemsInCart()
        {
            CustomerBankInfo.Balance -= ShoppingListTotal;
            Inventory = ShoppingCart;

            PrintItemsBought();
            Console.WriteLine($"Bank account balance is now: {CustomerBankInfo.Balance}");
            Console.WriteLine();

            ShoppingCart = new List<ShopItem>();
        }
        public void PrintItemsBought()
        {
            var itemNames = ShoppingCart.Select(i => i.ItemName);
            var itemNameString = String.Join(", ", itemNames);
            Console.WriteLine($"Items bought: {itemNameString}");
        }
    }
}

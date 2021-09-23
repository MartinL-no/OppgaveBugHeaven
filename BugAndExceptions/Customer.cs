using System;
using System.Collections.Generic;
using System.Text;

namespace BugAndExceptions
{
    public class Customer
    {
        public string Name { get; set; }
        public Address CustomerAddress { get; set; }
        public BankInformation CustomerBankInfo {get;set;} 
        public List<ShopItem> ShoppingCart { get; set; }
        public List<ShopItem> Inventory { get; set; }

        public Customer()
        {
            ShoppingCart = new List<ShopItem>();
            Inventory = new List<ShopItem>();
        }
        public Customer(string name, Address address, BankInformation bankInfo)
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
            Console.WriteLine("ShoppingCart now has: ");
            var totalPrice = 0;
            foreach(var Item in ShoppingCart)
            {
                Console.WriteLine(Item.ItemName);
                totalPrice += Item.Price;
            }
            Console.WriteLine("total price is: " + totalPrice);
            Console.WriteLine();
        }
        public void BuyItemsInCart()
        {
            Inventory = ShoppingCart;
            Console.WriteLine("Items bought");
        }
    }
}

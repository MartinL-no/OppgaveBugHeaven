using System;
using System.Collections.Generic;
using System.Text;

namespace BugsAndExceptions
{
    public class BankInformation
    {
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public int Balance { get; set; }

        public BankInformation(string accountNumber, string bankName, string currency, int balance)
        {
            AccountNumber = accountNumber;
            BankName = bankName;
            Currency = currency;
            Balance = balance;
        }
    }
}

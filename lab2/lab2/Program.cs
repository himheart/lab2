﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            CreditCard.CreditCard creditCard = new CreditCard.CreditCard();
            Console.WriteLine(creditCard.getCredit());

            BusinessCard.BusinessCard businessCard = new BusinessCard.BusinessCard();
            businessCard.useBusinessCard();

            Money.Money money = new Money.Money();
            money.getMoney();
            
        }
    }
}

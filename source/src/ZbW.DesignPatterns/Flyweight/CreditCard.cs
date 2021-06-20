﻿
namespace ZbW.DesignPatterns.Flyweight
{
    public class CreditCard : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Payed {amount} Fr. with credit card";
        }
    }
}

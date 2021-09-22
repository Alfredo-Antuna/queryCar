using System;

namespace queryCar
{

    public class Bank
    {
        private decimal _funds;


        public void Deposit(decimal depositAmount){
            _funds += depositAmount;
        }

        public void Withdraw(decimal withdrawAmount){
            _funds -= withdrawAmount;
        }
    }




}
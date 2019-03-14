using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;

        private BankAccount()
        {
        }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
    }
}

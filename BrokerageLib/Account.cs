using System;

namespace BrokerageLib {

  public class Account {
    private string _customerName;
    private decimal _balance;
    private bool _frozen = false;

   

    public Account(string customerName, decimal balance) {
      _customerName = customerName;
      _balance = balance;
    }

    public string CustomerName {
      get { return _customerName; }
    }

    public decimal Balance {
      get { return _balance; }
    }

    public void Debit(decimal amount) {
      

      if (amount > _balance)
      {
        throw new ArgumentOutOfRangeException("amount");
      }

      if (amount < 0)
      {
        throw new ArgumentOutOfRangeException("amount");
      }

      _balance -= amount;
    }

    public void Credit(decimal amount) {
      

      if (amount < 0)
      {
        throw new ArgumentOutOfRangeException("amount");
      }

      _balance += amount;
    }

    private void FreezeAccount() {
      _frozen = true;
    }

    private void UnfreezeAccount() {
      _frozen = false;
    }
  }
}
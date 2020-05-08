using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LABAA2
{
  public class CreditLimit
  {

    public int avalibleMoney { get; set; }
    public int limitMoney { get; set; }

    public CreditLimit(int avalibleMoney, int limitMoney)
    {
      this.avalibleMoney = avalibleMoney;
      this.limitMoney = limitMoney;
    }

    public CreditLimit()
    {

    }

    public void udpateCreditLimit(int value )
    {
      this.avalibleMoney += value;
      this.limitMoney += value;
    }

    public string getCreditLimit()
     {
      return "" + this.avalibleMoney + '/' + this.limitMoney;
     }

  }


  public class Account
  {
    [Key]
    public int ID { get; set; } 
    public int money { get; set; }
    public CreditLimit creditLimit { get; set; }

    public Account()
    {
      this.money = 0;
      this.creditLimit = new CreditLimit(0, 0);
    }

    public bool pay(int money)
    {
      bool isMoneyEnought = true;
     
      if(this.money - money < 0)
      {
        if((this.creditLimit.avalibleMoney + this.money - money) < 0)
        {
          isMoneyEnought = false;
        }
        else
        {
          this.creditLimit.avalibleMoney += this.money - money;
          this.money = 0;
        }
      }
      else
      {
        this.money -= money;
      }
      return isMoneyEnought;
    }

  }
}

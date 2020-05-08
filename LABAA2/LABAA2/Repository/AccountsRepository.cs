using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAA2
{
  class AccountsRepository
  {

    public static Account getAccountByUserId(int id)
    {
      using (DataStore db = new DataStore())
      {
        return db.Users.Where(user => user.ID == id).FirstOrDefault().userAccount;
      }
    }

    public static void updateAccount(Account updatedAccount,int userId)
    {
      using (DataStore db = new DataStore())
      {
        var accountForUpdating = db.Users.Include("userAccount").Where(user => user.ID == userId).First().userAccount;
        accountForUpdating.money = updatedAccount.money;
        accountForUpdating.creditLimit = updatedAccount.creditLimit;
        db.SaveChanges();
      }
    }

  }
}

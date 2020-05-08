using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAA2
{
  class UserRepository
  {

    public static int getLatestAddedUserId()
    {
      using (DataStore db = new DataStore())
      {
        
        return db.Users.OrderByDescending(q => q.ID).FirstOrDefault().ID;
      }
    }

    public static User getUser(string username, string password)
    {
      using (DataStore db = new DataStore())
      {
        return db.Users.Include("userAccount").Where(user => user.username == username && user.password == password).FirstOrDefault();
      }
    }

    public static List<User> getAllUsers()
    {
      using (DataStore db = new DataStore())
      {
        return db.Users.Include("userAccount").ToList();
      }
    }

    public static void updateUser(User user)
    {
      using (DataStore db = new DataStore())
      {
        var userForUpdating = db.Users.Where(us => user.ID == us.ID).First();
        userForUpdating.firstName = user.firstName;
        userForUpdating.lastName = user.lastName;
        userForUpdating.password = user.password;
        userForUpdating.username = user.username;
        userForUpdating.isCardBlocked = user.isCardBlocked;
        db.SaveChanges();
      }
    }

    public static void blockCard(int id)
    {
      using (DataStore db = new DataStore())
      {
        db.Users.Where(user => user.ID == id).First().blockCard();
        db.SaveChanges();

      }
    }

    public static void unblockCard(int id)
    {
      using (DataStore db = new DataStore())
      {
        db.Users.Where(user => user.ID == id).First().unblockCard();
        db.SaveChanges();

      }
    }

  }
}

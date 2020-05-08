using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAA2
{
  sealed class User : Person, IUserBehaviour 
  {
   

    public bool isCardBlocked { get; set; }
    public Account userAccount { get; set; }
    
    public User(string firstName, string lastName, string username, string password) : base(username, password, firstName, lastName)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.username = username;
      this.password = password;
      this.isCardBlocked = false;
      this.userAccount = new Account();
    }

    public User() 
    {

    }

    public string getUserAsString()
    {
      return firstName + " " + lastName + " "  + "Card Status: "  + (isCardBlocked ? "blocked" : "no blocked");
    }

    public void blockCard()
    {
      this.isCardBlocked = true;
    }

    public void blockCard(int id)
    {
      UserRepository.blockCard(id);
    }

    public void unblockCard()
    {
      this.isCardBlocked = false;
    }

    public void unblockCard(int id)
    {
      UserRepository.unblockCard(id);
    }

    public override bool isAdmin()
    {
      return false;
    }

  









  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAA2
{
  class Admin : Person, IUserBehaviour
  {
    public Admin(string username, string password, string firstName, string lastName): base(username, password, firstName, lastName){}


    public Admin()
    {
      this.username = "admin";
      this.password = "admin";
      this.firstName = "admin";
      this.lastName = "admin";
    }
    public override bool isAdmin()
    {
      return base.isAdmin();
    }

    



    public void blockCard(int id)
    {
      UserRepository.blockCard(id);
    }

    public void unblockCard(int id)
    {
      UserRepository.unblockCard(id);
    }

    public void adminSpit()
    {
      Console.WriteLine("Krodiom poroli");
    }

    public void adminNeSpit()
    {
      Console.WriteLine("Jdem poka ysnet");
    }

    delegate void SonHandler();
    delegate void ProsnylsaHandler(string mes);
    public void krodomPoroli()
    {
      SonHandler son;
      bool isadminSpit = false;
      if (isadminSpit)
      {
        son = adminSpit;
      }
      else{
        son = adminNeSpit;
      }
      son();
      ProsnylsaHandler handler = delegate (string mes)
      {
        Console.WriteLine(mes);
      };
      handler("Admin prosnylsa");

    }

    

    
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LABAA2
{
  public class Person
  {
    [Key]
    public int ID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string username { get; set; }
    public string password { get; set; }

    public Person(string username, string password, string FirstName, string lastName)
    {
      this.username = username;
      this.password = password;
      this.lastName = lastName;
      this.firstName = firstName;
    }
    public virtual bool isAdmin() { return true; }


    public Person() { }

  }
}

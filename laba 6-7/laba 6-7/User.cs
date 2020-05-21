using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace laba_6_7
{
  class User
  {
    [Key]
    public int ID { get; set; }
    public string city { get; set; }
    public string name { get; set; }
    public string phone { get; set; }
    public Account usersAccount { get; set; }

    public User(string name, string phone, string city)
    {
      this.city = city;
      this.name = name;
      this.phone = phone;
      this.usersAccount = new Account(this.name, this.phone, this.name.ToUpper());
    }

    public User()
    {

    }
  }
}

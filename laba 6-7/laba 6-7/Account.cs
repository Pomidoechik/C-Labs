using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace laba_6_7
{
  class Account
  {
    [Key]
    public int ID { get; set; }
    public string superSecretCode { get; set; }
    public string superSecretUsername { get; set; }

    public Account(string name, string phone, string username)
    {
      this.superSecretUsername = username;
      this.superSecretCode = name.Reverse() + "" + phone.Reverse();
    }

    public Account()
    {

    }
    
  }
}

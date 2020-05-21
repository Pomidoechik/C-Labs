using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace laba_6_7
{
  class Market
  {
    [Key]
    public int ID { get; set; }
    public string name { get; set; }
    public string city { get; set; }

    public Market(string name, string city)
    {
      this.name = name;
      this.city = city;
    }

    public Market()
    {

    }


  }
}

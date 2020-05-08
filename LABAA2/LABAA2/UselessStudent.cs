using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LABAA2
{
  class UselessStudent
  {
    [Key]
    public int ID { get; set; }
    public string name { get; set; }
    public List<UselessCourse> Courses;

    
    public UselessStudent(string name)
    {
      this.name = name;
    }


  }
}

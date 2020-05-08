using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LABAA2
{
  class UselessCourse 
{
    [Key]
    public int ID { get; set; }
    public string name { get; set; }
    public List<UselessStudent> studOnCourse;

    public UselessCourse()
    {
      this.name = "Course";
    
    }

    public void addStud(UselessStudent stud)
    {
      this.studOnCourse.Add(stud);
    }
  }
}

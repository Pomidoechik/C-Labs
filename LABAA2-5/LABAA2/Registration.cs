using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LABAA2
{
  public partial class Registration : MaterialForm
  {
    public Registration()
    {
      InitializeComponent();
    }

    private void registrateButton_Click(object sender, EventArgs e)
    {
      using (DataStore db = new DataStore())
      {
        User addingUser = new User(firstName.Text, lastName.Text, username.Text, password.Text);

        if (null != db.Users.Where(user => user.firstName == addingUser.firstName && user.lastName == addingUser.lastName).FirstOrDefault())
        {
          Error errorMes = new Error("This user already registreted");
          errorMes.Show();
        }
        else if(null != db.Users.Where(user => user.username == addingUser.username).FirstOrDefault())
        {
          Error errorMes = new Error("This username already using");
          errorMes.Show();
        }
        else
        {
          db.Users.Add(addingUser);
          db.SaveChanges();

        }
      }
    }
  }
}

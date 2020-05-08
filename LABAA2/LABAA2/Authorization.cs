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
  public partial class Authorization : MaterialForm
  {
    public Authorization()
    {
      InitializeComponent();
    }

    private void materialLabel1_Click(object sender, EventArgs e)
    {
      Registration registrForm = new Registration();
      registrForm.Show();
      this.Hide();
    }

    private void logInButton_Click(object sender, EventArgs e)
    {
      if(UserRepository.getUser(username.Text, password.Text) != null)
      {
        MainForm mainForm = new MainForm(UserRepository.getUser(username.Text, password.Text));
        mainForm.Show();
        this.Hide();
      }
      else if (username.Text == "admin" &&  password.Text == "admin")
      {
        AdminForm form = new AdminForm();
        form.Show();
        this.Hide();
      }
      else
      {
        Error errorMessage = new Error("Not correct username or password");
        errorMessage.Show();
      }
    }
  }
}

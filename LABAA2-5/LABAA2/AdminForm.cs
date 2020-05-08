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
  public partial class AdminForm : MaterialForm
  {
    int selectedUserID;
    List<User> allUsers = new List<User>();
    Admin currentAdmin = new Admin();
    public AdminForm()
    {
      allUsers = UserRepository.getAllUsers();
      InitializeComponent();
      int num = 1;
      allUsers.ForEach(user => this.UsersList.Items.Add((num++) + user.getUserAsString()));
    }

    private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
    {
      selectedUserID = this.UsersList.SelectedIndex;
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
      currentAdmin.blockCard(allUsers[selectedUserID].ID);
    }

    private void materialButton2_Click(object sender, EventArgs e)
    {
      currentAdmin.unblockCard(allUsers[selectedUserID].ID);
    }
  }
}

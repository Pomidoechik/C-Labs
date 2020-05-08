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

  public partial class MainForm : MaterialForm
  {

    User currentUser;

    public MainForm(User user)
    {
      InitializeComponent();
      currentUser = user;
      updateTextValue();
    }

    private void updateTextValue()
    {
      money.Text = currentUser.userAccount.money + "";
      creditLimit.Text = currentUser.userAccount.creditLimit.getCreditLimit();
    }

    private void materialTextBox1_TextChanged(object sender, EventArgs e)
    {
     
    }

    private void accountDepositButton_Click(object sender, EventArgs e)
    {
      if (!currentUser.isCardBlocked)
      {
        int newMoneyValue = currentUser.userAccount.money + Convert.ToInt32(accountDepositTextBox.Text);
        currentUser.userAccount.money = newMoneyValue;
        updateTextValue();
        AccountsRepository.updateAccount(currentUser.userAccount, currentUser.ID);
      }
      else
      {
        Error errorMessage = new Error("You card is blocdked");
        errorMessage.Show();
      }
    }

    private void changeCreditLimmitButton_Click(object sender, EventArgs e)
    {
      if (!currentUser.isCardBlocked)
      {
        int newCreditLimit = Convert.ToInt32(creditLimitChangeTextBox.Text) - currentUser.userAccount.creditLimit.limitMoney ;

        if(currentUser.userAccount.creditLimit.avalibleMoney + newCreditLimit > 0)
        {
        currentUser.userAccount.creditLimit.udpateCreditLimit(newCreditLimit);
        AccountsRepository.updateAccount(currentUser.userAccount, currentUser.ID);
         updateTextValue();
        }
        else
        {
          Error errorMessage = new Error("Dont enought money");
          errorMessage.Show();
        }
          
      }
      else
      {
        Error errorMessage = new Error("You card is blocdked");
        errorMessage.Show();
      }
    }

    private void payOrderButton_Click(object sender, EventArgs e)
    {
      if (!currentUser.isCardBlocked)
      {

      int code = Convert.ToInt32(payOrderTextBox.Text);
      if (currentUser.userAccount.pay(code))
      {
        updateTextValue();
          AccountsRepository.updateAccount(currentUser.userAccount, currentUser.ID);
        }
      else
      {
        Error errorMessage = new Error("Dont enought money");
        errorMessage.Show();
      }
      
      }

    }
  }
}

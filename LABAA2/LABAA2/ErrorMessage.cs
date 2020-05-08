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
  public partial class Error : MaterialForm
  {
    public Error(string errorMessage)
    {
      InitializeComponent();

      errorText.Text = errorMessage;
    }
  }
}

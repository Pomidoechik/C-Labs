namespace LABAA2
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.moneyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.money = new MaterialSkin.Controls.MaterialLabel();
            this.creditLimitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.creditLimit = new MaterialSkin.Controls.MaterialLabel();
            this.creditLimitChangeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.creditLimitChangeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.changeCreditLimmitButton = new MaterialSkin.Controls.MaterialButton();
            this.payOrderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.payOrderTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.payOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.accountDepositLabel = new MaterialSkin.Controls.MaterialLabel();
            this.accountDepositTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.accountDepositButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Depth = 0;
            this.moneyLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.moneyLabel.Location = new System.Drawing.Point(64, 107);
            this.moneyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(109, 19);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "Avalible money";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Depth = 0;
            this.money.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.money.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.money.Location = new System.Drawing.Point(95, 126);
            this.money.MouseState = MaterialSkin.MouseState.HOVER;
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(28, 58);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            // 
            // creditLimitLabel
            // 
            this.creditLimitLabel.AutoSize = true;
            this.creditLimitLabel.Depth = 0;
            this.creditLimitLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.creditLimitLabel.Location = new System.Drawing.Point(353, 107);
            this.creditLimitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditLimitLabel.Name = "creditLimitLabel";
            this.creditLimitLabel.Size = new System.Drawing.Size(112, 19);
            this.creditLimitLabel.TabIndex = 2;
            this.creditLimitLabel.Text = "Your credit limit";
            // 
            // creditLimit
            // 
            this.creditLimit.AutoSize = true;
            this.creditLimit.Depth = 0;
            this.creditLimit.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.creditLimit.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.creditLimit.Location = new System.Drawing.Point(393, 126);
            this.creditLimit.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditLimit.Name = "creditLimit";
            this.creditLimit.Size = new System.Drawing.Size(28, 58);
            this.creditLimit.TabIndex = 3;
            this.creditLimit.Text = "0";
            // 
            // creditLimitChangeTextBox
            // 
            this.creditLimitChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creditLimitChangeTextBox.Depth = 0;
            this.creditLimitChangeTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.creditLimitChangeTextBox.Location = new System.Drawing.Point(300, 341);
            this.creditLimitChangeTextBox.MaxLength = 50;
            this.creditLimitChangeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.creditLimitChangeTextBox.Multiline = false;
            this.creditLimitChangeTextBox.Name = "creditLimitChangeTextBox";
            this.creditLimitChangeTextBox.Size = new System.Drawing.Size(221, 50);
            this.creditLimitChangeTextBox.TabIndex = 4;
            this.creditLimitChangeTextBox.Text = "";
            // 
            // creditLimitChangeLabel
            // 
            this.creditLimitChangeLabel.Depth = 0;
            this.creditLimitChangeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.creditLimitChangeLabel.Location = new System.Drawing.Point(297, 297);
            this.creditLimitChangeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditLimitChangeLabel.Name = "creditLimitChangeLabel";
            this.creditLimitChangeLabel.Size = new System.Drawing.Size(234, 41);
            this.creditLimitChangeLabel.TabIndex = 5;
            this.creditLimitChangeLabel.Text = "You can change your credit limit \r\n                 (max 50 000)";
            // 
            // changeCreditLimmitButton
            // 
            this.changeCreditLimmitButton.AutoSize = false;
            this.changeCreditLimmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeCreditLimmitButton.Depth = 0;
            this.changeCreditLimmitButton.DrawShadows = true;
            this.changeCreditLimmitButton.HighEmphasis = true;
            this.changeCreditLimmitButton.Icon = null;
            this.changeCreditLimmitButton.Location = new System.Drawing.Point(300, 400);
            this.changeCreditLimmitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeCreditLimmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeCreditLimmitButton.Name = "changeCreditLimmitButton";
            this.changeCreditLimmitButton.Size = new System.Drawing.Size(221, 36);
            this.changeCreditLimmitButton.TabIndex = 6;
            this.changeCreditLimmitButton.Text = "Change credit limit";
            this.changeCreditLimmitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.changeCreditLimmitButton.UseAccentColor = false;
            this.changeCreditLimmitButton.UseVisualStyleBackColor = true;
            this.changeCreditLimmitButton.Click += new System.EventHandler(this.changeCreditLimmitButton_Click);
            // 
            // payOrderLabel
            // 
            this.payOrderLabel.Depth = 0;
            this.payOrderLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.payOrderLabel.Location = new System.Drawing.Point(568, 297);
            this.payOrderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.payOrderLabel.Name = "payOrderLabel";
            this.payOrderLabel.Size = new System.Drawing.Size(220, 39);
            this.payOrderLabel.TabIndex = 7;
            this.payOrderLabel.Text = "Enter the account number to   \r\n        pay for your order.";
            // 
            // payOrderTextBox
            // 
            this.payOrderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payOrderTextBox.Depth = 0;
            this.payOrderTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.payOrderTextBox.Location = new System.Drawing.Point(571, 341);
            this.payOrderTextBox.MaxLength = 50;
            this.payOrderTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.payOrderTextBox.Multiline = false;
            this.payOrderTextBox.Name = "payOrderTextBox";
            this.payOrderTextBox.Size = new System.Drawing.Size(197, 50);
            this.payOrderTextBox.TabIndex = 8;
            this.payOrderTextBox.Text = "";
            // 
            // payOrderButton
            // 
            this.payOrderButton.AutoSize = false;
            this.payOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.payOrderButton.Depth = 0;
            this.payOrderButton.DrawShadows = true;
            this.payOrderButton.HighEmphasis = true;
            this.payOrderButton.Icon = null;
            this.payOrderButton.Location = new System.Drawing.Point(571, 400);
            this.payOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.payOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.payOrderButton.Name = "payOrderButton";
            this.payOrderButton.Size = new System.Drawing.Size(197, 36);
            this.payOrderButton.TabIndex = 9;
            this.payOrderButton.Text = "Pay order";
            this.payOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.payOrderButton.UseAccentColor = false;
            this.payOrderButton.UseVisualStyleBackColor = true;
            this.payOrderButton.Click += new System.EventHandler(this.payOrderButton_Click);
            // 
            // accountDepositLabel
            // 
            this.accountDepositLabel.Depth = 0;
            this.accountDepositLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.accountDepositLabel.Location = new System.Drawing.Point(22, 297);
            this.accountDepositLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountDepositLabel.Name = "accountDepositLabel";
            this.accountDepositLabel.Size = new System.Drawing.Size(221, 23);
            this.accountDepositLabel.TabIndex = 10;
            this.accountDepositLabel.Text = "           Deposit to account";
            // 
            // accountDepositTextBox
            // 
            this.accountDepositTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountDepositTextBox.Depth = 0;
            this.accountDepositTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.accountDepositTextBox.Location = new System.Drawing.Point(22, 341);
            this.accountDepositTextBox.MaxLength = 50;
            this.accountDepositTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.accountDepositTextBox.Multiline = false;
            this.accountDepositTextBox.Name = "accountDepositTextBox";
            this.accountDepositTextBox.Size = new System.Drawing.Size(221, 50);
            this.accountDepositTextBox.TabIndex = 11;
            this.accountDepositTextBox.Text = "";
            // 
            // accountDepositButton
            // 
            this.accountDepositButton.AutoSize = false;
            this.accountDepositButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accountDepositButton.Depth = 0;
            this.accountDepositButton.DrawShadows = true;
            this.accountDepositButton.HighEmphasis = true;
            this.accountDepositButton.Icon = null;
            this.accountDepositButton.Location = new System.Drawing.Point(22, 400);
            this.accountDepositButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.accountDepositButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountDepositButton.Name = "accountDepositButton";
            this.accountDepositButton.Size = new System.Drawing.Size(221, 36);
            this.accountDepositButton.TabIndex = 12;
            this.accountDepositButton.Text = "Deposit";
            this.accountDepositButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.accountDepositButton.UseAccentColor = false;
            this.accountDepositButton.UseVisualStyleBackColor = true;
            this.accountDepositButton.Click += new System.EventHandler(this.accountDepositButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountDepositButton);
            this.Controls.Add(this.accountDepositTextBox);
            this.Controls.Add(this.accountDepositLabel);
            this.Controls.Add(this.payOrderButton);
            this.Controls.Add(this.payOrderTextBox);
            this.Controls.Add(this.payOrderLabel);
            this.Controls.Add(this.changeCreditLimmitButton);
            this.Controls.Add(this.creditLimitChangeLabel);
            this.Controls.Add(this.creditLimitChangeTextBox);
            this.Controls.Add(this.creditLimit);
            this.Controls.Add(this.creditLimitLabel);
            this.Controls.Add(this.money);
            this.Controls.Add(this.moneyLabel);
            this.Name = "MainForm";
            this.Text = "Your account";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialLabel moneyLabel;
    private MaterialSkin.Controls.MaterialLabel money;
    private MaterialSkin.Controls.MaterialLabel creditLimitLabel;
    private MaterialSkin.Controls.MaterialLabel creditLimit;
    private MaterialSkin.Controls.MaterialTextBox creditLimitChangeTextBox;
    private MaterialSkin.Controls.MaterialLabel creditLimitChangeLabel;
    private MaterialSkin.Controls.MaterialButton changeCreditLimmitButton;
    private MaterialSkin.Controls.MaterialLabel payOrderLabel;
    private MaterialSkin.Controls.MaterialTextBox payOrderTextBox;
    private MaterialSkin.Controls.MaterialButton payOrderButton;
    private MaterialSkin.Controls.MaterialLabel accountDepositLabel;
    private MaterialSkin.Controls.MaterialTextBox accountDepositTextBox;
    private MaterialSkin.Controls.MaterialButton accountDepositButton;
  }
}


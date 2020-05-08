namespace LABAA2
{
  partial class Registration
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
            this.firstName = new MaterialSkin.Controls.MaterialTextBox();
            this.lastName = new MaterialSkin.Controls.MaterialTextBox();
            this.username = new MaterialSkin.Controls.MaterialTextBox();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.firstnameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.lastnameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.registrateButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstName.Depth = 0;
            this.firstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.firstName.Location = new System.Drawing.Point(81, 137);
            this.firstName.MaxLength = 50;
            this.firstName.MouseState = MaterialSkin.MouseState.OUT;
            this.firstName.Multiline = false;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(257, 50);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "";
            // 
            // lastName
            // 
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastName.Depth = 0;
            this.lastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lastName.Location = new System.Drawing.Point(81, 222);
            this.lastName.MaxLength = 50;
            this.lastName.MouseState = MaterialSkin.MouseState.OUT;
            this.lastName.Multiline = false;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(257, 50);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Depth = 0;
            this.username.Font = new System.Drawing.Font("Roboto", 12F);
            this.username.Location = new System.Drawing.Point(431, 139);
            this.username.MaxLength = 50;
            this.username.MouseState = MaterialSkin.MouseState.OUT;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(257, 50);
            this.username.TabIndex = 2;
            this.username.Text = "";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 12F);
            this.password.Location = new System.Drawing.Point(431, 222);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(257, 50);
            this.password.TabIndex = 3;
            this.password.Text = "";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Depth = 0;
            this.firstnameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstnameLabel.Location = new System.Drawing.Point(81, 112);
            this.firstnameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(116, 19);
            this.firstnameLabel.TabIndex = 4;
            this.firstnameLabel.Text = "Enter your name";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Depth = 0;
            this.lastnameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastnameLabel.Location = new System.Drawing.Point(81, 194);
            this.lastnameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(138, 19);
            this.lastnameLabel.TabIndex = 5;
            this.lastnameLabel.Text = "Enter your surname";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameLabel.Location = new System.Drawing.Point(434, 114);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(146, 19);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Enter yout username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(434, 197);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(145, 19);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Enter your password";
            // 
            // registrateButton
            // 
            this.registrateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrateButton.Depth = 0;
            this.registrateButton.DrawShadows = true;
            this.registrateButton.HighEmphasis = true;
            this.registrateButton.Icon = null;
            this.registrateButton.Location = new System.Drawing.Point(312, 322);
            this.registrateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrateButton.Name = "registrateButton";
            this.registrateButton.Size = new System.Drawing.Size(132, 36);
            this.registrateButton.TabIndex = 8;
            this.registrateButton.Text = "REGISTRATE ME";
            this.registrateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registrateButton.UseAccentColor = false;
            this.registrateButton.UseVisualStyleBackColor = true;
            this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox firstName;
    private MaterialSkin.Controls.MaterialTextBox lastName;
    private MaterialSkin.Controls.MaterialTextBox username;
    private MaterialSkin.Controls.MaterialTextBox password;
    private MaterialSkin.Controls.MaterialLabel firstnameLabel;
    private MaterialSkin.Controls.MaterialLabel lastnameLabel;
    private MaterialSkin.Controls.MaterialLabel usernameLabel;
    private MaterialSkin.Controls.MaterialLabel passwordLabel;
    private MaterialSkin.Controls.MaterialButton registrateButton;
  }
}
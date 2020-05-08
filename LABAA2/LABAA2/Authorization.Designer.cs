namespace LABAA2
{
  partial class Authorization
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
            this.username = new MaterialSkin.Controls.MaterialTextBox();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.logInButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Depth = 0;
            this.username.Font = new System.Drawing.Font("Roboto", 12F);
            this.username.Location = new System.Drawing.Point(214, 141);
            this.username.MaxLength = 50;
            this.username.MouseState = MaterialSkin.MouseState.OUT;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(246, 50);
            this.username.TabIndex = 0;
            this.username.Text = "";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 12F);
            this.password.Location = new System.Drawing.Point(214, 241);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(246, 50);
            this.password.TabIndex = 1;
            this.password.Text = "";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameLabel.Location = new System.Drawing.Point(214, 119);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(72, 19);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(215, 219);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 19);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Location = new System.Drawing.Point(224, 371);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(222, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Don`t have account? Registrate";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // logInButton
            // 
            this.logInButton.AutoSize = false;
            this.logInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInButton.Depth = 0;
            this.logInButton.DrawShadows = true;
            this.logInButton.HighEmphasis = true;
            this.logInButton.Icon = null;
            this.logInButton.Location = new System.Drawing.Point(214, 314);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(246, 36);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log in";
            this.logInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logInButton.UseAccentColor = false;
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Authorization";
            this.Text = "Authorisation";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox username;
    private MaterialSkin.Controls.MaterialTextBox password;
    private MaterialSkin.Controls.MaterialLabel usernameLabel;
    private MaterialSkin.Controls.MaterialLabel passwordLabel;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialButton logInButton;
  }
}
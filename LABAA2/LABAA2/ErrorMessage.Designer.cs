namespace LABAA2
{
  partial class Error
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
            this.errorText = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Depth = 0;
            this.errorText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.errorText.Location = new System.Drawing.Point(101, 173);
            this.errorText.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(1, 0);
            this.errorText.TabIndex = 0;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 273);
            this.Controls.Add(this.errorText);
            this.Name = "Error";
            this.Text = "Exeption";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialLabel errorText;
  }
}
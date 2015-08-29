namespace AutoSleep
{
  partial class SleepWarningDialog
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SleepWarningDialog));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSleep = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.tmrTimeToSleep = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 128);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnSleep, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 183);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(144, 33);
      this.label1.Margin = new System.Windows.Forms.Padding(10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(297, 68);
      this.label1.TabIndex = 1;
      this.label1.Text = "Computer is about to go to sleep.\r\n\r\nTo prevent the computer from going to sleep," +
    " press cancel below.";
      // 
      // btnSleep
      // 
      this.btnSleep.AutoSize = true;
      this.btnSleep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnSleep.Location = new System.Drawing.Point(3, 153);
      this.btnSleep.MinimumSize = new System.Drawing.Size(80, 0);
      this.btnSleep.Name = "btnSleep";
      this.btnSleep.Size = new System.Drawing.Size(85, 27);
      this.btnSleep.TabIndex = 2;
      this.btnSleep.Text = "Sleep &Now";
      this.btnSleep.UseVisualStyleBackColor = true;
      this.btnSleep.Click += new System.EventHandler(this.GoToSleep);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnCancel.AutoSize = true;
      this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(386, 153);
      this.btnCancel.MinimumSize = new System.Drawing.Size(80, 0);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(80, 27);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // tmrTimeToSleep
      // 
      this.tmrTimeToSleep.Enabled = true;
      this.tmrTimeToSleep.Tick += new System.EventHandler(this.GoToSleep);
      // 
      // SleepWarningDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(489, 203);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SleepWarningDialog";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Computer About to go to Sleep";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSleep;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Timer tmrTimeToSleep;
  }
}
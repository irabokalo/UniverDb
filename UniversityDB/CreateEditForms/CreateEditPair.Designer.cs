namespace UniversityDB.CreateEditForms
{
  partial class CreateEditPair
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
      this.cancelButton = new System.Windows.Forms.Button();
      this.okButton = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageUniversity = new System.Windows.Forms.TabPage();
      this.title = new System.Windows.Forms.TextBox();
      this.titleLabel = new System.Windows.Forms.Label();
      this.tabPagePair = new System.Windows.Forms.TabPage();
      this.roomLabel = new System.Windows.Forms.Label();
      this.durationLabel = new System.Windows.Forms.Label();
      this.duration = new System.Windows.Forms.TextBox();
      this.room = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabPageUniversity.SuspendLayout();
      this.tabPagePair.SuspendLayout();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(347, 143);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 5;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(347, 103);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 4;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageUniversity);
      this.tabControl1.Controls.Add(this.tabPagePair);
      this.tabControl1.Location = new System.Drawing.Point(25, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(298, 217);
      this.tabControl1.TabIndex = 3;
      // 
      // tabPageUniversity
      // 
      this.tabPageUniversity.Controls.Add(this.title);
      this.tabPageUniversity.Controls.Add(this.titleLabel);
      this.tabPageUniversity.Location = new System.Drawing.Point(4, 22);
      this.tabPageUniversity.Name = "tabPageUniversity";
      this.tabPageUniversity.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageUniversity.Size = new System.Drawing.Size(290, 191);
      this.tabPageUniversity.TabIndex = 0;
      this.tabPageUniversity.Text = "UniversityObj";
      this.tabPageUniversity.UseVisualStyleBackColor = true;
      // 
      // title
      // 
      this.title.Location = new System.Drawing.Point(69, 35);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(127, 20);
      this.title.TabIndex = 13;
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Location = new System.Drawing.Point(33, 42);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(30, 13);
      this.titleLabel.TabIndex = 12;
      this.titleLabel.Text = "Title:";
      // 
      // tabPagePair
      // 
      this.tabPagePair.Controls.Add(this.roomLabel);
      this.tabPagePair.Controls.Add(this.durationLabel);
      this.tabPagePair.Controls.Add(this.duration);
      this.tabPagePair.Controls.Add(this.room);
      this.tabPagePair.Location = new System.Drawing.Point(4, 22);
      this.tabPagePair.Name = "tabPagePair";
      this.tabPagePair.Padding = new System.Windows.Forms.Padding(3);
      this.tabPagePair.Size = new System.Drawing.Size(290, 191);
      this.tabPagePair.TabIndex = 1;
      this.tabPagePair.Text = "Pair";
      this.tabPagePair.UseVisualStyleBackColor = true;
      // 
      // roomLabel
      // 
      this.roomLabel.AutoSize = true;
      this.roomLabel.Location = new System.Drawing.Point(35, 33);
      this.roomLabel.Name = "roomLabel";
      this.roomLabel.Size = new System.Drawing.Size(35, 13);
      this.roomLabel.TabIndex = 24;
      this.roomLabel.Text = "Room";
      // 
      // durationLabel
      // 
      this.durationLabel.AutoSize = true;
      this.durationLabel.Location = new System.Drawing.Point(35, 71);
      this.durationLabel.Name = "durationLabel";
      this.durationLabel.Size = new System.Drawing.Size(103, 13);
      this.durationLabel.TabIndex = 25;
      this.durationLabel.Text = "Duration (in minutes)";
      // 
      // duration
      // 
      this.duration.Location = new System.Drawing.Point(144, 64);
      this.duration.Name = "duration";
      this.duration.Size = new System.Drawing.Size(100, 20);
      this.duration.TabIndex = 28;
      // 
      // room
      // 
      this.room.Location = new System.Drawing.Point(90, 30);
      this.room.Name = "room";
      this.room.Size = new System.Drawing.Size(100, 20);
      this.room.TabIndex = 27;
      // 
      // CreateEditPair
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(447, 288);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.tabControl1);
      this.Name = "CreateEditPair";
      this.Text = "CreateEditPair";
      this.tabControl1.ResumeLayout(false);
      this.tabPageUniversity.ResumeLayout(false);
      this.tabPageUniversity.PerformLayout();
      this.tabPagePair.ResumeLayout(false);
      this.tabPagePair.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageUniversity;
    private System.Windows.Forms.TextBox title;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.TabPage tabPagePair;
    private System.Windows.Forms.Label roomLabel;
    private System.Windows.Forms.Label durationLabel;
    private System.Windows.Forms.TextBox duration;
    private System.Windows.Forms.TextBox room;
  }
}
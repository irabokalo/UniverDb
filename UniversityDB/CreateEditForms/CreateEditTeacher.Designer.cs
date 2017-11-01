namespace UniversityDB.CreateEditForms
{
  partial class CreateEditTeacher
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
      this.tabPageHuman = new System.Windows.Forms.TabPage();
      this.nameLabel = new System.Windows.Forms.Label();
      this.age = new System.Windows.Forms.TextBox();
      this.surnameLabel = new System.Windows.Forms.Label();
      this.surname = new System.Windows.Forms.TextBox();
      this.ageLabel = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.TextBox();
      this.tabPageTeacher = new System.Windows.Forms.TabPage();
      this.educationLabel = new System.Windows.Forms.Label();
      this.education = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabPageUniversity.SuspendLayout();
      this.tabPageHuman.SuspendLayout();
      this.tabPageTeacher.SuspendLayout();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(354, 146);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 8;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(354, 106);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 7;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageUniversity);
      this.tabControl1.Controls.Add(this.tabPageHuman);
      this.tabControl1.Controls.Add(this.tabPageTeacher);
      this.tabControl1.Location = new System.Drawing.Point(32, 39);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(298, 217);
      this.tabControl1.TabIndex = 6;
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
      // tabPageHuman
      // 
      this.tabPageHuman.Controls.Add(this.nameLabel);
      this.tabPageHuman.Controls.Add(this.age);
      this.tabPageHuman.Controls.Add(this.surnameLabel);
      this.tabPageHuman.Controls.Add(this.surname);
      this.tabPageHuman.Controls.Add(this.ageLabel);
      this.tabPageHuman.Controls.Add(this.name);
      this.tabPageHuman.Location = new System.Drawing.Point(4, 22);
      this.tabPageHuman.Name = "tabPageHuman";
      this.tabPageHuman.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageHuman.Size = new System.Drawing.Size(290, 191);
      this.tabPageHuman.TabIndex = 1;
      this.tabPageHuman.Text = "Human";
      this.tabPageHuman.UseVisualStyleBackColor = true;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(37, 32);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(35, 13);
      this.nameLabel.TabIndex = 12;
      this.nameLabel.Text = "Name";
      // 
      // age
      // 
      this.age.Location = new System.Drawing.Point(92, 110);
      this.age.Name = "age";
      this.age.Size = new System.Drawing.Size(100, 20);
      this.age.TabIndex = 17;
      // 
      // surnameLabel
      // 
      this.surnameLabel.AutoSize = true;
      this.surnameLabel.Location = new System.Drawing.Point(37, 70);
      this.surnameLabel.Name = "surnameLabel";
      this.surnameLabel.Size = new System.Drawing.Size(49, 13);
      this.surnameLabel.TabIndex = 13;
      this.surnameLabel.Text = "Surname";
      // 
      // surname
      // 
      this.surname.Location = new System.Drawing.Point(92, 70);
      this.surname.Name = "surname";
      this.surname.Size = new System.Drawing.Size(100, 20);
      this.surname.TabIndex = 16;
      // 
      // ageLabel
      // 
      this.ageLabel.AutoSize = true;
      this.ageLabel.Location = new System.Drawing.Point(37, 113);
      this.ageLabel.Name = "ageLabel";
      this.ageLabel.Size = new System.Drawing.Size(26, 13);
      this.ageLabel.TabIndex = 14;
      this.ageLabel.Text = "Age";
      // 
      // name
      // 
      this.name.Location = new System.Drawing.Point(92, 32);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(100, 20);
      this.name.TabIndex = 15;
      // 
      // tabPageTeacher
      // 
      this.tabPageTeacher.Controls.Add(this.educationLabel);
      this.tabPageTeacher.Controls.Add(this.education);
      this.tabPageTeacher.Location = new System.Drawing.Point(4, 22);
      this.tabPageTeacher.Name = "tabPageTeacher";
      this.tabPageTeacher.Size = new System.Drawing.Size(290, 191);
      this.tabPageTeacher.TabIndex = 2;
      this.tabPageTeacher.Text = "Teacher";
      this.tabPageTeacher.UseVisualStyleBackColor = true;
      // 
      // educationLabel
      // 
      this.educationLabel.AutoSize = true;
      this.educationLabel.Location = new System.Drawing.Point(33, 35);
      this.educationLabel.Name = "educationLabel";
      this.educationLabel.Size = new System.Drawing.Size(55, 13);
      this.educationLabel.TabIndex = 6;
      this.educationLabel.Text = "Education";
      // 
      // education
      // 
      this.education.Location = new System.Drawing.Point(121, 32);
      this.education.Name = "education";
      this.education.Size = new System.Drawing.Size(115, 20);
      this.education.TabIndex = 9;
      // 
      // CreateEditTeacher
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 307);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.tabControl1);
      this.Name = "CreateEditTeacher";
      this.Text = "CreateEditTeacher";
      this.tabControl1.ResumeLayout(false);
      this.tabPageUniversity.ResumeLayout(false);
      this.tabPageUniversity.PerformLayout();
      this.tabPageHuman.ResumeLayout(false);
      this.tabPageHuman.PerformLayout();
      this.tabPageTeacher.ResumeLayout(false);
      this.tabPageTeacher.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageUniversity;
    private System.Windows.Forms.TextBox title;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.TabPage tabPageHuman;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox age;
    private System.Windows.Forms.Label surnameLabel;
    private System.Windows.Forms.TextBox surname;
    private System.Windows.Forms.Label ageLabel;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.TabPage tabPageTeacher;
    private System.Windows.Forms.Label educationLabel;
    private System.Windows.Forms.TextBox education;
  }
}
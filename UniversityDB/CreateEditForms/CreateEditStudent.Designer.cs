namespace UniversityDB.CreateEditForms
{
  partial class CreateEditStudent
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
      this.tabPageStudent = new System.Windows.Forms.TabPage();
      this.nameLabel = new System.Windows.Forms.Label();
      this.age = new System.Windows.Forms.TextBox();
      this.surnameLabel = new System.Windows.Forms.Label();
      this.surname = new System.Windows.Forms.TextBox();
      this.ageLabel = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.TextBox();
      this.mediumMarkLabel = new System.Windows.Forms.Label();
      this.favoriteSubjectLabel = new System.Windows.Forms.Label();
      this.favoriteSubject = new System.Windows.Forms.TextBox();
      this.mediumMark = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabPageUniversity.SuspendLayout();
      this.tabPageHuman.SuspendLayout();
      this.tabPageStudent.SuspendLayout();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(345, 144);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 5;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(345, 104);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 4;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageUniversity);
      this.tabControl1.Controls.Add(this.tabPageHuman);
      this.tabControl1.Controls.Add(this.tabPageStudent);
      this.tabControl1.Location = new System.Drawing.Point(23, 37);
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
      // tabPageStudent
      // 
      this.tabPageStudent.Controls.Add(this.mediumMarkLabel);
      this.tabPageStudent.Controls.Add(this.favoriteSubjectLabel);
      this.tabPageStudent.Controls.Add(this.favoriteSubject);
      this.tabPageStudent.Controls.Add(this.mediumMark);
      this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
      this.tabPageStudent.Name = "tabPageStudent";
      this.tabPageStudent.Size = new System.Drawing.Size(290, 191);
      this.tabPageStudent.TabIndex = 2;
      this.tabPageStudent.Text = "Student";
      this.tabPageStudent.UseVisualStyleBackColor = true;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(33, 34);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(35, 13);
      this.nameLabel.TabIndex = 30;
      this.nameLabel.Text = "Name";
      // 
      // age
      // 
      this.age.Location = new System.Drawing.Point(88, 112);
      this.age.Name = "age";
      this.age.Size = new System.Drawing.Size(100, 20);
      this.age.TabIndex = 35;
      // 
      // surnameLabel
      // 
      this.surnameLabel.AutoSize = true;
      this.surnameLabel.Location = new System.Drawing.Point(33, 72);
      this.surnameLabel.Name = "surnameLabel";
      this.surnameLabel.Size = new System.Drawing.Size(49, 13);
      this.surnameLabel.TabIndex = 31;
      this.surnameLabel.Text = "Surname";
      // 
      // surname
      // 
      this.surname.Location = new System.Drawing.Point(88, 72);
      this.surname.Name = "surname";
      this.surname.Size = new System.Drawing.Size(100, 20);
      this.surname.TabIndex = 34;
      // 
      // ageLabel
      // 
      this.ageLabel.AutoSize = true;
      this.ageLabel.Location = new System.Drawing.Point(33, 115);
      this.ageLabel.Name = "ageLabel";
      this.ageLabel.Size = new System.Drawing.Size(26, 13);
      this.ageLabel.TabIndex = 32;
      this.ageLabel.Text = "Age";
      // 
      // name
      // 
      this.name.Location = new System.Drawing.Point(88, 34);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(100, 20);
      this.name.TabIndex = 33;
      // 
      // mediumMarkLabel
      // 
      this.mediumMarkLabel.AutoSize = true;
      this.mediumMarkLabel.Location = new System.Drawing.Point(26, 36);
      this.mediumMarkLabel.Name = "mediumMarkLabel";
      this.mediumMarkLabel.Size = new System.Drawing.Size(70, 13);
      this.mediumMarkLabel.TabIndex = 15;
      this.mediumMarkLabel.Text = "Medium mark";
      // 
      // favoriteSubjectLabel
      // 
      this.favoriteSubjectLabel.AutoSize = true;
      this.favoriteSubjectLabel.Location = new System.Drawing.Point(26, 74);
      this.favoriteSubjectLabel.Name = "favoriteSubjectLabel";
      this.favoriteSubjectLabel.Size = new System.Drawing.Size(82, 13);
      this.favoriteSubjectLabel.TabIndex = 16;
      this.favoriteSubjectLabel.Text = "Favorite subject";
      // 
      // favoriteSubject
      // 
      this.favoriteSubject.Location = new System.Drawing.Point(114, 71);
      this.favoriteSubject.Name = "favoriteSubject";
      this.favoriteSubject.Size = new System.Drawing.Size(100, 20);
      this.favoriteSubject.TabIndex = 18;
      // 
      // mediumMark
      // 
      this.mediumMark.Location = new System.Drawing.Point(114, 33);
      this.mediumMark.Name = "mediumMark";
      this.mediumMark.Size = new System.Drawing.Size(36, 20);
      this.mediumMark.TabIndex = 17;
      // 
      // CreateEditStudent
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(443, 290);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.tabControl1);
      this.Name = "CreateEditStudent";
      this.Text = "CreateEditStudent";
      this.tabControl1.ResumeLayout(false);
      this.tabPageUniversity.ResumeLayout(false);
      this.tabPageUniversity.PerformLayout();
      this.tabPageHuman.ResumeLayout(false);
      this.tabPageHuman.PerformLayout();
      this.tabPageStudent.ResumeLayout(false);
      this.tabPageStudent.PerformLayout();
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
    private System.Windows.Forms.TabPage tabPageStudent;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox age;
    private System.Windows.Forms.Label surnameLabel;
    private System.Windows.Forms.TextBox surname;
    private System.Windows.Forms.Label ageLabel;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.Label mediumMarkLabel;
    private System.Windows.Forms.Label favoriteSubjectLabel;
    private System.Windows.Forms.TextBox favoriteSubject;
    private System.Windows.Forms.TextBox mediumMark;
  }
}
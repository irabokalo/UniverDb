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
      this.label4 = new System.Windows.Forms.Label();
      this.tabPageHuman = new System.Windows.Forms.TabPage();
      this.label1 = new System.Windows.Forms.Label();
      this.age = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.surname = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.TextBox();
      this.tabPageStudent = new System.Windows.Forms.TabPage();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
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
      this.tabPageUniversity.Controls.Add(this.label4);
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
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(33, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(30, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Title:";
      // 
      // tabPageHuman
      // 
      this.tabPageHuman.Controls.Add(this.label1);
      this.tabPageHuman.Controls.Add(this.age);
      this.tabPageHuman.Controls.Add(this.label2);
      this.tabPageHuman.Controls.Add(this.surname);
      this.tabPageHuman.Controls.Add(this.label3);
      this.tabPageHuman.Controls.Add(this.name);
      this.tabPageHuman.Location = new System.Drawing.Point(4, 22);
      this.tabPageHuman.Name = "tabPageHuman";
      this.tabPageHuman.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageHuman.Size = new System.Drawing.Size(290, 191);
      this.tabPageHuman.TabIndex = 1;
      this.tabPageHuman.Text = "Human";
      this.tabPageHuman.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "Name";
      // 
      // age
      // 
      this.age.Location = new System.Drawing.Point(92, 110);
      this.age.Name = "age";
      this.age.Size = new System.Drawing.Size(100, 20);
      this.age.TabIndex = 17;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Surname";
      // 
      // surname
      // 
      this.surname.Location = new System.Drawing.Point(92, 70);
      this.surname.Name = "surname";
      this.surname.Size = new System.Drawing.Size(100, 20);
      this.surname.TabIndex = 16;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(37, 113);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Age";
      // 
      // name
      // 
      this.name.Location = new System.Drawing.Point(92, 32);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(100, 20);
      this.name.TabIndex = 15;
      // 
      // tabPageStudent
      // 
      this.tabPageStudent.Controls.Add(this.label5);
      this.tabPageStudent.Controls.Add(this.label6);
      this.tabPageStudent.Controls.Add(this.favoriteSubject);
      this.tabPageStudent.Controls.Add(this.mediumMark);
      this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
      this.tabPageStudent.Name = "tabPageStudent";
      this.tabPageStudent.Size = new System.Drawing.Size(290, 191);
      this.tabPageStudent.TabIndex = 2;
      this.tabPageStudent.Text = "Student";
      this.tabPageStudent.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(33, 35);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(70, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Medium mark";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(33, 73);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(82, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Favorite subject";
      // 
      // favoriteSubject
      // 
      this.favoriteSubject.Location = new System.Drawing.Point(121, 70);
      this.favoriteSubject.Name = "favoriteSubject";
      this.favoriteSubject.Size = new System.Drawing.Size(100, 20);
      this.favoriteSubject.TabIndex = 10;
      // 
      // mediumMark
      // 
      this.mediumMark.Location = new System.Drawing.Point(121, 32);
      this.mediumMark.Name = "mediumMark";
      this.mediumMark.Size = new System.Drawing.Size(36, 20);
      this.mediumMark.TabIndex = 9;
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
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TabPage tabPageHuman;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox age;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox surname;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.TabPage tabPageStudent;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox favoriteSubject;
    private System.Windows.Forms.TextBox mediumMark;
  }
}
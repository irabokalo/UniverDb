namespace UniversityDB.CreateEditForms
{
    partial class CreateEditPractice
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
            this.duration = new System.Windows.Forms.TextBox();
            this.room = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.saveUObject = new System.Windows.Forms.Button();
            this.uTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.homework = new System.Windows.Forms.TextBox();
            this.practice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(399, 123);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(100, 20);
            this.duration.TabIndex = 35;
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(399, 88);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(100, 20);
            this.room.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Pair";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Room number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Duration in minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Object";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(114, 221);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 29;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // saveUObject
            // 
            this.saveUObject.Location = new System.Drawing.Point(20, 221);
            this.saveUObject.Name = "saveUObject";
            this.saveUObject.Size = new System.Drawing.Size(75, 23);
            this.saveUObject.TabIndex = 28;
            this.saveUObject.Text = "Ok";
            this.saveUObject.UseVisualStyleBackColor = true;
            this.saveUObject.Click += new System.EventHandler(this.saveUObject_Click);
            // 
            // uTitle
            // 
            this.uTitle.Location = new System.Drawing.Point(69, 85);
            this.uTitle.Name = "uTitle";
            this.uTitle.Size = new System.Drawing.Size(100, 20);
            this.uTitle.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Practice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Home work";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Practice Task";
            // 
            // homework
            // 
            this.homework.Location = new System.Drawing.Point(611, 85);
            this.homework.Name = "homework";
            this.homework.Size = new System.Drawing.Size(100, 20);
            this.homework.TabIndex = 39;
            // 
            // practice
            // 
            this.practice.Location = new System.Drawing.Point(611, 120);
            this.practice.Name = "practice";
            this.practice.Size = new System.Drawing.Size(100, 20);
            this.practice.TabIndex = 40;
            // 
            // CreateEditPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 264);
            this.Controls.Add(this.practice);
            this.Controls.Add(this.homework);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.saveUObject);
            this.Controls.Add(this.uTitle);
            this.Controls.Add(this.label1);
            this.Name = "CreateEditPractice";
            this.Text = "CreateEditPractice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button saveUObject;
        private System.Windows.Forms.TextBox uTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox homework;
        private System.Windows.Forms.TextBox practice;
    }
}
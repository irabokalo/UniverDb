namespace UniversityDB.CreateEditForms
{
    partial class CreateEditLecture
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
            this.theory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // theory
            // 
            this.theory.Location = new System.Drawing.Point(623, 79);
            this.theory.Name = "theory";
            this.theory.Size = new System.Drawing.Size(100, 20);
            this.theory.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Theory info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Lecture";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(411, 117);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(100, 20);
            this.duration.TabIndex = 50;
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(411, 82);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(100, 20);
            this.room.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Pair";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Room number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Duration in minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Object";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(126, 215);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 44;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // saveUObject
            // 
            this.saveUObject.Location = new System.Drawing.Point(32, 215);
            this.saveUObject.Name = "saveUObject";
            this.saveUObject.Size = new System.Drawing.Size(75, 23);
            this.saveUObject.TabIndex = 43;
            this.saveUObject.Text = "Ok";
            this.saveUObject.UseVisualStyleBackColor = true;
            this.saveUObject.Click += new System.EventHandler(this.saveUObject_Click);
            // 
            // uTitle
            // 
            this.uTitle.Location = new System.Drawing.Point(81, 79);
            this.uTitle.Name = "uTitle";
            this.uTitle.Size = new System.Drawing.Size(100, 20);
            this.uTitle.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Title";
            // 
            // CreateEditLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 256);
            this.Controls.Add(this.theory);
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
            this.Name = "CreateEditLecture";
            this.Text = "CreateEditLecture";
            this.Load += new System.EventHandler(this.CreateEditLecture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox theory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
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
    }
}
﻿namespace UniversityDB.CreateEditForms
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
            this.label5 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.saveUObject = new System.Windows.Forms.Button();
            this.uTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Object";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(114, 218);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 18;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // saveUObject
            // 
            this.saveUObject.Location = new System.Drawing.Point(20, 218);
            this.saveUObject.Name = "saveUObject";
            this.saveUObject.Size = new System.Drawing.Size(75, 23);
            this.saveUObject.TabIndex = 17;
            this.saveUObject.Text = "Ok";
            this.saveUObject.UseVisualStyleBackColor = true;
            this.saveUObject.Click += new System.EventHandler(this.saveUObject_Click);
            // 
            // uTitle
            // 
            this.uTitle.Location = new System.Drawing.Point(69, 82);
            this.uTitle.Name = "uTitle";
            this.uTitle.Size = new System.Drawing.Size(100, 20);
            this.uTitle.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Duration in minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Room number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pair";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(399, 85);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(100, 20);
            this.room.TabIndex = 24;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(399, 120);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(100, 20);
            this.duration.TabIndex = 25;
            // 
            // CreateEditPair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 267);
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
            this.Name = "CreateEditPair";
            this.Text = "CreateEditPair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button saveUObject;
        private System.Windows.Forms.TextBox uTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.TextBox duration;
    }
}
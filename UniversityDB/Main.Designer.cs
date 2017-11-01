namespace UniversityDB
{
    partial class Main
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
            this.tree = new System.Windows.Forms.TreeView();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(112, 26);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(477, 355);
            this.tree.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(249, 407);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(208, 50);
            this.add.TabIndex = 2;
            this.add.Text = "Add new object";
            this.add.UseVisualStyleBackColor = true;
          
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 565);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tree);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Button add;
    }
}


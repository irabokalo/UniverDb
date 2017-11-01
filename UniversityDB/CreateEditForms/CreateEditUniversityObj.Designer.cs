namespace UniversityDB.CreateEditForms
{
    partial class CreateEditUniversityObj
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.UniverObj = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.UniverObj.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UniverObj
            // 
            this.UniverObj.Controls.Add(this.textBox1);
            this.UniverObj.Controls.Add(this.label1);
            this.UniverObj.Location = new System.Drawing.Point(4, 22);
            this.UniverObj.Name = "UniverObj";
            this.UniverObj.Padding = new System.Windows.Forms.Padding(3);
            this.UniverObj.Size = new System.Drawing.Size(459, 207);
            this.UniverObj.TabIndex = 0;
            this.UniverObj.Text = "University Object";
            this.UniverObj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UniverObj);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 233);
            this.tabControl1.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(138, 248);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreateEditUniversityObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateEditUniversityObj";
            this.Text = "CreateEditUniversityObj";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.UniverObj.ResumeLayout(false);
            this.UniverObj.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage UniverObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button button2;
    }
}
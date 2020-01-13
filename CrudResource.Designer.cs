namespace Session1
{
    partial class CrudResource
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resname_box = new System.Windows.Forms.TextBox();
            this.restype_combo = new System.Windows.Forms.ComboBox();
            this.CS = new System.Windows.Forms.CheckBox();
            this.SSB = new System.Windows.Forms.CheckBox();
            this.NSA = new System.Windows.Forms.CheckBox();
            this.WT = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.done_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resource Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Allocated Skill (s):";
            // 
            // resname_box
            // 
            this.resname_box.Location = new System.Drawing.Point(165, 34);
            this.resname_box.Name = "resname_box";
            this.resname_box.Size = new System.Drawing.Size(226, 22);
            this.resname_box.TabIndex = 4;
            // 
            // restype_combo
            // 
            this.restype_combo.FormattingEnabled = true;
            this.restype_combo.Location = new System.Drawing.Point(165, 69);
            this.restype_combo.Name = "restype_combo";
            this.restype_combo.Size = new System.Drawing.Size(121, 24);
            this.restype_combo.TabIndex = 7;
            // 
            // CS
            // 
            this.CS.AutoSize = true;
            this.CS.Location = new System.Drawing.Point(165, 138);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(122, 21);
            this.CS.TabIndex = 8;
            this.CS.Text = "Cyber Security";
            this.CS.UseVisualStyleBackColor = true;
            // 
            // SSB
            // 
            this.SSB.AutoSize = true;
            this.SSB.Location = new System.Drawing.Point(165, 165);
            this.SSB.Name = "SSB";
            this.SSB.Size = new System.Drawing.Size(147, 21);
            this.SSB.TabIndex = 9;
            this.SSB.Text = "Software Solutions";
            this.SSB.UseVisualStyleBackColor = true;
            // 
            // NSA
            // 
            this.NSA.AutoSize = true;
            this.NSA.Location = new System.Drawing.Point(165, 192);
            this.NSA.Name = "NSA";
            this.NSA.Size = new System.Drawing.Size(100, 21);
            this.NSA.TabIndex = 10;
            this.NSA.Text = "Networking";
            this.NSA.UseVisualStyleBackColor = true;
            // 
            // WT
            // 
            this.WT.AutoSize = true;
            this.WT.Location = new System.Drawing.Point(165, 219);
            this.WT.Name = "WT";
            this.WT.Size = new System.Drawing.Size(137, 21);
            this.WT.TabIndex = 11;
            this.WT.Text = "Web Technology";
            this.WT.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(166, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(211, 246);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(159, 62);
            this.done_button.TabIndex = 13;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(46, 246);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(159, 62);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "Cancel";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // CrudResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.WT);
            this.Controls.Add(this.NSA);
            this.Controls.Add(this.SSB);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.restype_combo);
            this.Controls.Add(this.resname_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrudResource";
            this.Text = "CrudResource";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resname_box;
        private System.Windows.Forms.ComboBox restype_combo;
        private System.Windows.Forms.CheckBox CS;
        private System.Windows.Forms.CheckBox SSB;
        private System.Windows.Forms.CheckBox NSA;
        private System.Windows.Forms.CheckBox WT;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_button;
    }
}
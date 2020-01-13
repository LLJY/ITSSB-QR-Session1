namespace Session1
{
    partial class CreateAccount
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.user_id_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.password_again_box = new System.Windows.Forms.TextBox();
            this.usertype_combo = new System.Windows.Forms.ComboBox();
            this.create_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Account Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID (For login) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Re-Enter Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "User Type : ";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(166, 57);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(120, 22);
            this.username_box.TabIndex = 6;
            // 
            // user_id_box
            // 
            this.user_id_box.Location = new System.Drawing.Point(166, 98);
            this.user_id_box.Name = "user_id_box";
            this.user_id_box.Size = new System.Drawing.Size(120, 22);
            this.user_id_box.TabIndex = 7;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(166, 138);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(120, 22);
            this.password_box.TabIndex = 8;
            // 
            // password_again_box
            // 
            this.password_again_box.Location = new System.Drawing.Point(165, 180);
            this.password_again_box.Name = "password_again_box";
            this.password_again_box.Size = new System.Drawing.Size(121, 22);
            this.password_again_box.TabIndex = 9;
            // 
            // usertype_combo
            // 
            this.usertype_combo.FormattingEnabled = true;
            this.usertype_combo.Location = new System.Drawing.Point(165, 223);
            this.usertype_combo.Name = "usertype_combo";
            this.usertype_combo.Size = new System.Drawing.Size(121, 24);
            this.usertype_combo.TabIndex = 11;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(281, 305);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(223, 56);
            this.create_button.TabIndex = 12;
            this.create_button.Text = "Create Account";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(-1, -2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(132, 38);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.usertype_combo);
            this.Controls.Add(this.password_again_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.user_id_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "ASEAN Skills 2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox user_id_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox password_again_box;
        private System.Windows.Forms.ComboBox usertype_combo;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button back_button;
    }
}
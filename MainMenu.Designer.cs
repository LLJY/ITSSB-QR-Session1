namespace Session1
{
    partial class MainMenu
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
            this.create_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(290, 171);
            this.create_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(243, 75);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "Create New Account";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(290, 250);
            this.login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(243, 76);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Resource Manager Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 68);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(287, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 52);
            this.label7.TabIndex = 29;
            this.label7.Text = "ASEAN Skills \r\n2020 26-28 Jul 2020";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(2, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 48);
            this.panel2.TabIndex = 19;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.create_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "ASEAN Skills 2020 26 - 28 Jul 2020";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}


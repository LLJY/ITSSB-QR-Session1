namespace Session1
{
    partial class ResourceManagementForm
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
            this.skillcombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter by Skill";
            // 
            // skillcombo
            // 
            this.skillcombo.FormattingEnabled = true;
            this.skillcombo.Location = new System.Drawing.Point(142, 126);
            this.skillcombo.Margin = new System.Windows.Forms.Padding(2);
            this.skillcombo.Name = "skillcombo";
            this.skillcombo.Size = new System.Drawing.Size(92, 21);
            this.skillcombo.TabIndex = 4;
            this.skillcombo.SelectedIndexChanged += new System.EventHandler(this.Skillcombo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 233);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(521, 404);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(72, 29);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(445, 404);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(72, 29);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(11, 405);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(62, 29);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // type_combo
            // 
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Location = new System.Drawing.Point(142, 96);
            this.type_combo.Margin = new System.Windows.Forms.Padding(2);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(92, 21);
            this.type_combo.TabIndex = 11;
            this.type_combo.SelectedIndexChanged += new System.EventHandler(this.Type_combo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 48);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "ASEAN Skills 2020";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 48);
            this.panel2.TabIndex = 19;
            // 
            // ResourceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skillcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResourceManagementForm";
            this.Text = "ASEAN SKILLS 2020";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox skillcombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}
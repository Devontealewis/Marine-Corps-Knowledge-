namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.MK19pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.M2pictureBox = new System.Windows.Forms.PictureBox();
            this.M240pictureBox = new System.Windows.Forms.PictureBox();
            this.SawpictureBox = new System.Windows.Forms.PictureBox();
            this.M16pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MK19pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M240pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SawpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M16pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.M16pictureBox);
            this.tabPage1.Controls.Add(this.SawpictureBox);
            this.tabPage1.Controls.Add(this.M240pictureBox);
            this.tabPage1.Controls.Add(this.M2pictureBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.MK19pictureBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weapon Systems";
            this.tabPage1.UseVisualStyleBackColor = true;
    
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(29, 332);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // MK19pictureBox
            // 
            this.MK19pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MK19pictureBox.Image")));
            this.MK19pictureBox.Location = new System.Drawing.Point(249, 29);
            this.MK19pictureBox.Name = "MK19pictureBox";
            this.MK19pictureBox.Size = new System.Drawing.Size(397, 194);
            this.MK19pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MK19pictureBox.TabIndex = 10;
            this.MK19pictureBox.TabStop = false;
            this.MK19pictureBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fire Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Effective Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Range";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(144, 326);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Weapons ";
            this.Column1.Name = "Column1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(336, 342);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(310, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(336, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // M2pictureBox
            // 
            this.M2pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("M2pictureBox.Image")));
            this.M2pictureBox.Location = new System.Drawing.Point(249, 29);
            this.M2pictureBox.Name = "M2pictureBox";
            this.M2pictureBox.Size = new System.Drawing.Size(397, 194);
            this.M2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M2pictureBox.TabIndex = 13;
            this.M2pictureBox.TabStop = false;
            // 
            // M240pictureBox
            // 
            this.M240pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("M240pictureBox.Image")));
            this.M240pictureBox.Location = new System.Drawing.Point(249, 29);
            this.M240pictureBox.Name = "M240pictureBox";
            this.M240pictureBox.Size = new System.Drawing.Size(397, 194);
            this.M240pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M240pictureBox.TabIndex = 14;
            this.M240pictureBox.TabStop = false;
            // 
            // SawpictureBox
            // 
            this.SawpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SawpictureBox.Image")));
            this.SawpictureBox.Location = new System.Drawing.Point(249, 29);
            this.SawpictureBox.Name = "SawpictureBox";
            this.SawpictureBox.Size = new System.Drawing.Size(397, 194);
            this.SawpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SawpictureBox.TabIndex = 15;
            this.SawpictureBox.TabStop = false;
            // 
            // M16pictureBox
            // 
            this.M16pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("M16pictureBox.Image")));
            this.M16pictureBox.Location = new System.Drawing.Point(249, 29);
            this.M16pictureBox.Name = "M16pictureBox";
            this.M16pictureBox.Size = new System.Drawing.Size(397, 194);
            this.M16pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.M16pictureBox.TabIndex = 16;
            this.M16pictureBox.TabStop = false;
            this.M16pictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MK19pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M240pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SawpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M16pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox MK19pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox M2pictureBox;
        private System.Windows.Forms.PictureBox M16pictureBox;
        private System.Windows.Forms.PictureBox SawpictureBox;
        private System.Windows.Forms.PictureBox M240pictureBox;
    }
}


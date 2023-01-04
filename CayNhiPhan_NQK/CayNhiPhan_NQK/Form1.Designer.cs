namespace CayNhiPhan_NQK
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btPrintf = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btRandom = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.txtPrintf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(179, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.btPrintf);
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.btInsert);
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.txtInsert);
            this.panel1.Controls.Add(this.btRandom);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(824, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 531);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Chọn Kiểu Duyệt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nhập Giá Trị Node Cần Tìm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nhập Giá Trị Node Cần Xoá";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nhập Giá Trị Node Cần Thêm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(102, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nhập Số Node Cần Tạo Ngẫu Nhiên (<20)";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Duyệt Trước",
            "Duyệt Giữa",
            "Duyệt Sau"});
            this.comboBox2.Location = new System.Drawing.Point(105, 309);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btPrintf
            // 
            this.btPrintf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrintf.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btPrintf.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintf.ForeColor = System.Drawing.Color.White;
            this.btPrintf.Location = new System.Drawing.Point(136, 335);
            this.btPrintf.Name = "btPrintf";
            this.btPrintf.Size = new System.Drawing.Size(109, 42);
            this.btPrintf.TabIndex = 21;
            this.btPrintf.Text = "Duyệt cây";
            this.btPrintf.UseVisualStyleBackColor = false;
            this.btPrintf.Click += new System.EventHandler(this.btPrintf_Click);
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFind.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.Color.White;
            this.btFind.Location = new System.Drawing.Point(123, 440);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(144, 29);
            this.btFind.TabIndex = 19;
            this.btFind.Text = "Tìm Kiếm";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(105, 414);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(175, 20);
            this.txtFind.TabIndex = 20;
            // 
            // btdelete
            // 
            this.btdelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btdelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btdelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.Color.White;
            this.btdelete.Location = new System.Drawing.Point(276, 240);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 27);
            this.btdelete.TabIndex = 18;
            this.btdelete.Text = "Xóa";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btInsert
            // 
            this.btInsert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btInsert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btInsert.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.ForeColor = System.Drawing.Color.White;
            this.btInsert.Location = new System.Drawing.Point(276, 190);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 27);
            this.btInsert.TabIndex = 17;
            this.btInsert.Text = "Thêm ";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelete.Location = new System.Drawing.Point(53, 245);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(208, 20);
            this.txtDelete.TabIndex = 16;
            // 
            // txtInsert
            // 
            this.txtInsert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsert.Location = new System.Drawing.Point(53, 193);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(208, 20);
            this.txtInsert.TabIndex = 15;
            // 
            // btRandom
            // 
            this.btRandom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btRandom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRandom.ForeColor = System.Drawing.Color.White;
            this.btRandom.Location = new System.Drawing.Point(134, 96);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(111, 31);
            this.btRandom.TabIndex = 14;
            this.btRandom.Text = "Tạo ngẫu nhiên";
            this.btRandom.UseVisualStyleBackColor = false;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(134, 133);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(111, 31);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Xóa cây";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtPrintf
            // 
            this.txtPrintf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrintf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrintf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrintf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintf.ForeColor = System.Drawing.Color.White;
            this.txtPrintf.Location = new System.Drawing.Point(15, 493);
            this.txtPrintf.Name = "txtPrintf";
            this.txtPrintf.ReadOnly = true;
            this.txtPrintf.Size = new System.Drawing.Size(806, 26);
            this.txtPrintf.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kết Quả Sau Khi Duyệt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cây Nhị Phân";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 531);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrintf);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cây Nhị Phân";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btPrintf;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox txtPrintf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


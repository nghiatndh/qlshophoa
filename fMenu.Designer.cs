namespace WinFormsApp2
{
    partial class fMenu
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
            panel1 = new Panel();
            dgvHoaDon = new DataGridView();
            panel2 = new Panel();
            dgvSP = new DataGridView();
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            btnThanhToan = new Button();
            btnXoaSP = new Button();
            panel4 = new Panel();
            textBox1 = new TextBox();
            btnThemSP = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvHoaDon);
            panel1.Location = new Point(3, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 402);
            panel1.TabIndex = 0;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(2, 3);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(591, 395);
            dgvHoaDon.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvSP);
            panel2.Location = new Point(605, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 392);
            panel2.TabIndex = 1;
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(1, 7);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.RowTemplate.Height = 29;
            dgvSP.Size = new Size(296, 381);
            dgvSP.TabIndex = 0;
            dgvSP.CellContentClick += dgvSP_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, đơnHàngToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kháchHàngToolStripMenuItem });
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(88, 24);
            đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(169, 26);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThanhToan);
            panel3.Location = new Point(0, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 40);
            panel3.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(2, 1);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(297, 36);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "button1";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(199, 30);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(94, 29);
            btnXoaSP.TabIndex = 1;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(btnThemSP);
            panel4.Controls.Add(btnXoaSP);
            panel4.Location = new Point(607, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 62);
            panel4.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 3;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(199, 3);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(94, 29);
            btnThemSP.TabIndex = 2;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 506);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMenu";
            Text = "Phần mềm quản lý shop bán hoa";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ListView listView1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private Panel panel3;
        private Button button3;
        private Button btnXoaSP;
        private Button button1;
        private Panel panel4;
        private Button btnThemSP;
        private DataGridView dgvSP;
        private TextBox textBox1;
        private DataGridView dgvHoaDon;
        private Button btnThanhToan;
        private Label label1;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
    }
}
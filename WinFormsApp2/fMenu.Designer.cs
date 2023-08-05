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
            dgvIDK = new DataGridView();
            panel2 = new Panel();
            dgvSP = new DataGridView();
            menuStrip1 = new MenuStrip();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            btnThanhToan = new Button();
            btnXoaSP = new Button();
            panel4 = new Panel();
            txbTim = new TextBox();
            btnTim = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIDK).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvIDK);
            panel1.Location = new Point(3, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 402);
            panel1.TabIndex = 0;
            // 
            // dgvIDK
            // 
            dgvIDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIDK.Location = new Point(6, 0);
            dgvIDK.Name = "dgvIDK";
            dgvIDK.RowHeadersWidth = 51;
            dgvIDK.RowTemplate.Height = 29;
            dgvIDK.Size = new Size(588, 392);
            dgvIDK.TabIndex = 0;
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
            dgvSP.CellDoubleClick += dgvSP_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { đơnHàngToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
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
            kháchHàngToolStripMenuItem.Size = new Size(224, 26);
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
            btnXoaSP.Location = new Point(500, 435);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(94, 59);
            btnXoaSP.TabIndex = 1;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTim);
            panel4.Controls.Add(txbTim);
            panel4.Location = new Point(607, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 62);
            panel4.TabIndex = 5;
            // 
            // txbTim
            // 
            txbTim.Location = new Point(0, 16);
            txbTim.Name = "txbTim";
            txbTim.Size = new Size(193, 27);
            txbTim.TabIndex = 3;
            txbTim.Text = " ";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(206, 8);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(81, 48);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 506);
            Controls.Add(panel4);
            Controls.Add(btnXoaSP);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMenu";
            Text = "Phần mềm quản lý shop bán hoa";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIDK).EndInit();
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
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private Panel panel3;
        private Button button3;
        private Button btnXoaSP;
        private Button btnTim;
        private Panel panel4;
        private DataGridView dgvSP;
        private TextBox txbTim;
        private Button btnThanhToan;
        private Label label1;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private DataGridView dgvIDK;
    }
}
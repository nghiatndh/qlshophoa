namespace WinFormsApp2
{
    partial class fAccount
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
            panel2 = new Panel();
            txbDangNhap = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbTen = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbMatKhau = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewMatKhau = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbNhapLaiMatKhau = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnQuit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbDangNhap);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 47);
            panel2.TabIndex = 1;
            // 
            // txbDangNhap
            // 
            txbDangNhap.Location = new Point(274, 16);
            txbDangNhap.Name = "txbDangNhap";
            txbDangNhap.ReadOnly = true;
            txbDangNhap.Size = new Size(346, 27);
            txbDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTen);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 47);
            panel1.TabIndex = 2;
            // 
            // txbTen
            // 
            txbTen.Location = new Point(274, 16);
            txbTen.Name = "txbTen";
            txbTen.Size = new Size(346, 27);
            txbTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMatKhau);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 47);
            panel3.TabIndex = 3;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(274, 17);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(346, 27);
            txbMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(116, 31);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewMatKhau);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 223);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 47);
            panel4.TabIndex = 4;
            // 
            // txbNewMatKhau
            // 
            txbNewMatKhau.Location = new Point(274, 16);
            txbNewMatKhau.Name = "txbNewMatKhau";
            txbNewMatKhau.Size = new Size(346, 27);
            txbNewMatKhau.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbNhapLaiMatKhau);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 294);
            panel5.Name = "panel5";
            panel5.Size = new Size(623, 47);
            panel5.TabIndex = 5;
            // 
            // txbNhapLaiMatKhau
            // 
            txbNhapLaiMatKhau.Location = new Point(274, 17);
            txbNhapLaiMatKhau.Name = "txbNhapLaiMatKhau";
            txbNhapLaiMatKhau.Size = new Size(346, 27);
            txbNhapLaiMatKhau.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(211, 31);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(516, 369);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(631, 369);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Thoát";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 410);
            Controls.Add(btnQuit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccount";
            Text = "Account";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbDangNhap;
        private Label label1;
        private Panel panel1;
        private TextBox txbTen;
        private Label label2;
        private Panel panel3;
        private TextBox txbMatKhau;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewMatKhau;
        private Label label4;
        private Panel panel5;
        private TextBox txbNhapLaiMatKhau;
        private Label label5;
        private Button btnUpdate;
        private Button btnQuit;
    }
}
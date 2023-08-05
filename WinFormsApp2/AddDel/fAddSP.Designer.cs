namespace WinFormsApp2
{
    partial class fAddSP
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
            panel2 = new Panel();
            nmSLHoa = new NumericUpDown();
            label7 = new Label();
            btnAdd = new Button();
            panel44 = new Panel();
            label24 = new Label();
            cbxMaNCC = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            cbxMaKho = new ComboBox();
            cbxMaLoai = new ComboBox();
            panel11 = new Panel();
            txbMoTaHoa = new TextBox();
            label6 = new Label();
            panel10 = new Panel();
            txbSizeHoa = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            nmGiaHoa = new NumericUpDown();
            label4 = new Label();
            panel8 = new Panel();
            txbTenHoa = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            txbMaHoa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmSLHoa).BeginInit();
            panel44.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmGiaHoa).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panel44);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 437);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmSLHoa);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(7, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 47);
            panel2.TabIndex = 5;
            // 
            // nmSLHoa
            // 
            nmSLHoa.Location = new Point(127, 14);
            nmSLHoa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmSLHoa.Name = "nmSLHoa";
            nmSLHoa.Size = new Size(242, 27);
            nmSLHoa.TabIndex = 1;
            nmSLHoa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 14);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 0;
            label7.Text = "Số lượng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(698, 377);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 55);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel44
            // 
            panel44.Controls.Add(label24);
            panel44.Controls.Add(cbxMaNCC);
            panel44.Controls.Add(label23);
            panel44.Controls.Add(label22);
            panel44.Controls.Add(cbxMaKho);
            panel44.Controls.Add(cbxMaLoai);
            panel44.Location = new Point(412, 149);
            panel44.Name = "panel44";
            panel44.Size = new Size(371, 179);
            panel44.TabIndex = 6;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(3, 122);
            label24.Name = "label24";
            label24.Size = new Size(59, 31);
            label24.TabIndex = 5;
            label24.Text = "NCC";
            // 
            // cbxMaNCC
            // 
            cbxMaNCC.FormattingEnabled = true;
            cbxMaNCC.Location = new Point(108, 121);
            cbxMaNCC.Name = "cbxMaNCC";
            cbxMaNCC.Size = new Size(111, 28);
            cbxMaNCC.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(3, 61);
            label23.Name = "label23";
            label23.Size = new Size(57, 31);
            label23.TabIndex = 4;
            label23.Text = "Kho";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(3, 3);
            label22.Name = "label22";
            label22.Size = new Size(59, 31);
            label22.TabIndex = 3;
            label22.Text = "Loại";
            // 
            // cbxMaKho
            // 
            cbxMaKho.FormattingEnabled = true;
            cbxMaKho.Location = new Point(108, 61);
            cbxMaKho.Name = "cbxMaKho";
            cbxMaKho.Size = new Size(111, 28);
            cbxMaKho.TabIndex = 1;
            // 
            // cbxMaLoai
            // 
            cbxMaLoai.FormattingEnabled = true;
            cbxMaLoai.Location = new Point(108, 6);
            cbxMaLoai.Name = "cbxMaLoai";
            cbxMaLoai.Size = new Size(111, 28);
            cbxMaLoai.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(txbMoTaHoa);
            panel11.Controls.Add(label6);
            panel11.Location = new Point(7, 351);
            panel11.Name = "panel11";
            panel11.Size = new Size(378, 47);
            panel11.TabIndex = 4;
            // 
            // txbMoTaHoa
            // 
            txbMoTaHoa.Location = new Point(118, 16);
            txbMoTaHoa.Name = "txbMoTaHoa";
            txbMoTaHoa.Size = new Size(254, 27);
            txbMoTaHoa.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(77, 31);
            label6.TabIndex = 0;
            label6.Text = "Mô tả";
            // 
            // panel10
            // 
            panel10.Controls.Add(txbSizeHoa);
            panel10.Controls.Add(label5);
            panel10.Location = new Point(7, 298);
            panel10.Name = "panel10";
            panel10.Size = new Size(378, 47);
            panel10.TabIndex = 5;
            // 
            // txbSizeHoa
            // 
            txbSizeHoa.Location = new Point(149, 16);
            txbSizeHoa.Name = "txbSizeHoa";
            txbSizeHoa.Size = new Size(223, 27);
            txbSizeHoa.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(130, 31);
            label5.TabIndex = 0;
            label5.Text = "Kích thước";
            // 
            // panel9
            // 
            panel9.Controls.Add(nmGiaHoa);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(7, 202);
            panel9.Name = "panel9";
            panel9.Size = new Size(378, 47);
            panel9.TabIndex = 4;
            // 
            // nmGiaHoa
            // 
            nmGiaHoa.Location = new Point(127, 14);
            nmGiaHoa.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nmGiaHoa.Minimum = new decimal(new int[] { 20000, 0, 0, 0 });
            nmGiaHoa.Name = "nmGiaHoa";
            nmGiaHoa.Size = new Size(242, 27);
            nmGiaHoa.TabIndex = 1;
            nmGiaHoa.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(49, 31);
            label4.TabIndex = 0;
            label4.Text = "Giá";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbTenHoa);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(7, 149);
            panel8.Name = "panel8";
            panel8.Size = new Size(378, 47);
            panel8.TabIndex = 3;
            // 
            // txbTenHoa
            // 
            txbTenHoa.Location = new Point(124, 16);
            txbTenHoa.Name = "txbTenHoa";
            txbTenHoa.Size = new Size(248, 27);
            txbTenHoa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(101, 31);
            label3.TabIndex = 0;
            label3.Text = "Tên Hoa";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbMaHoa);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(7, 87);
            panel7.Name = "panel7";
            panel7.Size = new Size(378, 47);
            panel7.TabIndex = 2;
            // 
            // txbMaHoa
            // 
            txbMaHoa.Location = new Point(124, 16);
            txbMaHoa.Name = "txbMaHoa";
            txbMaHoa.Size = new Size(248, 27);
            txbMaHoa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 0;
            label2.Text = "Mã Hoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 18);
            label1.Name = "label1";
            label1.Size = new Size(435, 46);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin sản phẩm:";
            // 
            // fAddSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "fAddSP";
            Text = "fAddSP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmSLHoa).EndInit();
            panel44.ResumeLayout(false);
            panel44.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmGiaHoa).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel7;
        private TextBox txbMaHoa;
        private Label label2;
        private Panel panel8;
        private TextBox txbTenHoa;
        private Label label3;
        private Panel panel9;
        private NumericUpDown nmGiaHoa;
        private Label label4;
        private Panel panel10;
        private TextBox txbSizeHoa;
        private Label label5;
        private Panel panel11;
        private TextBox txbMoTaHoa;
        private Label label6;
        private Panel panel44;
        private Label label24;
        private ComboBox cbxMaNCC;
        private Label label23;
        private Label label22;
        private ComboBox cbxMaKho;
        private ComboBox cbxMaLoai;
        private Button btnAdd;
        private Panel panel2;
        private NumericUpDown nmSLHoa;
        private Label label7;
    }
}
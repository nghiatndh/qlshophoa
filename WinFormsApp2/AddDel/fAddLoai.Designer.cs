namespace WinFormsApp2.AddDel
{
    partial class fAddLoai
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txbMoTa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbTenLoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbMaLoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnAdd);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Location = new System.Drawing.Point(12, 103);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(776, 335);
            this.panel12.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(660, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 55);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txbMoTa);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Location = new System.Drawing.Point(32, 169);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(378, 47);
            this.panel13.TabIndex = 3;
            // 
            // txbMoTa
            // 
            this.txbMoTa.Location = new System.Drawing.Point(118, 16);
            this.txbMoTa.Name = "txbMoTa";
            this.txbMoTa.Size = new System.Drawing.Size(254, 27);
            this.txbMoTa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mô tả";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txbTenLoai);
            this.panel16.Controls.Add(this.label9);
            this.panel16.Location = new System.Drawing.Point(32, 100);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(378, 47);
            this.panel16.TabIndex = 2;
            // 
            // txbTenLoai
            // 
            this.txbTenLoai.Location = new System.Drawing.Point(124, 16);
            this.txbTenLoai.Name = "txbTenLoai";
            this.txbTenLoai.Size = new System.Drawing.Size(248, 27);
            this.txbTenLoai.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Loại";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txbMaLoai);
            this.panel17.Controls.Add(this.label10);
            this.panel17.Location = new System.Drawing.Point(32, 21);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(378, 47);
            this.panel17.TabIndex = 1;
            // 
            // txbMaLoai
            // 
            this.txbMaLoai.Location = new System.Drawing.Point(124, 16);
            this.txbMaLoai.Name = "txbMaLoai";
            this.txbMaLoai.Size = new System.Drawing.Size(248, 27);
            this.txbMaLoai.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập thông tin loại:";
            // 
            // fAddLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel12);
            this.Name = "fAddLoai";
            this.Text = "Form1";
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel12;
        private Panel panel13;
        private TextBox txbMoTa;
        private Label label6;
        private Panel panel16;
        private TextBox txbTenLoai;
        private Label label9;
        private Panel panel17;
        private TextBox txbMaLoai;
        private Label label10;
        private Label label1;
        private Button btnAdd;
    }
}
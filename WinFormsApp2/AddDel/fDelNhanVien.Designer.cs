namespace WinFormsApp2.AddDel
{
    partial class fDelNhanVien
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
            this.panel38 = new System.Windows.Forms.Panel();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel38.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txbMaNV);
            this.panel38.Controls.Add(this.label19);
            this.panel38.Location = new System.Drawing.Point(133, 97);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(413, 62);
            this.panel38.TabIndex = 2;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(124, 16);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(248, 27);
            this.txbMaNV.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(3, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mã NV";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(585, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 55);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập mã nhân viên muốn xóa:";
            // 
            // fDelNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel38);
            this.Name = "fDelNhanVien";
            this.Text = "fDelNhanVien";
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel38;
        private TextBox txbMaNV;
        private Label label19;
        private Button btnDelete;
        private Label label1;
    }
}
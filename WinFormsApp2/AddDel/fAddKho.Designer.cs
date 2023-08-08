namespace WinFormsApp2.AddDel
{
    partial class fAddKho
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
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.txbTenKho = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.txbMaKho = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel27.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel31.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btnAdd);
            this.panel27.Controls.Add(this.panel30);
            this.panel27.Controls.Add(this.panel31);
            this.panel27.Location = new System.Drawing.Point(12, 123);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(776, 304);
            this.panel27.TabIndex = 4;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.txbTenKho);
            this.panel30.Controls.Add(this.label15);
            this.panel30.Location = new System.Drawing.Point(0, 86);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(378, 47);
            this.panel30.TabIndex = 2;
            // 
            // txbTenKho
            // 
            this.txbTenKho.Location = new System.Drawing.Point(124, 16);
            this.txbTenKho.Name = "txbTenKho";
            this.txbTenKho.Size = new System.Drawing.Size(248, 27);
            this.txbTenKho.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 31);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tên Kho";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.txbMaKho);
            this.panel31.Controls.Add(this.label16);
            this.panel31.Location = new System.Drawing.Point(0, 21);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(378, 47);
            this.panel31.TabIndex = 1;
            // 
            // txbMaKho
            // 
            this.txbMaKho.Location = new System.Drawing.Point(124, 16);
            this.txbMaKho.Name = "txbMaKho";
            this.txbMaKho.Size = new System.Drawing.Size(248, 27);
            this.txbMaKho.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(3, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã Kho";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(684, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 55);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập thông tin kho:";
            // 
            // fAddKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel27);
            this.Name = "fAddKho";
            this.Text = "Form1";
            this.panel27.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel27;
        private Panel panel30;
        private TextBox txbTenKho;
        private Label label15;
        private Panel panel31;
        private TextBox txbMaKho;
        private Label label16;
        private Button btnAdd;
        private Label label1;
    }
}
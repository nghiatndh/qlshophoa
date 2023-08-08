namespace WinFormsApp2.AddDel
{
    partial class fDelLoai
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
            panel7 = new Panel();
            txbMaLoai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            panel1 = new Panel();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(txbMaLoai);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(133, 73);
            panel7.Name = "panel7";
            panel7.Size = new Size(486, 47);
            panel7.TabIndex = 3;
            // 
            // txbMaLoai
            // 
            txbMaLoai.Location = new Point(124, 16);
            txbMaLoai.Name = "txbMaLoai";
            txbMaLoai.Size = new Size(346, 27);
            txbMaLoai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(99, 31);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 8);
            label1.Name = "label1";
            label1.Size = new Size(398, 45);
            label1.TabIndex = 4;
            label1.Text = "Nhập mã loại muốn xóa:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(623, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 55);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel7);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 206);
            panel1.TabIndex = 9;
            // 
            // fDelLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 207);
            Controls.Add(panel1);
            Name = "fDelLoai";
            Text = "fDelLoai";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TextBox txbMaLoai;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Panel panel1;
    }
}
namespace WinFormsApp2
{
    partial class fDelSP
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
            btnDelete = new Button();
            panel7 = new Panel();
            txbMaHoa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 224);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(457, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 55);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(txbMaHoa);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(45, 79);
            panel7.Name = "panel7";
            panel7.Size = new Size(486, 47);
            panel7.TabIndex = 2;
            // 
            // txbMaHoa
            // 
            txbMaHoa.Location = new Point(124, 16);
            txbMaHoa.Name = "txbMaHoa";
            txbMaHoa.Size = new Size(346, 27);
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
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(504, 46);
            label1.TabIndex = 0;
            label1.Text = "Nhập mã sản phẩm muốn xóa:";
            // 
            // fDelSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 227);
            Controls.Add(panel1);
            Name = "fDelSP";
            Text = "fDelSP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Panel panel7;
        private TextBox txbMaHoa;
        private Label label2;
        private Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.DAO;

namespace WinFormsApp2.AddDel
{
    public partial class fDelKho : Form
    {
        public fDelKho()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbMaKho.Text;
            if (KhoHangDAO.Instance.DeleteKhoHangByID(id))
            {
                MessageBox.Show("Xóa kho hàng thành công! ");
            }
            else
            {
                MessageBox.Show("Không tồn tại kho hàng này");
            }
        }

        private Panel panel1;
        private Button btnDelete;
        private Panel panel31;
        private TextBox txbMaKho;
        private Label label16;
        private Label label1;

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDelete = new Button();
            label1 = new Label();
            panel31 = new Panel();
            txbMaKho = new TextBox();
            label16 = new Label();
            panel1.SuspendLayout();
            panel31.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel31);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 206);
            panel1.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(623, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 55);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 8);
            label1.Name = "label1";
            label1.Size = new Size(400, 45);
            label1.TabIndex = 4;
            label1.Text = "Nhập mã kho muốn xóa:";
            // 
            // panel31
            // 
            panel31.Controls.Add(txbMaKho);
            panel31.Controls.Add(label16);
            panel31.Location = new Point(153, 69);
            panel31.Name = "panel31";
            panel31.Size = new Size(378, 47);
            panel31.TabIndex = 9;
            // 
            // txbMaKho
            // 
            txbMaKho.Location = new Point(124, 16);
            txbMaKho.Name = "txbMaKho";
            txbMaKho.Size = new Size(248, 27);
            txbMaKho.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(3, 16);
            label16.Name = "label16";
            label16.Size = new Size(97, 31);
            label16.TabIndex = 0;
            label16.Text = "Mã Kho";
            // 
            // fDelKho
            // 
            ClientSize = new Size(742, 211);
            Controls.Add(panel1);
            Name = "fDelKho";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            ResumeLayout(false);
        }
    }
}

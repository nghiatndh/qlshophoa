using WinFormsApp2.DAO;

namespace WinFormsApp2
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbDangNhap.Text;
            string passWord = txbMatKhau.Text;
            if (Login(userName,passWord))   
            {
                fMenu f = new fMenu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. ", "Thông báo", MessageBoxButtons.OK);
            }
           
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn thoát chương trình ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }
    }
}
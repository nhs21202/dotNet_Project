namespace Res_1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Tạo Database trong SQL
            if (MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                LogInMessage.Show("Invalid Username or Password");
                return;
            }

            else
            {

                LogInMessage.Show("Log In Successfully !");
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }


        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else txtPass.UseSystemPasswordChar = true;
        }
    }
}
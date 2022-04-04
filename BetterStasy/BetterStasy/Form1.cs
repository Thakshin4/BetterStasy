namespace BetterStasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txb.Text.Equals("a") && password_txb.Text.Equals("123"))
            {
                this.Hide();

                Form3 f = new Form3();
                f.ShowDialog();
            }
            else
            {
                error_lbl.Text = "Username or Password is Incorrect";
            }
        }
    }
}
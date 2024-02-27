namespace CRUD
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account User: Nova , Password: Code123");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;

            if (user == "Nova" && pass == "Code123")
            {
                MessageBox.Show("Bienvenido " + user + ".");
                Menu formulario = new Menu();//Create the other window
                this.Hide();//hide Form1
                formulario.ShowDialog();//Show Form2
                //ShowDialog stop all activity in Form1 and show the other form
            }
            else
            {
                MessageBox.Show("Datos invalidos.");
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
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
                Form2 formulario = new Form2();//Create the other window
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void singupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            this.Hide();
            form.ShowDialog();
        }

        private void cREATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CREATE create = new CREATE();
            create.ShowDialog();
        }
    }
}

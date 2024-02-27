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
    public partial class CREATE : Form
    {
        public CREATE()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Get all data
            String name = txtName.Text;
            String lastName = txtLastName.Text;
            int age = int.Parse(txtAge.Text);//Transform numerical data on string

            //Attachment
            String data = $"{name}, {lastName}, {age}";

            listBoxData.Items.Add(data);

            txtName.Clear();
            txtLastName.Clear();
            txtAge.Clear();

        }
        private void listBoxData_SelectIndex(object sender, EventArgs e)
        {
            int index = listBoxData.SelectedIndex;

            if (index >= 0)
            {
                String selectedData = listBoxData.Items.ToString();
                String[] itemArray = selectedData.Split(",");

                //this part show the data on textbox
                txtName.Text = itemArray[0].Trim();
                txtLastName.Text = itemArray[1].Trim();
                txtAge.Text = itemArray[2].Trim();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectItem = listBoxData.SelectedIndex;

            if (selectItem >= 0)
            {
                String newName = txtName.Text;
                String newLastName = txtLastName.Text;
                String newAge = txtAge.Text;

                String newRegister = $"{newName}, {newLastName}, {newAge}";

                listBoxData.Items[selectItem] = newRegister;

                txtName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
            }
        }
    }
}

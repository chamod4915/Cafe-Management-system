using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Dash_Board : Form
    {
        public Dash_Board()
        {
            InitializeComponent();
        }
        public Dash_Board(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if (user == "Admin")
            {  
               btnAddItems.Show();
               btnUpdate.Show();
               btnRemove.Show();
            }


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Form1 fm = new Form1();
          this.Hide();
            fm.Show();
        }

        private void btnPlaceOder_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();

        }

        private void Dash_Board_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
        }
    }
}

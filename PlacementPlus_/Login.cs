﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlacementPlus_
{
    public partial class Login : Form
    {
        Submit submit = new Submit();
        public Login()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            submit.Login(email, password);
		}

		private void button3_Click(object sender, EventArgs e)
		{
            Register register = new Register();
            this.Hide();
            register.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void LoginHere_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtEmail_TextChanged(object sender, EventArgs e)
		{

		}

		private void UserName_Click(object sender, EventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}

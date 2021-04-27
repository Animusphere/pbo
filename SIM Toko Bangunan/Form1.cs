using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Toko_Bangunan
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseTOBA.accdb";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Alogin where username='" + username.Text + "' and pass='"+password.Text+"'";
            OleDbDataReader reader = command.ExecuteReader();
            int i=0;
            while (reader.Read()){
                i++;
            }
            if (i==1)
            {
                MessageBox.Show("Login Sukses");
                Menu f2 = new Menu();
                f2.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Username atau Password Salah");

            connection.Close();
            
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text == "username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "username";
                username.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "password";
                password.ForeColor = Color.Silver;
                password.UseSystemPasswordChar = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

    }
}

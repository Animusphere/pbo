using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Toko_Bangunan
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kasir_Click(object sender, EventArgs e)
        {
            Kasir f3 = new Kasir();
            f3.ShowDialog();
            this.Hide();
        }

        private void Pegawai_Click(object sender, EventArgs e)
        {
            Pegawai f4 = new Pegawai();
            f4.ShowDialog();
            this.Close();
        }

        private void Stok_Click(object sender, EventArgs e)
        {
            Stok f5 = new Stok();
            f5.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call = +62 896-1409-9505");
        }
    }
}

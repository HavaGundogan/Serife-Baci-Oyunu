using System;
using System.Windows.Forms;

namespace oyunTest1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Help helpMenu = new Help();
            helpMenu.ShowDialog();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (rdoKolay.Checked == false && rdoZor.Checked == false)
            {
                MessageBox.Show("Lutfen bir zorluk derecesi secin.");
            }

            else if (rdoKolay.Checked == true)
            {
                Form1 oyna = new Form1();
                oyna.zorlukD = 4;
                oyna.Show();
                this.Visible = false;
            }
            else if (rdoZor.Checked == true)
            {
                Form1 oyna = new Form1();
                oyna.zorlukD = 1;
                oyna.Show();
                this.Visible = false;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

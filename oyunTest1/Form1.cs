using System;
using System.Drawing;
using System.Windows.Forms;

namespace oyunTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bebekisFree = true;
        Random rd = new Random();
        int randomHava = 15;
        double bebekSicaklik = 36;
        Menu anaMenu = new Menu();
        public int zorlukD = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timerBebekisFree.Start();
            timerBebekSAzalt.Start();
            timerHavaDurumu.Start();
            if (zorlukD==1)
            {
                pbAnne.Maximum = 170;
                pbAnne.Value = 170;
            }
            
        }

        void HavaDurumu()
        {
            randomHava = rd.Next(-11, 21);
            if (-10 <= randomHava && randomHava <= 0)
            {
                pbRandomHava.ForeColor = Color.LightBlue;
                lbSicaklik.Text = "DONDURUCU SOGUK " + randomHava + "c";
                lbSicaklik.ForeColor = Color.LightBlue;

            }
            else if (1 <= randomHava && randomHava <= 10)
            {
                pbRandomHava.ForeColor = Color.DodgerBlue;
                lbSicaklik.Text = "SOGUK " + randomHava + "c";
                lbSicaklik.ForeColor = Color.DodgerBlue;
            }
            else if (11 <= randomHava && randomHava <= 20)
            {
                pbRandomHava.ForeColor = Color.YellowGreen;
                lbSicaklik.Text = "ILIK " + randomHava + "c";
                lbSicaklik.ForeColor = Color.YellowGreen;
            }
        }

        void BebeginDurumu()
        {
            if (bebekisFree)
            {
                bebekisFree = false;
            }
            else bebekisFree = true;
        }

        void BebegiTut()
        {
            if (!bebekisFree)
            {
                pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }
            else
            {
                pictureBox2.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
            }
        }

        void AnneninCaniAzalt(int azalmaCarpani)
        {
            if (pbAnne.Value >= azalmaCarpani)
            {
                pbAnne.Value -= azalmaCarpani;
            }
            else
            {
                timerBebekSAzalt.Stop();
                timerHavaDurumu.Stop();
                MessageBox.Show("Anne hayatini kaybetmis olabilir.");
                this.Close();
                anaMenu.Visible = true;
            }
        }

        void BebeginSicaklikAzalt(int azalmaCarpani)
        {
            if (bebekisFree)
            {
                if (pbBebek.Value >= azalmaCarpani)
                {
                    pbBebek.Value -= azalmaCarpani;

                    if (azalmaCarpani == 2)
                    {
                        bebekSicaklik -= 0.05;
                        lbBebekSicaklik.Text = bebekSicaklik.ToString();
                    }
                    else if (azalmaCarpani == 3)
                    {
                        bebekSicaklik -= 0.075;
                        lbBebekSicaklik.Text = bebekSicaklik.ToString();
                    }
                }
                else
                {
                    timerBebekSAzalt.Stop();
                    timerHavaDurumu.Stop();
                    MessageBox.Show("Bebek hayatini kaybetmis olabilir.");
                    this.Close();
                    anaMenu.Visible = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Kagni.Location.X >= panel3.Location.X)
            {
                MessageBox.Show("Tebrikler Oyunu Kazandiniz.");
                timerBebekSAzalt.Stop();
                timerHavaDurumu.Stop();
                this.Close();
                anaMenu.Visible = true;
            }

            if (e.KeyCode == Keys.D)
            {
                if (bebekisFree)
                {
                    
                    Kagni.Location = new Point(Kagni.Location.X + zorlukD, Kagni.Location.Y);
                }
                else
                {
                    MessageBox.Show("Su anda bebegi tutuyorsunuz.");
                }

            }

            else if (e.KeyCode == Keys.Space)
            {
                BebeginDurumu();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                anaMenu.Visible = true;
            }
        }

        private void timerBebekisFree_Tick(object sender, EventArgs e)
        {
            BebegiTut();
        }

        private void timerHavaDurumu_Tick(object sender, EventArgs e)
        {

            HavaDurumu();
        }

        private void timerBebekSAzalt_Tick_1(object sender, EventArgs e)
        {
            if (-10 <= randomHava && randomHava <= 0)
            {
                if (zorlukD == 1)
                {
                    BebeginSicaklikAzalt(4);
                    AnneninCaniAzalt(4);
                }
                else if (zorlukD == 4)
                {
                    BebeginSicaklikAzalt(3);
                    AnneninCaniAzalt(3);
                }

            }
            else if (1 <= randomHava && randomHava <= 10)
            {

                if (zorlukD == 1)
                {
                    BebeginSicaklikAzalt(3);
                    AnneninCaniAzalt(3);
                }
                else if (zorlukD == 4)
                {
                    BebeginSicaklikAzalt(2);
                    AnneninCaniAzalt(2);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaMenu.Visible = true;
        }
    }
}

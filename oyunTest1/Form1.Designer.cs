namespace oyunTest1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerBebekisFree = new System.Windows.Forms.Timer(this.components);
            this.pbAnne = new System.Windows.Forms.ProgressBar();
            this.lbAnneHP = new System.Windows.Forms.Label();
            this.pbBebek = new System.Windows.Forms.ProgressBar();
            this.lbBebekHP = new System.Windows.Forms.Label();
            this.timerBebekSAzalt = new System.Windows.Forms.Timer(this.components);
            this.lbHavaDurumu = new System.Windows.Forms.Label();
            this.pbRandomHava = new System.Windows.Forms.ProgressBar();
            this.timerHavaDurumu = new System.Windows.Forms.Timer(this.components);
            this.lbSicaklik = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Kagni = new System.Windows.Forms.GroupBox();
            this.lbBebekSicaklik = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Kagni.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timerBebekisFree
            // 
            this.timerBebekisFree.Tick += new System.EventHandler(this.timerBebekisFree_Tick);
            // 
            // pbAnne
            // 
            this.pbAnne.ForeColor = System.Drawing.Color.LightCoral;
            this.pbAnne.Location = new System.Drawing.Point(16, 535);
            this.pbAnne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAnne.Name = "pbAnne";
            this.pbAnne.Size = new System.Drawing.Size(152, 28);
            this.pbAnne.Step = 1;
            this.pbAnne.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbAnne.TabIndex = 1;
            this.pbAnne.Value = 100;
            // 
            // lbAnneHP
            // 
            this.lbAnneHP.AutoSize = true;
            this.lbAnneHP.BackColor = System.Drawing.SystemColors.Info;
            this.lbAnneHP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAnneHP.Location = new System.Drawing.Point(59, 470);
            this.lbAnneHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnneHP.Name = "lbAnneHP";
            this.lbAnneHP.Size = new System.Drawing.Size(78, 64);
            this.lbAnneHP.TabIndex = 2;
            this.lbAnneHP.Text = "ANNE\r\nHP";
            this.lbAnneHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBebek
            // 
            this.pbBebek.ForeColor = System.Drawing.Color.IndianRed;
            this.pbBebek.Location = new System.Drawing.Point(221, 535);
            this.pbBebek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBebek.Maximum = 80;
            this.pbBebek.Name = "pbBebek";
            this.pbBebek.Size = new System.Drawing.Size(176, 28);
            this.pbBebek.Step = 1;
            this.pbBebek.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbBebek.TabIndex = 1;
            this.pbBebek.Value = 80;
            // 
            // lbBebekHP
            // 
            this.lbBebekHP.AutoSize = true;
            this.lbBebekHP.BackColor = System.Drawing.SystemColors.Info;
            this.lbBebekHP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBebekHP.Location = new System.Drawing.Point(261, 470);
            this.lbBebekHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBebekHP.Name = "lbBebekHP";
            this.lbBebekHP.Size = new System.Drawing.Size(109, 64);
            this.lbBebekHP.TabIndex = 2;
            this.lbBebekHP.Text = "BEBEK\r\nSICAKLIK";
            this.lbBebekHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBebekSAzalt
            // 
            this.timerBebekSAzalt.Interval = 1000;
            this.timerBebekSAzalt.Tick += new System.EventHandler(this.timerBebekSAzalt_Tick_1);
            // 
            // lbHavaDurumu
            // 
            this.lbHavaDurumu.AutoSize = true;
            this.lbHavaDurumu.BackColor = System.Drawing.SystemColors.Info;
            this.lbHavaDurumu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHavaDurumu.Location = new System.Drawing.Point(617, 470);
            this.lbHavaDurumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHavaDurumu.Name = "lbHavaDurumu";
            this.lbHavaDurumu.Size = new System.Drawing.Size(116, 64);
            this.lbHavaDurumu.TabIndex = 2;
            this.lbHavaDurumu.Text = "HAVA\r\nDURUMU";
            this.lbHavaDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRandomHava
            // 
            this.pbRandomHava.ForeColor = System.Drawing.Color.YellowGreen;
            this.pbRandomHava.Location = new System.Drawing.Point(597, 535);
            this.pbRandomHava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbRandomHava.Name = "pbRandomHava";
            this.pbRandomHava.Size = new System.Drawing.Size(163, 28);
            this.pbRandomHava.Step = 1;
            this.pbRandomHava.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbRandomHava.TabIndex = 1;
            this.pbRandomHava.Value = 100;
            // 
            // timerHavaDurumu
            // 
            this.timerHavaDurumu.Interval = 2500;
            this.timerHavaDurumu.Tick += new System.EventHandler(this.timerHavaDurumu_Tick);
            // 
            // lbSicaklik
            // 
            this.lbSicaklik.AutoSize = true;
            this.lbSicaklik.BackColor = System.Drawing.SystemColors.Info;
            this.lbSicaklik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSicaklik.Location = new System.Drawing.Point(768, 535);
            this.lbSicaklik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSicaklik.Name = "lbSicaklik";
            this.lbSicaklik.Size = new System.Drawing.Size(103, 32);
            this.lbSicaklik.TabIndex = 2;
            this.lbSicaklik.Text = "ILIK 15 c";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(4, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(243, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Kagni
            // 
            this.Kagni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Kagni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kagni.BackgroundImage")));
            this.Kagni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kagni.Controls.Add(this.pictureBox2);
            this.Kagni.Controls.Add(this.pictureBox1);
            this.Kagni.Controls.Add(this.pictureBox3);
            this.Kagni.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Kagni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kagni.ForeColor = System.Drawing.SystemColors.Control;
            this.Kagni.Location = new System.Drawing.Point(0, 203);
            this.Kagni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kagni.Name = "Kagni";
            this.Kagni.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kagni.Size = new System.Drawing.Size(255, 164);
            this.Kagni.TabIndex = 0;
            this.Kagni.TabStop = false;
            // 
            // lbBebekSicaklik
            // 
            this.lbBebekSicaklik.AutoSize = true;
            this.lbBebekSicaklik.BackColor = System.Drawing.Color.Transparent;
            this.lbBebekSicaklik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBebekSicaklik.Location = new System.Drawing.Point(405, 533);
            this.lbBebekSicaklik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBebekSicaklik.Name = "lbBebekSicaklik";
            this.lbBebekSicaklik.Size = new System.Drawing.Size(41, 32);
            this.lbBebekSicaklik.TabIndex = 5;
            this.lbBebekSicaklik.Text = "36";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-1, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1588, 12);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1588, 12);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(629, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "İSTİKLAL YOLU";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1567, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 320);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 85);
            this.label2.TabIndex = 9;
            this.label2.Text = "c\r\ne\r\np\r\nh\r\ne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBebekSicaklik);
            this.Controls.Add(this.Kagni);
            this.Controls.Add(this.lbSicaklik);
            this.Controls.Add(this.lbHavaDurumu);
            this.Controls.Add(this.lbBebekHP);
            this.Controls.Add(this.lbAnneHP);
            this.Controls.Add(this.pbRandomHava);
            this.Controls.Add(this.pbBebek);
            this.Controls.Add(this.pbAnne);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Kagni.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerBebekisFree;
        private System.Windows.Forms.ProgressBar pbAnne;
        private System.Windows.Forms.Label lbAnneHP;
        private System.Windows.Forms.ProgressBar pbBebek;
        private System.Windows.Forms.Label lbBebekHP;
        private System.Windows.Forms.Timer timerBebekSAzalt;
        private System.Windows.Forms.Label lbHavaDurumu;
        private System.Windows.Forms.ProgressBar pbRandomHava;
        private System.Windows.Forms.Timer timerHavaDurumu;
        private System.Windows.Forms.Label lbSicaklik;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox Kagni;
        private System.Windows.Forms.Label lbBebekSicaklik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BGProje1.Nesneler;
using System.Drawing.Drawing2D;

namespace BGProje1
{
    public partial class Form1 : Form
    {
        private ArrayList nesneler = new ArrayList();
        public ArrayList noktalar = new ArrayList();
        Cizgi yeniCizgi;
        Dikdortgen yeniDikdortgen;
        Elips yeniElips;
        Cokgen yeniCokgen;
        string action;
        Nesne seciliNesne;
        float aci;

        Point ilk, ikinci;
        Boolean drawingFlag = false, noktaKoy = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void yenidenCiz(Graphics g)
        {
            foreach (Nesne nesne in nesneler)
            {
                nesne.ciz(g);
            }
        }

        private void çizgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degisimToolStripDropDownButton.Visible = false;
            this.action = "cizgi";
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!drawingFlag)
            {
                drawingFlag = true;
                ilk = e.Location;

                if (this.action == "cizgi")
                {
                    yeniCizgi = new Cizgi(ilk, ilk);
                } else if (this.action == "dikdortgen")
                {
                   yeniDikdortgen = new Dikdortgen(ilk, 1, 1);
                } else if (this.action == "elips")
                {
                    yeniElips = new Elips(ilk, 1, 1);
                } else if(this.action == "cokgen")
                {
                    this.noktalar.Add(ilk);
                    this.noktaKoy = true;
                    Invalidate();
                }else if(this.action=="tasi")
                {
                    if (seciliNesne == null)
                        MessageBox.Show("Nesne Seçiniz!");
                    else {
                        if (seciliNesne.uzerindeMi(ilk))
                        {
                            this.Cursor = Cursors.Cross;
                            this.action = "tasiniyor";
                        }
                    }
                }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drawingFlag = false;

            if (this.action == "cizgi")
            {
                nesnelerComboBox.Items.Add(nesneler[nesneler.Add(yeniCizgi)]);
                yeniCizgi = null;
                this.action = null;
            } else if (this.action == "dikdortgen")
            {
                nesnelerComboBox.Items.Add(nesneler[nesneler.Add(yeniDikdortgen)]);
                yeniDikdortgen = null;
                this.action = null;
            } else if (this.action == "elips")
            {
                nesnelerComboBox.Items.Add(nesneler[nesneler.Add(yeniElips)]);
                yeniElips = null;
                this.action = null;
            } else if (this.action == "tasiniyor")
            {
                this.Cursor = Cursors.Arrow;
                this.action = "tasi";
            } else if (this.action == "olcek")
            {
                this.action = null;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (this.action == "cizgi")
            {
                try
                {
                    yeniCizgi.ciz(g);
                }
                catch (Exception)
                {
                    Console.WriteLine("önemsiz hata");
                }

            }
            else if (this.action == "dikdortgen")
            {
                try
                {
                    yeniDikdortgen.ciz(g);
                }
                catch (Exception)
                {
                    Console.WriteLine("önemsiz hata");
                }
            }
            else if (this.action == "elips")
            {
                try
                {
                    yeniElips.ciz(g);
                }
                catch (Exception)
                {
                    Console.WriteLine("önemsiz hata");
                }
            }
            else if (this.action == "cokgen")
            {
                if (this.noktalar.Count == 0 && yeniCokgen != null)
                {
                    yeniCokgen.ciz(g);
                    this.action = null;
                    yeniCokgen = null;
                    cizdirToolStripLabel.Visible = false;
                    this.Cursor = Cursors.Default;
                }
                else {
                    foreach (Point nokta in noktalar)
                    {
                        g.DrawLine(new Pen(Color.Blue, 2), nokta, new Point(nokta.X + 2, nokta.Y + 2));
                    }
                    if (this.noktaKoy)
                    {
                        this.noktaKoy = false;
                    }
                }
            }
            else if (this.action == "donduruluyor")
            {
                seciliNesne.Aci=aci;
                this.action = null;
            } else if (this.action == "seciliciz")
            {
                if (seciliNesne != null)
                    this.seciliNesne.ciz(g);
            }
            
            this.yenidenCiz(g);
        }
        
        private void nesnelerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            degisimToolStripDropDownButton.Visible = true;
            silToolStripButton.Visible = true;
            this.seciliNesne = (Nesne) nesnelerComboBox.SelectedItem;            
            this.action = "seciliciz";
            Invalidate();
        }

        private void dondurToolStripButton_Click(object sender, EventArgs e)
        {
            this.action = "dondur";
            if (seciliNesne == null)
                MessageBox.Show("Nesne Seçiniz!");
            else
            {
                aciTrackBar.Value = Convert.ToInt32(this.seciliNesne.Aci);
                aciTrackBar.Visible = true;
            }
        }

        private void dikdörtgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degisimToolStripDropDownButton.Visible = false;
            this.action = "dikdortgen";
        }

        private void elipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degisimToolStripDropDownButton.Visible = false;
            this.action = "elips";
        }

        private void çokgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degisimToolStripDropDownButton.Visible = false;
            this.action = "cokgen";
            cizdirToolStripLabel.Visible = true;
        }

        private void cizdirToolStripLabel_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void cizdirToolStripLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void çizgiRengiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                seciliNesne.Kalem.Renk = colorDialog.Color;
            }
            Invalidate();
        }

        private void dolguRengiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                seciliNesne.Fırça.Renk = colorDialog.Color;
            }
            Invalidate();
        }

        private void kalınlıkDeğiştirToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            seciliNesne.Kalem.Kalinlik = Convert.ToInt32(e.ClickedItem.Text);
            Invalidate();
        }

        private void saydamlıkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saydamlikTrackBar.Visible = true;
            saydamlikTrackBar.Value = seciliNesne.Kalem.Saydamlik;      
        }

        private void saydamlikTrackBar_Scroll(object sender, EventArgs e)
        {
            seciliNesne.Kalem.Saydamlik = saydamlikTrackBar.Value;
            seciliNesne.Fırça.Saydamlik = saydamlikTrackBar.Value;

            Invalidate();
        }

        private void saydamlikTrackBar_MouseLeave(object sender, EventArgs e)
        {
            saydamlikTrackBar.Visible = false;
        }

        private void degisimToolStripDropDownButton_Click(object sender, EventArgs e)
        {
            degisimToolStripDropDownButton.DropDownItems[1].Visible = !(seciliNesne is Cizgi);
            degisimToolStripDropDownButton.DropDownItems[4].Visible = !(seciliNesne is Cizgi);
        }

        private void desenDeğiştirToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Text)
            {
                case "Pug":
                    seciliNesne.Fırça.Desen = Properties.Resources.pug;
                    break;
                case "Yıldız":
                    seciliNesne.Fırça.Desen = Properties.Resources.yıldız;
                    break;
                case "At":
                    seciliNesne.Fırça.Desen = Properties.Resources.at;
                    break;
                case "Çapa":
                    seciliNesne.Fırça.Desen = Properties.Resources.capa;
                    break;
            }

            Invalidate();
        }

        private void silToolStripButton_Click(object sender, EventArgs e)
        {
            nesneler.Remove(seciliNesne);
            silToolStripButton.Visible = false;
            degisimToolStripDropDownButton.Visible = false;
            nesnelerComboBox.Items.Remove(seciliNesne);
            nesnelerComboBox.Text = "";
            seciliNesne = null;
            Invalidate();            
        }

        private void tasiToolStripButton_Click(object sender, EventArgs e)
        {
            this.action = "tasi";
        }

        private void aciTrackBar_MouseLeave(object sender, EventArgs e)
        {
            aciTrackBar.Visible = false;
        }

        private void aciTrackBar_Scroll(object sender, EventArgs e)
        {
            aci = aciTrackBar.Value;
            this.action = "donduruluyor";
            
            Invalidate();
        }

        private void olcekToolStripButton_Click(object sender, EventArgs e)
        {
            this.action = "olcek";
            if (seciliNesne == null)
                MessageBox.Show("Nesne Seçiniz!");
        }

        private void cizdirToolStripLabel_Click(object sender, EventArgs e)
        {
            yeniCokgen = new Cokgen(noktalar);
            nesnelerComboBox.Items.Add(nesneler[nesneler.Add(yeniCokgen)]);
            this.noktalar.Clear();

            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingFlag)
            {
                ikinci = e.Location;
                if (this.action == "cizgi")
                {
                    yeniCizgi.setBitis(ikinci);
                } else if (this.action == "dikdortgen")
                {
                    yeniDikdortgen.setOrijin(new Point(Math.Min(ilk.X, ikinci.X), Math.Min(ilk.Y, ikinci.Y)));
                    yeniDikdortgen.setGenislik(Math.Abs(ikinci.X - ilk.X));
                    yeniDikdortgen.setYukseklik(Math.Abs(ikinci.Y - ilk.Y));
                } else if (this.action == "elips")
                {
                    yeniElips.setOrijin(new Point(Math.Min(ilk.X, ikinci.X), Math.Min(ilk.Y, ikinci.Y)));
                    yeniElips.setGenislik(Math.Abs(ikinci.X - ilk.X));
                    yeniElips.setYukseklik(Math.Abs(ikinci.Y - ilk.Y));
                } else if(this.action == "tasiniyor")
                {                           
                    seciliNesne.tasi(new Point(ikinci.X - ilk.X, ikinci.Y - ilk.Y));
                    ilk = ikinci;
                } else if(this.action == "olcek")
                {
                    seciliNesne.Olcek = ((float)Geometri.ikiNoktaArasiUzaklık(ilk, ikinci))/200;
                }
                Invalidate();  
            }

        }
    }
}

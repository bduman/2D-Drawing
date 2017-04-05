using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using BGProje1.Araçlar;
using System.Drawing.Drawing2D;

namespace BGProje1.Nesneler
{
    class Cizgi:Nesne
    {
        public static int i = 0;
        private Point baslangic;
        private Point bitis;
        private string isim;
        private Kalem kalem = new Kalem();
        private float aci = 0;
        private float olcek = 1;

        public Cizgi(Point baslangic, Point bitis)
        {
            this.baslangic = baslangic;
            this.bitis = bitis;
            this.isim = "Çizgi - " + (++Cizgi.i);
        }
        public Kalem Kalem
        {
            get
            {
                return this.kalem;
            }
        }

        public Fırça Fırça
        {
            get
            {
                return null;
            }
        }

        public float Olcek
        {
            get
            {
                return this.olcek;
            }
            set
            {
                this.olcek = value;
            }
        }

        public float Aci
        {
            get
            {
                return this.aci;
            }
            set
            {
                this.aci = value;
            }
        }


        public Point getBaslangic()
        {
            return this.baslangic;
        }

        public Point getBitis()
        {
            return this.bitis;
        }

        public void setBaslangic(Point baslangic)
        {
            this.baslangic = baslangic;
        }

        public void setBitis(Point bitis)
        {
            this.bitis = bitis;
        }
        
        public void ciz(Graphics g)
        {
            if (this.aci != 0 || this.Olcek != 1)
            {
                Matrix init = g.Transform;

                g.TranslateTransform(Geometri.ortaNokta(baslangic, bitis).X, Geometri.ortaNokta(baslangic, bitis).Y);
                g.RotateTransform(this.aci);
                g.ScaleTransform(this.Olcek, this.Olcek);
                g.TranslateTransform(-Geometri.ortaNokta(baslangic, bitis).X, -Geometri.ortaNokta(baslangic, bitis).Y);
                g.DrawLine(this.Kalem.Getir, baslangic, bitis);

                g.Transform = init;
            } else
            {
                g.DrawLine(this.Kalem.Getir, baslangic, bitis);
            }
        }

        public bool uzerindeMi(Point mouse)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(this.getBaslangic(), this.getBitis());
            return gp.IsOutlineVisible(mouse, this.Kalem.Getir);
        }

        public void tasi(Point delta)
        {
            this.baslangic.X += delta.X;
            this.baslangic.Y += delta.Y;
            this.bitis.X += delta.X;
            this.bitis.Y += delta.Y;
        }

        public static Cizgi kopyala(Cizgi cizgi)
        {
            Cizgi.i--;
            return new Cizgi(cizgi.getBaslangic(), cizgi.getBitis());
        }

        public override string ToString()
        {
            return this.isim;
        }

        ~Cizgi()
        {
            Cizgi.i--;
        }
    }
}

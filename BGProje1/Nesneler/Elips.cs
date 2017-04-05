using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using BGProje1.Araçlar;

namespace BGProje1.Nesneler
{
    class Elips : Nesne
    {
        private Point orijin;
        private float yukseklik;
        private float genislik;
        private string isim = "Elips - ";
        public static int i = 0;
        private Kalem kalem = new Kalem();
        private Fırça fırça = new Fırça();
        private float aci = 0;
        private float olcek = 1;

        public Elips(Point orijin, float yukseklik, float genislik)
        {
            this.orijin = orijin;
            this.yukseklik = yukseklik;
            this.genislik = genislik;
            this.isim += ++Elips.i;
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
                return this.fırça;
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

        public Point getOrijin()
        {
            return this.orijin;
        }

        public float getYukseklik()
        {
            return this.yukseklik;
        }

        public float getGenislik()
        {
            return this.genislik;
        }

        public void setOrijin(Point orijin)
        {
            this.orijin = orijin;
        }

        public void setYukseklik(float yukseklik)
        {
            this.yukseklik = yukseklik;
        }
        public void setGenislik(float genislik)
        {
            this.genislik = genislik;
        }

        public void ciz(Graphics g)
        {
            if (this.aci != 0 || this.Olcek != 1)
            {
                Matrix init = g.Transform;

                g.TranslateTransform(orijin.X, orijin.Y);
                g.RotateTransform(this.aci);
                g.ScaleTransform(this.Olcek, this.Olcek);
                g.TranslateTransform(-orijin.X, -orijin.Y);

                g.DrawEllipse(this.Kalem.Getir, orijin.X, orijin.Y, genislik, yukseklik);
                if (this.Fırça.Desen != null)
                    g.FillEllipse(this.Fırça.DesenGetir, orijin.X, orijin.Y, genislik, yukseklik);
                else {
                    g.FillEllipse(this.Fırça.Getir, orijin.X, orijin.Y, genislik, yukseklik);
                }

                g.Transform = init;
            }
            else {
                g.DrawEllipse(this.Kalem.Getir, orijin.X, orijin.Y, genislik, yukseklik);
                if (this.Fırça.Desen != null)
                    g.FillEllipse(this.Fırça.DesenGetir, orijin.X, orijin.Y, genislik, yukseklik);
                else {
                    g.FillEllipse(this.Fırça.Getir, orijin.X, orijin.Y, genislik, yukseklik);
                }
            }
        }

        public void tasi(Point delta)
        {
            this.orijin.X += delta.X;
            this.orijin.Y += delta.Y;
        }
        public bool uzerindeMi(Point mouse)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new RectangleF(orijin.X, orijin.Y, genislik, yukseklik));
            return gp.IsVisible(mouse);
        }
        public override string ToString()
        {
            return this.isim;
        }

        public static Elips kopyala(Elips elips)
        {
            --Elips.i;
            return new Elips(elips.getOrijin(), elips.getYukseklik(), elips.getGenislik());
        }

        ~Elips()
        {
            Elips.i--;
        }
    }
}

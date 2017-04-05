using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using BGProje1.Araçlar;

namespace BGProje1.Nesneler
{
    class Cokgen : Nesne
    {
        private Point[] noktalar;
        private string isim = "Çokgen - ";
        private int koseSayisi;
        public static int i = 0;
        private Kalem kalem = new Kalem();
        private Fırça fırça = new Fırça();
        private float aci = 0;
        private float olcek = 1;

        public Cokgen(ArrayList list)
        {
            this.noktalar = (Point[]) list.ToArray(typeof(Point));
            this.koseSayisi = list.Count;
            this.isim += ++Cokgen.i;
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

        public Cokgen(Point[] dizi)
        {
            Array.Copy(dizi, this.noktalar, dizi.Length);
        }

        public Point[] getNoktalar()
        {
            return noktalar;
        }

        public int getKoseSayisi()
        {
            return this.koseSayisi;
        }

        public void ciz(Graphics g)
        {
            if (this.aci != 0 || this.Olcek != 1)
            {
                Matrix init = g.Transform;

                g.TranslateTransform(this.noktalar[0].X, this.noktalar[0].Y);
                g.RotateTransform(this.aci);
                g.ScaleTransform(this.Olcek, this.Olcek);
                g.TranslateTransform(-this.noktalar[0].X, -this.noktalar[0].Y);

                g.DrawPolygon(this.Kalem.Getir, this.noktalar);
                if (this.Fırça.Desen != null)
                    g.FillPolygon(this.Fırça.DesenGetir, this.noktalar);
                else {
                    g.FillPolygon(this.Fırça.Getir, this.noktalar);
                }

                g.Transform = init;
            }
            else {
                g.DrawPolygon(this.Kalem.Getir, this.noktalar);
                if (this.Fırça.Desen != null)
                    g.FillPolygon(this.Fırça.DesenGetir, this.noktalar);
                else {
                    g.FillPolygon(this.Fırça.Getir, this.noktalar);
                }
            }

        }

        public void tasi(Point delta)
        {
            for(int i = 0 ; i < noktalar.Length; i++)
            {
                noktalar[i].X += delta.X;
                noktalar[i].Y += delta.Y;
            }
        }

        public bool uzerindeMi(Point mouse)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(this.noktalar);
            return gp.IsVisible(mouse);
        }
        public override string ToString()
        {
            return this.isim;
        }

        public static Cokgen kopyala(Cokgen cokgen)
        {
            --Cokgen.i;
            return new Cokgen(cokgen.getNoktalar()); 
        }

        ~Cokgen()
        {
            Cokgen.i--;
        }
    }
}

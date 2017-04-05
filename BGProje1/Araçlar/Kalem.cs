using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGProje1
{
    class Kalem
    {
        private Pen kalem;
        public Kalem()
        {
            this.Getir = new Pen(Color.FromArgb(255, Color.Black), 2);
        }

        public int Saydamlik
        {
            get
            {
                return this.Getir.Color.A;
            }
            set
            {
                this.Getir.Color = Color.FromArgb(value, this.Getir.Color);
            }
        }
        public Color Renk
        {
            get
            {
                return this.Getir.Color;
            }
            set
            {
                this.Getir.Color = Color.FromArgb(this.Getir.Color.A, value);
            }
        }
        
        public float Kalinlik
        {
            get
            {
                return this.Getir.Width;
            }
            set
            {
                this.Getir.Width = value;
            }
        }

        public Pen Getir
        {
            get
            {
                return kalem;
            }
            internal set
            {
                kalem = value;
            }
        }
    }
}

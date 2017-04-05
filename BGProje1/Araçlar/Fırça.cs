using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGProje1.Araçlar
{
    class Fırça
    {
        public SolidBrush fırça;
        private TextureBrush desen = null;
        public Fırça()
        {
            this.Getir = new SolidBrush(Color.FromArgb(255, Color.HotPink));
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

        public Image Desen
        {
            get
            {
                return (desen != null) ? desen.Image : null;
            }
            set
            {
                this.DesenGetir = new TextureBrush(value);
                this.DesenGetir.WrapMode = WrapMode.TileFlipXY;
            }
        }
        
        public SolidBrush Getir
        {
            get
            {
                return this.fırça;
            }
            internal set
            {
                this.fırça = value;
            }
        }

        public TextureBrush DesenGetir
        {
            get
            {
                return desen;
            }
            internal set
            {
                this.desen = value;
            }        
        }

    }
}

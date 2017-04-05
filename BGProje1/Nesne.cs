using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BGProje1.Araçlar;

namespace BGProje1
{
    interface Nesne
    {
        void ciz(Graphics g);
        void tasi(Point delta);
        Kalem Kalem
        {
            get;
        }
        float Olcek
        {
            get;
            set;
        }
        float Aci
        {
            get;
            set;
        }
        Fırça Fırça
        {
            get;
        }
        bool uzerindeMi(Point mouse);
    }
}

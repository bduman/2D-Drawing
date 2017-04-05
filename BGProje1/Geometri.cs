using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BGProje1.Nesneler;
using System.Windows.Forms;

namespace BGProje1
{
    class Geometri
    {

        public static double ikiNoktaArasiUzaklık(Point baslangic, Point bitis)
        {
            return Math.Abs(Math.Pow((Math.Pow((bitis.X - baslangic.X), 2) + (Math.Pow((bitis.Y - baslangic.Y), 2))), 0.5));
        }

        public static double dogrununEgimi(Point baslangic, Point bitis)
        {
            return (double) (bitis.Y - baslangic.Y) / (bitis.X - baslangic.X);
        }

        public static double ikiDogruArasindakiAci(Cizgi ilk, Cizgi ikinci)
        {
            return Math.Atan((dogrununEgimi(ilk.getBaslangic(), ilk.getBitis()) - dogrununEgimi(ikinci.getBaslangic(), ikinci.getBitis())) /
                (1 + (dogrununEgimi(ilk.getBaslangic(), ilk.getBitis()) * dogrununEgimi(ikinci.getBaslangic(), ikinci.getBitis())))) * 100;
        }

        public static Point ortaNokta(Point ilk, Point ikinci)
        {
            return new Point(
                (ilk.X + ikinci.X) / 2,
                (ilk.Y + ikinci.Y) / 2
            );
        }

        public static double derece2Radyan(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

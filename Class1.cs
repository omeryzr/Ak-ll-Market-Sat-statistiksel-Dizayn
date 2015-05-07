using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TckimlikNo
    {
          private int OnuncuNumara(string tcno)
        {
            int teklerToplam = 0, ciftlerToplam = 0;
            for (int i = 0; i < 9; i++)
            {
                if ((i % 2) == 0)
                {
                    teklerToplam = teklerToplam + int.Parse(tcno[i].ToString());
                }
                else
                {
                    ciftlerToplam = ciftlerToplam + int.Parse(tcno[i].ToString());
                }

            }
            return (((teklerToplam * 7) + (ciftlerToplam * 9)) % 10);

        }
        private int OnbirinciNumara(string tcno)
        {
            int toplam = 0;
            for (int i = 0; i < 9; i = i + 2)
            {
                toplam = toplam + int.Parse(tcno[i].ToString());
            }
            return (toplam * 8) % 10;
        }
        public bool TcNoSorgula(string tckimlikNo)
        {
            if ((Convert.ToInt64(tckimlikNo) < 10000000000) || (Convert.ToInt64(tckimlikNo) > 99999999999))
            {
                return false;
            }
            else if (int.Parse(tckimlikNo[9].ToString()) != (OnuncuNumara(tckimlikNo)))
            {
                return false;

            }
            else if (int.Parse(tckimlikNo[10].ToString()) != OnbirinciNumara(tckimlikNo))
            {
                return false;

            }
            return true;
        }
    }
}

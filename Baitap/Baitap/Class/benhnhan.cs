using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap.Class
{
    public class benhNhan
    {
        
        private string mabn;
        private string cmnd;
        private string hoten;
        private string diachi;

        public string Mabn
        {
            get
            {
                return mabn;
            }

            set
            {
                mabn = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }
        public benhNhan(string ms, string cm, string ten, string dc)
        {
            Mabn = ms;
            Cmnd = cm;
            Hoten = ten;
            Diachi = dc;
        }
    }
}

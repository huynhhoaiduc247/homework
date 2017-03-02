using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapReceive.Class
{
    public class khambenhEntities
    {
        private string mabacsi;
        private string mabn;
        private DateTime ngaykham;
        private string ghichu;

        public string Mabacsi
        {
            get
            {
                return mabacsi;
            }

            set
            {
                mabacsi = value;
            }
        }

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

        public DateTime Ngaykham
        {
            get
            {
                return ngaykham;
            }

            set
            {
                ngaykham = value;
            }
        }

        public string Ghichu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
            }
        }

        public khambenhEntities(string mabenhnhan,string mbs,DateTime ngay, string gc)
        {
            Mabn = mabenhnhan;
            Mabacsi = mbs;
            Ngaykham = ngay;
            Ghichu = gc;
        }
    }
}

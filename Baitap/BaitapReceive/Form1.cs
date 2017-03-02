using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BaitapReceive
{
    public partial class Form1 : Form
    {
        static int masobn = 0;
        List<benhnhan> lst = null;
        List<khambenh> lstkb = null;
        khambenhDataContext db = new khambenhDataContext();
        public Form1()
        {
            InitializeComponent();
            init();
            loadlistview();
            btnloadlst.Enabled = false;

        }
        public void init()
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin","admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue destination = new ActiveMQQueue("khambenh");
            IMessageConsumer consumer = session.CreateConsumer(destination);
            consumer.Listener += consumer_listener;

        }

        private void consumer_listener(IMessage message)
        {
            
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;

                if (lblstatus.InvokeRequired)
                {
                    lblstatus.Invoke(
                       (Action)delegate
                       {
                           lblstatus.Text = msg.Text;
                       }
                    );
                }
                if (btnloadlst.InvokeRequired)
                {
                    lblstatus.Invoke(
                       (Action)delegate
                       {
                           btnloadlst.Enabled = true;
                       }
                    );
                }


            }
            
        }
       
        public void cleartxt()
        {
            txtcmnd.ResetText();
            txthoten.ResetText();
            txtmaso.ResetText();
            richTextBoxdiachi.ResetText();
            richTextBoxnoidung.ResetText();
        }
        public void loadlistview()
        {
            lwvds.Items.Clear();
            lst = db.benhnhans.ToList();
            foreach(var e in lst)
            {
                ListViewItem l = new ListViewItem(e.MSBN);
                lstkb = db.khambenhs.ToList();
                khambenh a = lstkb.Where(x => x.MSBN == e.MSBN).FirstOrDefault();
                if (a == null)
                {
                    lwvds.Items.Add(l);
                }
            }
        }

        private void btngoikham_Click(object sender, EventArgs e)
        {
            khambenhDataContext db = new khambenhDataContext();

            if (lwvds.SelectedItems!=null)
            {
                benhnhan a = db.benhnhans.Where(x => x.MSBN == masobn.ToString()).FirstOrDefault();
                if(a!=null)
                {              
                    txtcmnd.Text = a.SoCmnd;
                    txthoten.Text = a.Hoten;
                    txtmaso.Text = a.MSBN;
                    richTextBoxdiachi.Text = a.Diachi;
                }
            }
        }

        private void lwvds_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            masobn = int.Parse(e.Item.Text);
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (lwvds.SelectedItems != null)
            {
                benhnhan a = db.benhnhans.Where(x => x.MSBN == masobn.ToString()).FirstOrDefault();
                if (a != null)
                {
                    khambenhDataContext db = new khambenhDataContext();
                    khambenh i = new khambenh();
                    i.MSBN = txtmaso.Text;
                    i.Mabs = "123";
                    i.ngaykham = DateTime.Now;
                    i.ghichu = richTextBoxnoidung.Text;
                    db.khambenhs.InsertOnSubmit(i);
                    db.SubmitChanges();
                    MessageBox.Show("Done");
                    a = null;
                    loadlistview();
                    cleartxt();
                }
            }
        }

        private void btnloadlst_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "";
            btnloadlst.Enabled = false;
            loadlistview();
        }
    }
}

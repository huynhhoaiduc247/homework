using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Form1 : Form
    {
        khambenhDataContext db = new khambenhDataContext();
        public static IMessage msg;
        public static IMessageProducer producer;
        public Form1()
        {
            InitializeComponent();
        }
        public void sendmsg()
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin","admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue destination = new ActiveMQQueue("khambenh");
            IMessageProducer producer = session.CreateProducer(destination);
            IMessage msg = new ActiveMQTextMessage("have a new patient");
            producer.Send(msg);
            session.Close();
            con.Close();
        }
        public void cleartext()
        {
            txtcmnd.ResetText();
            txtname.ResetText();
            richTextBox1.ResetText();
            txtmaso.ResetText();
        }
        private void btnluutt_Click(object sender, EventArgs e)
        {
            khambenhDataContext db = new khambenhDataContext();
            Class.benhNhan bn = new Class.benhNhan(txtmaso.Text, txtcmnd.Text, txtname.Text, richTextBox1.Text);
            benhnhan t = new benhnhan();
            t = db.benhnhans.Where(x => x.MSBN == bn.Mabn).FirstOrDefault();
            if (t == null)
            {
                benhnhan a = new benhnhan();
                a.Hoten = bn.Hoten;
                a.MSBN = bn.Mabn;
                a.SoCmnd = bn.Cmnd;
                a.Diachi = bn.Diachi;
                cleartext();
                db.benhnhans.InsertOnSubmit(a);
                db.SubmitChanges();
                sendmsg();
                
                
            }
            else
            {
                MessageBox.Show("Da ton tai benh nhan");
                txtmaso.Focus();
            }
        }
    }
}

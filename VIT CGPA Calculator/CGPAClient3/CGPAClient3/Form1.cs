using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using CGPACalculatorClass;

namespace CGPAClient3
{
    public partial class Form1 : Form
    {
        CgpaCalculator obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TcpClientChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownClientType(
            typeof(CgpaCalculator), "tcp://localhost:12345/CgpaCalculator");
            obj = new CgpaCalculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1, s2, s3, s4;
            int c1, c2;
            double g1, g2;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            s3 = textBox3.Text;
            s4 = textBox4.Text;
            c1 = Convert.ToInt32(s1);
            c2 = Convert.ToInt32(s3);
            g1 = Convert.ToDouble(s2);
            g2 = Convert.ToDouble(s4);
            double cgpa = obj.calcgpa2(c1,g1,c2,g2);
            textBox5.Text = cgpa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}

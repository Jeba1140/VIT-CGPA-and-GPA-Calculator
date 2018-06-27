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

namespace CGPAClient1
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
            typeof(CgpaCalculator), "tcp://localhost:1234/CgpaCalculator");
            obj = new CgpaCalculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16;
            double g1, g2, g3, g4, g5, g6, g7, g8;
            int c1, c2, c3, c4, c5, c6, c7, c8;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            s3 = textBox3.Text;
            s4 = textBox4.Text;
            s5 = textBox5.Text;
            s6 = textBox6.Text;
            s7 = textBox7.Text;
            s8 = textBox8.Text;

            s9 = textBox9.Text;
            s10 = textBox10.Text;
            s11 = textBox11.Text;
            s12 = textBox12.Text;
            s13 = textBox13.Text;
            s14 = textBox14.Text;
            s15 = textBox15.Text;
            s16 = textBox16.Text;

            if (s1 == "")
            {
                g1 = 0;
            }
            else
            {
                g1 = Convert.ToDouble(s1);
            }
            if (s2 == "")
            {
                g2 = 0;
            }
            else
            {
                g2 = Convert.ToDouble(s2);
            }
            if (s3 == "")
            {
                g3 = 0;
            }
            else
            {
                g3 = Convert.ToDouble(s3);
            }
            if (s4 == "")
            {
                g4 = 0;
            }
            else
            {
                g4 = Convert.ToDouble(s4);
            }
            if (s5 == "")
            {
                g5 = 0;
            }
            else
            {
                g5 = Convert.ToDouble(s5);
            }
            if (s6 == "")
            {
                g6 = 0;
            }
            else
            {
                g6 = Convert.ToDouble(s6);
            }
            if (s7 == "")
            {
                g7 = 0;
            }
            else
            {
                g7 = Convert.ToDouble(s7);
            }
            if (s8 == "")
            {
                g8 = 0;
            }
            else
            {
                g8 = Convert.ToDouble(s8);
            }

            if (s9 == "")
            {
                c1 = 0;
            }
            else
            {
                c1 = Convert.ToInt32(s9);
            }
            if (s10 == "")
            {
                c2 = 0;
            }
            else
            {
                c2 = Convert.ToInt32(s10);
            }
            if (s11 == "")
            {
                c3 = 0;
            }
            else
            {
                c3 = Convert.ToInt32(s11);
            }
            if (s12 == "")
            {
                c4 = 0;
            }
            else
            {
                c4 = Convert.ToInt32(s12);
            }
            if (s13 == "")
            {
                c5 = 0;
            }
            else
            {
                c5 = Convert.ToInt32(s13);
            }
            if (s14 == "")
            {
                c6 = 0;
            }
            else
            {
                c6 = Convert.ToInt32(s14);
            }
            if (s15 == "")
            {
                c7 = 0;
            }
            else
            {
                c7 = Convert.ToInt32(s15);
            }
            if (s16 == "")
            {
                c8 = 0;
            }
            else
            {
                c8 = Convert.ToInt32(s16);
            }
            double cgpa = obj.calcgpa1(g1, g2, g3, g4, g5, g6, g7, g8, c1, c2, c3, c4, c5, c6, c7, c8);
            textBox17.Text = cgpa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }
       
    }
}

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

namespace GPAClient2
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
            String s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,s17,s18,s19,s20;
            int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
            int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
            s1=comboBox1.Text;
            s2=comboBox2.Text;
            s3=comboBox3.Text;
            s4=comboBox4.Text;
            s5=comboBox5.Text;
            s6=comboBox6.Text;
            s7=comboBox7.Text;
            s8=comboBox8.Text;
            s9=comboBox9.Text;
            s10=comboBox10.Text;
            s11=comboBox11.Text;
            s12=comboBox12.Text;
            s13=comboBox13.Text;
            s14=comboBox14.Text;
            s15=comboBox15.Text;
            s16=comboBox16.Text;
            s17=comboBox17.Text;
            s18=comboBox18.Text;
            s19=comboBox19.Text;
            s20 = comboBox20.Text;
            String[] grades = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            int[] points=new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (grades[i] == "S")
                {
                    points[i] = 10;
                }
                else if (grades[i] == "A")
                {
                    points[i] = 9;
                }
                else if (grades[i] == "B")
                {
                    points[i] = 8;
                }
                else if (grades[i] == "C")
                {
                    points[i] = 7;
                }
                else if (grades[i] == "D")
                {
                    points[i] = 6;
                }
                else if (grades[i] == "E")
                {
                    points[i] = 5;
                }
                else if (grades[i] == "F")
                {
                    points[i] = 4;
                }
                else if (grades[i] == "N")
                {
                    points[i] = 3;
                }
                else
                {
                    points[i] = 0;
                }
            }
            p1 = points[0];
            p2 = points[1];
            p3 = points[2];
            p4 = points[3];
            p5 = points[4];
            p6 = points[5];
            p7 = points[6];
            p8 = points[7];
            p9 = points[8];
            p10 = points[9];
            if (s11 == "Credits" || s11 == "")
            {
                c1 = 0;
            }
            else
            {
                c1 = Convert.ToInt32(s11);
            }

            if (s12 == "Credits" || s12 == "")
            {
                c2 = 0;
            }
            else
            {
                c2 = Convert.ToInt32(s12);
            }

            if (s13 == "Credits" || s13 == "")
            {
                c3 = 0;
            }
            else
            {
                c3 = Convert.ToInt32(s13);
            }

            if (s14 == "Credits" || s14 == "")
            {
                c4 = 0;
            }
            else
            {
                c4 = Convert.ToInt32(s14);
            }

            if (s15 == "Credits" || s15 == "")
            {
                c5 = 0;
            }
            else
            {
                c5 = Convert.ToInt32(s15);
            }

            if (s16 == "Credits" || s16 == "")
            {
                c6 = 0;
            }
            else
            {
                c6 = Convert.ToInt32(s16);
            }

            if (s17 == "Credits" || s17 == "")
            {
                c7 = 0;
            }
            else
            {
                c7 = Convert.ToInt32(s17);
            }

            if (s18 == "Credits" || s18 == "")
            {
                c8 = 0;
            }
            else
            {
                c8 = Convert.ToInt32(s18);
            }
            if (s19 == "Credits" || s19 == "")
            {
                c9 = 0;
            }
            else
            {
                c9 = Convert.ToInt32(s19);
            }
            if (s20 == "Credits" || s20 == "")
            {
                c10 = 0;
            }
            else
            {
                c10 = Convert.ToInt32(s20);
            }
            double gpa = obj.calgpa(p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,c1,c2,c3,c4,c5,c6,c7,c8,c9,c10);
            textBox1.Text = gpa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Grades";
            comboBox2.Text = "Grades";
            comboBox3.Text = "Grades";
            comboBox4.Text = "Grades";
            comboBox5.Text = "Grades";
            comboBox6.Text = "Grades";
            comboBox7.Text = "Grades";
            comboBox8.Text = "Grades";
            comboBox9.Text = "Grades";
            comboBox10.Text = "Grades";
            comboBox11.Text = "Credits";
            comboBox12.Text = "Credits";
            comboBox13.Text = "Credits";
            comboBox14.Text = "Credits";
            comboBox15.Text = "Credits";
            comboBox16.Text = "Credits";
            comboBox17.Text = "Credits";
            comboBox18.Text = "Credits";
            comboBox19.Text = "Credits";
            comboBox20.Text = "Credits";
        }

        
    }
}

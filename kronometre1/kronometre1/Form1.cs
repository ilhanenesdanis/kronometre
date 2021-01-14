using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0, salise = 0;

        private void btnsıfırla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            dakika = 0;
            salise = 0;
            saniye = 0;
            label1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToString(dakika) + " : ") + (Convert.ToString(saniye) + " : ") + (Convert.ToString(salise));
            if (salise == 59)
            {
                saniye += 1;
                salise = 0;
                if (saniye == 59)
                {
                    dakika += 1;
                    saniye = 0;
                    if (dakika == 59)
                    {
                        dakika = 0;
                        salise = 0;
                        saniye = 0;
                    }

                }
            }
            salise += 1;
        }

        private void btndur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}

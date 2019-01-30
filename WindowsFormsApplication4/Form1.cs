using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 15; i++)
            {
                PartsCombo.Items.Add(i+1);
            }
            if (string.IsNullOrEmpty(netTextBox.Text) && string.IsNullOrWhiteSpace(PartsCombo.Text))
            {
                CalculImpotB.Visible = true;
            }
            else
                CalculImpotB.Visible = true;

            CalculImpotB.Click += CalculImpotB_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculImpotB_Click(object sender, EventArgs e)
        {
            
            int net, parts, impots, reste;
            string StrImpots;
            net = Convert.ToInt32(netTextBox.Text);
            net = int.Parse(netTextBox.Text);
            parts = Convert.ToInt32(PartsCombo.SelectedIndex+1);

            if (net < 9710)
                impots = 0;
            else if (net < 26818)
            {
                reste = net - 9710;
                impots = (reste * 14) / 100;
            }
            else if (net < 71898)
            {
                reste = net - 26818;
                impots = (17108 * 14) / 100 + (reste * 30) / 100;
            }
            else if (net < 152260)
            {
                reste = net - 71898;
                impots = (17108 * 14) / 100 + (45080 * 30) / 100 + (reste * 41) / 100;
            }
            else
            {
                reste = net - 152260;
                impots = (17108 * 14) / 100 + (45080 * 30) / 100 + (80362 * 41) / 100 + (reste * 45) / 100;
            }

            impots = impots * parts;
            net = net * parts;

            StrImpots = impots.ToString();
            MessageBox.Show(StrImpots);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
			/*
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler();
            timer.Start();
            */
        }


    }
}

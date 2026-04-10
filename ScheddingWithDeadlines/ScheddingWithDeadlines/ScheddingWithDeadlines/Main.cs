using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScheddingWithDeadlines
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            queue_cnt.Text = "Jobs In Queue : [ 7 ] Jobs";
        }

        void schedding()
        {
            int[]
                c = new int[8] { 0, 50, 30, 25, 18, 15, 10, 7 },
                d = new int[8] { 0, 3, 1, 1, 3, 1, 3, 2 },
                j = new int[8] { 0, 1, 0, 0, 0, 0, 0, 0 };

            int k = j[1],
                n = 7;

            for (int i = 2; i <= n; i++)
            {
                int r = k;
                while (d[j[r]] > Math.Max(d[i],  int.Parse(units_txt.Text) * r)) //if each job left C time > C * r//
                    r -= 1;
                if (d[i] > int.Parse(units_txt.Text) * r) //if each job left C time > C * r//
                {
                    for (int m = k; m >= r + 1; m--)
                        j[m + 1] = j[m];
                    j[r + 1] = i;
                    k += 1;
                }
            }
            jlist.Items.Clear();
            srv_lbl.Text = "Services : " + k.ToString();
            for (int i = 0; i < n; i++)
                if (j[i] != 0) jlist.Items.Add(j[i]);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) ? false : true;
        }

        private void processBtn_Click_1(object sender, EventArgs e)
        {
            schedding();
            units_txt.Focus();
            units_txt.SelectAll();
        }
    }
}
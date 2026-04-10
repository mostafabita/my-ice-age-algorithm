using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HanoyTower
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addRingBtn_Click(object sender, EventArgs e)
        {
            if (C.Items.Count > 0)
            {
                A.Items.Clear();
                B.Items.Clear();
                C.Items.Clear();
            }
            A.Items.Add(A.Items.Count == 0 ? 1 : int.Parse(A.Items[A.Items.Count - 1].ToString()) + 1);
            A.TopIndex = 0;
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            if (A.Items.Count > 0)
            {
                logTxt.Text = null;
                addRingBtn.Enabled = processBtn.Enabled = false;
                movesLbl.Tag = 0;
                tower(A.Items.Count, A, B, C);
                addRingBtn.Enabled = processBtn.Enabled = true;
            }
        }

        void tower(int n, ListBox A, ListBox B, ListBox C)
        {
            if (n == 1)
                moveTopOnA2C(A, C);
            else
            {
                tower(n - 1, A, C, B);
                moveTopOnA2C(A, C);
                tower(n - 1, B, A, C);
            }
        }

        void moveTopOnA2C(ListBox A, ListBox C)
        {
            C.Items.Insert(0, A.Items[0]);
            A.Items.RemoveAt(0);
            logTxt.Text += A.Name + " -> " + C.Name + "\r\n";
            movesLbl.Tag = int.Parse(movesLbl.Tag.ToString()) + 1;
            movesLbl.Text = "Moves : " + movesLbl.Tag.ToString();
            Thread.Sleep(100);
            Application.DoEvents();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
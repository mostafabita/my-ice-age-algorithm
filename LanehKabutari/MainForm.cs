using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LanehKabutari
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int maxNum = 0;

        private void inputNumBtn_Click(object sender, EventArgs e)
        {
            inputList.Items.Clear();
            InputForm inf = new InputForm();
            inf.Tag = this;
            inf.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            int[] listU = new int[++maxNum];

            for (int i = 1; i < maxNum; i++)
                listU[i] = 0;

            for (int i = 0; i < inputList.Items.Count; i++)
                listU[int.Parse(inputList.Items[i].ToString())]++;

            for (int i = 1, j = 0; i < maxNum; i++)
                while (listU[i]-- != 0)
                    inputList.Items[j++] = i;
                    //outputList.Items.Add(i);
        }
    }
}
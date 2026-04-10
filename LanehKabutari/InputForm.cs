using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LanehKabutari
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
        {
            MainForm m = this.Tag as MainForm;
            switch (e.KeyCode)
            {
                case Keys.Enter:                    
                    if (inputTxt.Text == string.Empty || int.Parse(inputTxt.Text) == 0)
                    {
                        MessageBox.Show(" ... مقدار ورودی نمیتواند صفر یا خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        inputTxt.SelectAll();
                        return;
                    }
                    m.inputList.Items.Add(inputTxt.Text);
                    if (int.Parse(inputTxt.Text) > m.maxNum) m.maxNum = int.Parse(inputTxt.Text);
                    inputTxt.Clear();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void inputTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar)) e.Handled = true;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
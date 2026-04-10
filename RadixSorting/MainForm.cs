using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RadixSorting
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

        struct structList
        {
            public LinkedList<int> ll;
        }

        structList[] List = new structList[10], ListNew = new structList[10];

        private void runBtn_Click(object sender, EventArgs e)
        {
            radixSort((int)(Math.Log10(maxNum)) + 1);
        }

        void radixSort(int maxLenght)
        {
            for (int i = 0; i < inputList.Items.Count; i++)
                addQueue(ref List[int.Parse(inputList.Items[i].ToString()) % 10], int.Parse(inputList.Items[i].ToString()));
            for (int i = 1; i < maxLenght; i++)
            {
                for (int j = 0; j < 10; j++)
                    while (List[j].ll != null && List[j].ll.Count>0 )
                    {
                        int x = delQueue(ref List[j]);
                        addQueue(ref ListNew[(int)((x % Math.Pow(10, i + 1)) / Math.Pow(10, i))], x);
                    }
                structList[] sl = ListNew;
                ListNew=List;
                List = sl;                
            }
            outputList.Items.Clear();
            for (int i = 0; i < 10; i++)
                while (List[i].ll != null && List[i].ll.Count > 0)
                    outputList.Items.Add(delQueue(ref List[i]));
        }

        void addQueue(ref structList list,int num)
        {
            if (list.ll == null) list.ll = new LinkedList<int>();
            list.ll.AddLast(num);
        }       

        int delQueue(ref structList list)
        {
            int x = list.ll.First.Value;
            list.ll.RemoveFirst();
            return x;
        }
    }
}

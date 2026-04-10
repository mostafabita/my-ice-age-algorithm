using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace KnapsackProblem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        struct goodStructure
        {
            public int weight;
            public int value;
            public float scale;
            public float x;
        }
        ArrayList goodList = new ArrayList();

        private void processBtn_Click(object sender, EventArgs e)
        {
            if (goodList.Count > 0)
            {
                int n = goodList.Count, counter = 0;
                float W = sackWeightTrack.Value, weight = 0;

                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (((goodStructure)goodList[i]).scale < ((goodStructure)goodList[j]).scale)
                        {
                            object temp = goodList[i];
                            goodList[i] = goodList[j];
                            goodList[j] = temp;
                        }

                while (weight < W)
                {
                    goodStructure good = (goodStructure)goodList[counter];
                    if (weight + good.weight <= W)
                    {
                        good.x = 1;
                        weight += good.weight;
                    }
                    else
                    {
                        good.x = (W - weight) / good.weight;
                        weight = W;
                    }
                    goodList[counter++] = good;
                }

                goodListBox.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    goodStructure good = ((goodStructure)goodList[i]);
                    goodListBox.Items.Add(good.weight.ToString() + " کیلوگرم   " + good.value.ToString() + " تومان   " + (good.x == 0 ? "...." : good.x == 1 ? ".... انتخاب شود" : ".... " + decimal.Round((decimal)good.x, 2).ToString() + " حجم کالا برداشته شود."));
                }
                goodListBox.Tag = 1;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((TrackBar)sender, ((TrackBar)sender).Value.ToString());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (goodListBox.Tag.ToString() == "1")
            {
                goodListBox.Items.Clear();
                goodList.Clear();
                goodListBox.Tag = 0;
            }
            goodStructure good=new goodStructure();
            good.weight=weightTrack.Value;
            good.value = costTrack.Value;
            good.scale = good.value / good.weight;
            goodList.Add(good);
            goodListBox.Items.Add(good.weight.ToString() + " کیلوگرم   " + good.value.ToString() + " تومان   ");
        }
    }
}
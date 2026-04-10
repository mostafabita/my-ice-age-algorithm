using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Kruskal_Prim
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        struct NodeStructure
        {
            public int NodeName;
            public Point Point;
        }
        struct JoinStructure
        {
            public int source;
            public int destination;
            public int joinLenght;
            public bool selected;
            public bool prim;
        }

        NodeStructure srcNode;
        ArrayList NodeList = new ArrayList();
        ArrayList JointList = new ArrayList();
        
        private void processBtn_Click(object sender, EventArgs e)
        {
            if (JointList.Count == 0)
            {
                MessageBox.Show("!...مسیری رسم نشده است", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                return;
            }
            for (int i = 0; i < JointList.Count; i++)
            {
                JoinStructure join = (JoinStructure)JointList[i];
                join.prim = false;
                JointList[i] = join;
            }

            Image primTreeImg;

            int n = NodeList.Count;
            int[] B = new int[n];
            B[0] = 1;
            for (int i = 0; i < n; i++)
            {
                int min = -1;
                for (int j = 0; j < JointList.Count; j++)
                {
                    if (min != -1)
                    {
                        if (!((JoinStructure)JointList[j]).selected && ((B[((JoinStructure)JointList[j]).source] == 1 && B[((JoinStructure)JointList[j]).destination] == 0) || (B[((JoinStructure)JointList[j]).source] == 0 && B[((JoinStructure)JointList[j]).destination] == 1)) && ((JoinStructure)JointList[j]).joinLenght < ((JoinStructure)JointList[min]).joinLenght)
                            min = j;
                    }
                    else
                        if (!((JoinStructure)JointList[j]).selected && ((B[((JoinStructure)JointList[j]).source] == 1 && B[((JoinStructure)JointList[j]).destination] == 0) || (B[((JoinStructure)JointList[j]).source] == 0 && B[((JoinStructure)JointList[j]).destination] == 1)))
                            min = j;
                }
                if (min == -1) break;
                JoinStructure join = (JoinStructure)JointList[min];
                join.selected = true;
                join.prim = true;
                JointList[min] = join;
                B[join.destination] = B[join.source] = 1;
            }
            DrawPath(Brushes.Red);
            for (int i = 0; i < JointList.Count; i++)
            {
                JoinStructure join = (JoinStructure)JointList[i];
                join.selected = false;
                join.prim = true;
                JointList[i] = join;
            }
            primTreeImg = PrimGraphBoardPB.Image;

            int[] list = new int[NodeList.Count];
            for (int i = 0; i < NodeList.Count; i++)
                list[i] = i;

            for (int j = 0; j < JointList.Count; j++)
            {
                int min = -1;
                for (int i = 0; i < JointList.Count; i++)
                {
                    if (min != -1)
                    {
                        if (((JoinStructure)JointList[i]).joinLenght < ((JoinStructure)JointList[min]).joinLenght && !((JoinStructure)JointList[i]).selected)
                            min = i;
                    }
                    else
                        if (!((JoinStructure)JointList[i]).selected)
                            min = i;
                }
                bool MST = false;
                int src = list[((JoinStructure)JointList[min]).source], dest = list[((JoinStructure)JointList[min]).destination];
                if (src != dest)
                {
                    for (int i = 0; i < NodeList.Count; i++)
                        if (list[i] == dest)
                            list[i] = src;
                    MST = true;
                }
                JoinStructure join = (JoinStructure)JointList[min];
                join.selected = true;
                join.prim = MST;
                JointList[min] = join;
            }
            DrawPath(Brushes.Green);
            for (int i = 0; i < JointList.Count; i++)
            {
                JoinStructure join = (JoinStructure)JointList[i];
                join.selected = false;
                join.prim = true;
                JointList[i] = join;
            }
            PrimGraphBoardPB.Image = primTreeImg;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            srcNode.NodeName = -1;
            DrawPath(Brushes.Black);
        }

        private void DrawNode(string nodeTxt, Point point,Brush TextColor,Brush BackColor)
        {
            Bitmap bmp = new Bitmap(PrimGraphBoardPB.Image);
            Graphics gph = Graphics.FromImage(bmp);
            gph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gph.FillPie(BackColor, new Rectangle(point.X - 10, point.Y - 10, 20, 20), 0, 360);
            gph.DrawArc(new Pen(TextColor), new Rectangle(point.X - 10, point.Y - 10, 20, 20), 0, 360);
            gph.DrawString(nodeTxt, new Font("tahoma", 8, FontStyle.Bold), TextColor, new PointF(point.X - (gph.MeasureString(nodeTxt, new Font("tahoma", 8, FontStyle.Bold)).Width) / 2, point.Y - 6));
            PrimGraphBoardPB.Image = KruskalGraphBoardPB.Image= bmp;
        }

        private void DrawPath(Brush brush)
        {
            Bitmap bmp = new Bitmap(PrimGraphBoardPB.Width, PrimGraphBoardPB.Height);
            Graphics gph = Graphics.FromImage(bmp);
            gph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gph.FillRectangle(Brushes.LightSteelBlue, new Rectangle(0, 0, bmp.Width, bmp.Height));
            if (allPathChb.Checked)
            {
                for (int i = 0; i < JointList.Count; i++)
                {
                    if (!((JoinStructure)JointList[i]).prim)
                    {
                        Point srcPoint = ((NodeStructure)NodeList[((JoinStructure)JointList[i]).source]).Point, destPoint = ((NodeStructure)NodeList[((JoinStructure)JointList[i]).destination]).Point;
                        gph.DrawLine(new Pen(Brushes.WhiteSmoke), srcPoint, destPoint);
                        gph.DrawString(((JoinStructure)JointList[i]).joinLenght.ToString(), new Font("tahoma", 6, FontStyle.Bold), Brushes.WhiteSmoke, new PointF((Math.Max(srcPoint.X, destPoint.X) + Math.Min(srcPoint.X, destPoint.X)) / 2, (Math.Max(srcPoint.Y, destPoint.Y) + Math.Min(srcPoint.Y, destPoint.Y)) / 2));
                        Application.DoEvents();
                    }
                }
            }
            for (int i = 0; i < JointList.Count; i++)
            {
                if (((JoinStructure)JointList[i]).prim)
                {
                    Point srcPoint = ((NodeStructure)NodeList[((JoinStructure)JointList[i]).source]).Point, destPoint = ((NodeStructure)NodeList[((JoinStructure)JointList[i]).destination]).Point;
                    gph.DrawLine(new Pen(brush), srcPoint, destPoint);
                    gph.DrawString(((JoinStructure)JointList[i]).joinLenght.ToString(), new Font("tahoma", 6, FontStyle.Bold), Brushes.Black, new PointF((Math.Max(srcPoint.X, destPoint.X) + Math.Min(srcPoint.X, destPoint.X)) / 2, (Math.Max(srcPoint.Y, destPoint.Y) + Math.Min(srcPoint.Y, destPoint.Y)) / 2));
                    Application.DoEvents();
                }
            }
            PrimGraphBoardPB.Image = KruskalGraphBoardPB.Image = bmp;
            for (int i = 0; i < NodeList.Count; i++)
                DrawNode(((NodeStructure)NodeList[i]).NodeName.ToString(), ((NodeStructure)NodeList[i]).Point,Brushes.Black,Brushes.Gold);
        }
       
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void graphBoardPB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PrimGraphBoardPB.Cursor == Cursors.Cross)
                {
                    DrawNode(NodeList.Count.ToString(),e.Location,Brushes.Black,Brushes.Gold);
                    NodeStructure Node = new NodeStructure();
                    Node.NodeName = NodeList.Count;
                    Node.Point = new Point(e.X, e.Y);
                    NodeList.Add(Node);
                }
                else
                {
                    MessageBox.Show("!...امکان ایجاد دور وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    srcNode.NodeName = -1;
                }
            }
        }

        private void graphBoardPB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NodeStructure destNode=RecognizeNode(e.X,e.Y);
                if (destNode.NodeName != -1)
                    if (srcNode.NodeName == -1)
                    {
                        srcNode = destNode;
                        DrawNode(srcNode.NodeName.ToString(), srcNode.Point,Brushes.Black,Brushes.Yellow);
                    }
                    else
                    {
                        string ErrText = destNode.Point == srcNode.Point ? "!...امکان ایجاد دور وجود ندارد" : RecognizeJoint(srcNode.NodeName, destNode.NodeName) ? ".این اتصال قبلا ایجاد شده است و امکان برقراری مجدد آن وجود ندارد" : null;
                        if (destNode.Point != srcNode.Point && !RecognizeJoint(srcNode.NodeName, destNode.NodeName))
                        {
                                JoinStructure join = new JoinStructure();
                                join.source = srcNode.NodeName;
                                join.destination = destNode.NodeName;
                                join.joinLenght = (int)Math.Sqrt(Math.Pow(srcNode.Point.X - destNode.Point.X, 2) + Math.Pow(srcNode.Point.Y - destNode.Point.Y, 2));
                                join.selected = false;
                                join.prim = true;
                                JointList.Add(join);

                                DrawPath(Brushes.Black);
                                srcNode.NodeName = -1;
                        }
                        else
                        {
                            MessageBox.Show(ErrText, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                            srcNode.NodeName = -1;
                            DrawPath(Brushes.Black);
                        }
                    }                    
            }
        }

        private bool RecognizeJoint(int src,int dest)
        {
            for (int i = 0; i < JointList.Count; i++)
                if ((((JoinStructure)JointList[i]).source == src && ((JoinStructure)JointList[i]).destination == dest) || (((JoinStructure)JointList[i]).source == dest && ((JoinStructure)JointList[i]).destination == src)) return true;
            return false;
        }

        private NodeStructure RecognizeNode(int X, int Y)
        {
            for (int i = 0; i < NodeList.Count; i++)
                if (X >= ((NodeStructure)NodeList[i]).Point.X-10 && X <= ((NodeStructure)NodeList[i]).Point.X + 10 && Y >= ((NodeStructure)NodeList[i]).Point.Y-10 && Y <= ((NodeStructure)NodeList[i]).Point.Y + 10)
                    return (NodeStructure)NodeList[i];
            NodeStructure nullNode = new NodeStructure();
            nullNode.NodeName = -1;
            return nullNode;
        }

        private void graphBoardPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (RecognizeNode(e.X, e.Y).NodeName != -1)
                PrimGraphBoardPB.Cursor = KruskalGraphBoardPB.Cursor = Cursors.Hand;
            else
                PrimGraphBoardPB.Cursor = KruskalGraphBoardPB.Cursor = Cursors.Cross;
        }
    }
}
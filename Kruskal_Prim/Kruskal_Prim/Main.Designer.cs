namespace Kruskal_Prim
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.processBtn = new System.Windows.Forms.Button();
            this.PrimGraphBoardPB = new System.Windows.Forms.PictureBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.KruskalGraphBoardPB = new System.Windows.Forms.PictureBox();
            this.allPathChb = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrimGraphBoardPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KruskalGraphBoardPB)).BeginInit();
            this.SuspendLayout();
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(823, 12);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(113, 46);
            this.processBtn.TabIndex = 0;
            this.processBtn.Text = "تشکیل درخت های پوشا";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // PrimGraphBoardPB
            // 
            this.PrimGraphBoardPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimGraphBoardPB.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PrimGraphBoardPB.Location = new System.Drawing.Point(12, 12);
            this.PrimGraphBoardPB.Name = "PrimGraphBoardPB";
            this.PrimGraphBoardPB.Size = new System.Drawing.Size(396, 329);
            this.PrimGraphBoardPB.TabIndex = 2;
            this.PrimGraphBoardPB.TabStop = false;
            this.PrimGraphBoardPB.Tag = "1";
            this.toolTip1.SetToolTip(this.PrimGraphBoardPB, "درخت پوشای کمینه");
            this.PrimGraphBoardPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseMove);
            this.PrimGraphBoardPB.Click += new System.EventHandler(this.PrimGraphBoardPB_Click);
            this.PrimGraphBoardPB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseDoubleClick);
            this.PrimGraphBoardPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(823, 64);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(113, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "ریست";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // KruskalGraphBoardPB
            // 
            this.KruskalGraphBoardPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KruskalGraphBoardPB.Cursor = System.Windows.Forms.Cursors.Cross;
            this.KruskalGraphBoardPB.Location = new System.Drawing.Point(421, 12);
            this.KruskalGraphBoardPB.Name = "KruskalGraphBoardPB";
            this.KruskalGraphBoardPB.Size = new System.Drawing.Size(396, 329);
            this.KruskalGraphBoardPB.TabIndex = 6;
            this.KruskalGraphBoardPB.TabStop = false;
            this.KruskalGraphBoardPB.Tag = "1";
            this.toolTip1.SetToolTip(this.KruskalGraphBoardPB, "درخت پوشای مینیمم");
            this.KruskalGraphBoardPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseMove);
            this.KruskalGraphBoardPB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseDoubleClick);
            this.KruskalGraphBoardPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseClick);
            // 
            // allPathChb
            // 
            this.allPathChb.AutoSize = true;
            this.allPathChb.Checked = true;
            this.allPathChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allPathChb.Location = new System.Drawing.Point(823, 324);
            this.allPathChb.Name = "allPathChb";
            this.allPathChb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allPathChb.Size = new System.Drawing.Size(113, 17);
            this.allPathChb.TabIndex = 5;
            this.allPathChb.Text = "رسم تمام مسیرها";
            this.allPathChb.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 353);
            this.Controls.Add(this.KruskalGraphBoardPB);
            this.Controls.Add(this.allPathChb);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.PrimGraphBoardPB);
            this.Controls.Add(this.processBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الگوریتم های پریم و کراسکال";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrimGraphBoardPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KruskalGraphBoardPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.PictureBox PrimGraphBoardPB;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.PictureBox KruskalGraphBoardPB;
        private System.Windows.Forms.CheckBox allPathChb;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


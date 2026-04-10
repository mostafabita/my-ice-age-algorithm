namespace Prim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.processBtn = new System.Windows.Forms.Button();
            this.graphBoardPB = new System.Windows.Forms.PictureBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.allPathChb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBoardPB)).BeginInit();
            this.SuspendLayout();
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(415, 12);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(113, 46);
            this.processBtn.TabIndex = 0;
            this.processBtn.Text = "تشکیل درخت پوشای کمینه";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // graphBoardPB
            // 
            this.graphBoardPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphBoardPB.Cursor = System.Windows.Forms.Cursors.Cross;
            this.graphBoardPB.Location = new System.Drawing.Point(12, 12);
            this.graphBoardPB.Name = "graphBoardPB";
            this.graphBoardPB.Size = new System.Drawing.Size(396, 329);
            this.graphBoardPB.TabIndex = 2;
            this.graphBoardPB.TabStop = false;
            this.graphBoardPB.Tag = "1";
            this.graphBoardPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseMove);
            this.graphBoardPB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseDoubleClick);
            this.graphBoardPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(415, 64);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(113, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "ریست";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // allPathChb
            // 
            this.allPathChb.AutoSize = true;
            this.allPathChb.Checked = true;
            this.allPathChb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allPathChb.Location = new System.Drawing.Point(414, 324);
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
            this.ClientSize = new System.Drawing.Size(535, 353);
            this.Controls.Add(this.allPathChb);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.graphBoardPB);
            this.Controls.Add(this.processBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الگوریتم پریم";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphBoardPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.PictureBox graphBoardPB;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.CheckBox allPathChb;
    }
}


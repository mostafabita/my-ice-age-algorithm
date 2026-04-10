namespace KnapsackProblem
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
            this.costTrack = new System.Windows.Forms.TrackBar();
            this.weightTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sackWeightTrack = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.goodListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.costTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sackWeightTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(240, 257);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(239, 25);
            this.processBtn.TabIndex = 2;
            this.processBtn.Text = ":-) تشخیص بهترین گزینه ها برای سرقت ";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // costTrack
            // 
            this.costTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.costTrack.Location = new System.Drawing.Point(98, 47);
            this.costTrack.Maximum = 1000;
            this.costTrack.Name = "costTrack";
            this.costTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.costTrack.Size = new System.Drawing.Size(45, 176);
            this.costTrack.TabIndex = 2;
            this.costTrack.TickFrequency = 20;
            this.costTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.costTrack.Value = 500;
            this.costTrack.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // weightTrack
            // 
            this.weightTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTrack.Location = new System.Drawing.Point(149, 47);
            this.weightTrack.Maximum = 100;
            this.weightTrack.Name = "weightTrack";
            this.weightTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.weightTrack.Size = new System.Drawing.Size(45, 177);
            this.weightTrack.TabIndex = 3;
            this.weightTrack.TickFrequency = 4;
            this.weightTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.weightTrack.Value = 50;
            this.weightTrack.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "وزن";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ارزش";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(98, 230);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 25);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "اضافه کردن";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sackWeightTrack);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.costTrack);
            this.groupBox1.Controls.Add(this.weightTrack);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(222, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " کالا";
            // 
            // sackWeightTrack
            // 
            this.sackWeightTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sackWeightTrack.Location = new System.Drawing.Point(27, 47);
            this.sackWeightTrack.Maximum = 1000;
            this.sackWeightTrack.Name = "sackWeightTrack";
            this.sackWeightTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sackWeightTrack.Size = new System.Drawing.Size(45, 208);
            this.sackWeightTrack.TabIndex = 8;
            this.sackWeightTrack.TickFrequency = 20;
            this.sackWeightTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sackWeightTrack.Value = 200;
            this.sackWeightTrack.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ظرفیت کوله";
            // 
            // goodListBox
            // 
            this.goodListBox.FormattingEnabled = true;
            this.goodListBox.HorizontalScrollbar = true;
            this.goodListBox.Location = new System.Drawing.Point(242, 12);
            this.goodListBox.Name = "goodListBox";
            this.goodListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.goodListBox.Size = new System.Drawing.Size(236, 238);
            this.goodListBox.TabIndex = 10;
            this.goodListBox.Tag = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 294);
            this.Controls.Add(this.goodListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.processBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مسئله کوله پشتی";
            ((System.ComponentModel.ISupportInitialize)(this.costTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sackWeightTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.TrackBar costTrack;
        private System.Windows.Forms.TrackBar weightTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox goodListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar sackWeightTrack;
    }
}


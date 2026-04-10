namespace ScheddingWithDeadlines
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queue_cnt = new System.Windows.Forms.Label();
            this.srv_lbl = new System.Windows.Forms.Label();
            this.jlist = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.units_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.queue_cnt);
            this.groupBox1.Controls.Add(this.srv_lbl);
            this.groupBox1.Controls.Add(this.jlist);
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // queue_cnt
            // 
            this.queue_cnt.AutoSize = true;
            this.queue_cnt.Location = new System.Drawing.Point(101, 30);
            this.queue_cnt.Name = "queue_cnt";
            this.queue_cnt.Size = new System.Drawing.Size(84, 13);
            this.queue_cnt.TabIndex = 6;
            this.queue_cnt.Text = "Jobs In Queue :";
            // 
            // srv_lbl
            // 
            this.srv_lbl.AutoSize = true;
            this.srv_lbl.Location = new System.Drawing.Point(101, 48);
            this.srv_lbl.Name = "srv_lbl";
            this.srv_lbl.Size = new System.Drawing.Size(62, 13);
            this.srv_lbl.TabIndex = 5;
            this.srv_lbl.Text = "Services : ?";
            // 
            // jlist
            // 
            this.jlist.FormattingEnabled = true;
            this.jlist.Location = new System.Drawing.Point(17, 30);
            this.jlist.Name = "jlist";
            this.jlist.Size = new System.Drawing.Size(78, 173);
            this.jlist.TabIndex = 4;
            this.jlist.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.units_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.processBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initialize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Units";
            // 
            // units_txt
            // 
            this.units_txt.Location = new System.Drawing.Point(127, 33);
            this.units_txt.MaxLength = 1;
            this.units_txt.Name = "units_txt";
            this.units_txt.Size = new System.Drawing.Size(36, 21);
            this.units_txt.TabIndex = 1;
            this.units_txt.Text = "1";
            this.units_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.units_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time For Eeach Job :";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(17, 180);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(129, 23);
            this.processBtn.TabIndex = 2;
            this.processBtn.Text = "Start Servicing";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label queue_cnt;
        private System.Windows.Forms.Label srv_lbl;
        private System.Windows.Forms.ListBox jlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox units_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Label label4;
    }
}


namespace HanoyTower
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.A = new System.Windows.Forms.ListBox();
            this.B = new System.Windows.Forms.ListBox();
            this.C = new System.Windows.Forms.ListBox();
            this.addRingBtn = new System.Windows.Forms.Button();
            this.processBtn = new System.Windows.Forms.Button();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.movesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.FormattingEnabled = true;
            this.A.Location = new System.Drawing.Point(12, 12);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(48, 212);
            this.A.TabIndex = 0;
            this.A.TabStop = false;
            // 
            // B
            // 
            this.B.FormattingEnabled = true;
            this.B.Location = new System.Drawing.Point(82, 12);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(48, 212);
            this.B.TabIndex = 1;
            this.B.TabStop = false;
            // 
            // C
            // 
            this.C.FormattingEnabled = true;
            this.C.Location = new System.Drawing.Point(153, 12);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(48, 212);
            this.C.TabIndex = 2;
            this.C.TabStop = false;
            // 
            // addRingBtn
            // 
            this.addRingBtn.Location = new System.Drawing.Point(12, 236);
            this.addRingBtn.Name = "addRingBtn";
            this.addRingBtn.Size = new System.Drawing.Size(189, 23);
            this.addRingBtn.TabIndex = 0;
            this.addRingBtn.Text = "اضافه کردن حلقه";
            this.addRingBtn.UseVisualStyleBackColor = true;
            this.addRingBtn.Click += new System.EventHandler(this.addRingBtn_Click);
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(12, 265);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(189, 23);
            this.processBtn.TabIndex = 1;
            this.processBtn.Text = "اجرای الگوریتم";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // logTxt
            // 
            this.logTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTxt.Location = new System.Drawing.Point(216, 12);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.ReadOnly = true;
            this.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTxt.Size = new System.Drawing.Size(76, 276);
            this.logTxt.TabIndex = 3;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 294);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(189, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "ریست";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // movesLbl
            // 
            this.movesLbl.AutoSize = true;
            this.movesLbl.Location = new System.Drawing.Point(213, 299);
            this.movesLbl.Name = "movesLbl";
            this.movesLbl.Size = new System.Drawing.Size(54, 13);
            this.movesLbl.TabIndex = 5;
            this.movesLbl.Tag = "0";
            this.movesLbl.Text = "Moves : 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 330);
            this.Controls.Add(this.movesLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.addRingBtn);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برج هانوی";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox A;
        private System.Windows.Forms.ListBox B;
        private System.Windows.Forms.ListBox C;
        private System.Windows.Forms.Button addRingBtn;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label movesLbl;
    }
}


namespace RadixSorting
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
            this.inputList = new System.Windows.Forms.ListBox();
            this.inputNumBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.outputList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inputList
            // 
            this.inputList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputList.FormattingEnabled = true;
            this.inputList.Location = new System.Drawing.Point(95, 12);
            this.inputList.Name = "inputList";
            this.inputList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputList.Size = new System.Drawing.Size(77, 186);
            this.inputList.TabIndex = 0;
            this.inputList.TabStop = false;
            // 
            // inputNumBtn
            // 
            this.inputNumBtn.Location = new System.Drawing.Point(10, 204);
            this.inputNumBtn.Name = "inputNumBtn";
            this.inputNumBtn.Size = new System.Drawing.Size(163, 23);
            this.inputNumBtn.TabIndex = 0;
            this.inputNumBtn.Text = "دریافت اعداد";
            this.inputNumBtn.UseVisualStyleBackColor = true;
            this.inputNumBtn.Click += new System.EventHandler(this.inputNumBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(10, 233);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(163, 23);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "اجرای الگوریتم";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // outputList
            // 
            this.outputList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.outputList.FormattingEnabled = true;
            this.outputList.Location = new System.Drawing.Point(12, 12);
            this.outputList.Name = "outputList";
            this.outputList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.outputList.Size = new System.Drawing.Size(77, 186);
            this.outputList.TabIndex = 2;
            this.outputList.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 266);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.inputNumBtn);
            this.Controls.Add(this.inputList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الگوریتم مبنا";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inputNumBtn;
        private System.Windows.Forms.Button runBtn;
        public System.Windows.Forms.ListBox inputList;
        public System.Windows.Forms.ListBox outputList;
    }
}


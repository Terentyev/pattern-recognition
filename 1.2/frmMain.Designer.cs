namespace _1._2
{
    partial class frmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbGraphics = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.edRandMax = new System.Windows.Forms.NumericUpDown();
            this.lblRandMax = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.edCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.edRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphics)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRandMax)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbGraphics);
            this.pnlMain.Controls.Add(this.pnlControl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(604, 408);
            this.pnlMain.TabIndex = 0;
            // 
            // pbGraphics
            // 
            this.pbGraphics.BackColor = System.Drawing.Color.White;
            this.pbGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraphics.Location = new System.Drawing.Point(0, 0);
            this.pbGraphics.Name = "pbGraphics";
            this.pbGraphics.Size = new System.Drawing.Size(424, 408);
            this.pbGraphics.TabIndex = 1;
            this.pbGraphics.TabStop = false;
            this.pbGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraphics_Paint);
            this.pbGraphics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGraphics_MouseMove);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.edRandMax);
            this.pnlControl.Controls.Add(this.lblRandMax);
            this.pnlControl.Controls.Add(this.gbInfo);
            this.pnlControl.Controls.Add(this.btnGo);
            this.pnlControl.Controls.Add(this.edCount);
            this.pnlControl.Controls.Add(this.lblCount);
            this.pnlControl.Controls.Add(this.edRadius);
            this.pnlControl.Controls.Add(this.lblRadius);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Location = new System.Drawing.Point(424, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(180, 408);
            this.pnlControl.TabIndex = 0;
            // 
            // edRandMax
            // 
            this.edRandMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edRandMax.Location = new System.Drawing.Point(15, 127);
            this.edRandMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.edRandMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edRandMax.Name = "edRandMax";
            this.edRandMax.Size = new System.Drawing.Size(148, 20);
            this.edRandMax.TabIndex = 7;
            this.edRandMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edRandMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblRandMax
            // 
            this.lblRandMax.AutoSize = true;
            this.lblRandMax.Location = new System.Drawing.Point(12, 111);
            this.lblRandMax.Name = "lblRandMax";
            this.lblRandMax.Size = new System.Drawing.Size(67, 13);
            this.lblRandMax.TabIndex = 6;
            this.lblRandMax.Text = "RAND MAX:";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblInfo);
            this.gbInfo.Location = new System.Drawing.Point(15, 187);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(148, 77);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Резуальтаты испытаний";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(10, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(88, 158);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Вперед!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // edCount
            // 
            this.edCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edCount.Location = new System.Drawing.Point(15, 78);
            this.edCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.edCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edCount.Name = "edCount";
            this.edCount.Size = new System.Drawing.Size(148, 20);
            this.edCount.TabIndex = 3;
            this.edCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 62);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(127, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Количество испытаний:";
            // 
            // edRadius
            // 
            this.edRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edRadius.Location = new System.Drawing.Point(15, 29);
            this.edRadius.Name = "edRadius";
            this.edRadius.Size = new System.Drawing.Size(148, 20);
            this.edRadius.TabIndex = 1;
            this.edRadius.Text = "10";
            this.edRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edRadius.Validating += new System.ComponentModel.CancelEventHandler(this.edRadius_Validating);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 13);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(77, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Радиус круга:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 408);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphics)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRandMax)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox edRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.NumericUpDown edCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown edRandMax;
        private System.Windows.Forms.Label lblRandMax;
        private System.Windows.Forms.PictureBox pbGraphics;
    }
}


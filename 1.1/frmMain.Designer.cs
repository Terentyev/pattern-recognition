namespace _1._1
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
            this.pbGraphic = new System.Windows.Forms.PictureBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.edCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbGraphic);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(652, 515);
            this.pnlMain.TabIndex = 0;
            // 
            // pbGraphic
            // 
            this.pbGraphic.BackColor = System.Drawing.Color.White;
            this.pbGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraphic.Location = new System.Drawing.Point(0, 0);
            this.pbGraphic.Name = "pbGraphic";
            this.pbGraphic.Size = new System.Drawing.Size(477, 515);
            this.pbGraphic.TabIndex = 1;
            this.pbGraphic.TabStop = false;
            this.pbGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraphic_Paint);
            this.pbGraphic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGraphic_MouseMove);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cbPreview);
            this.pnlControls.Controls.Add(this.gbInfo);
            this.pnlControls.Controls.Add(this.btnGo);
            this.pnlControls.Controls.Add(this.edCount);
            this.pnlControls.Controls.Add(this.lblCount);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.Location = new System.Drawing.Point(477, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(175, 515);
            this.pnlControls.TabIndex = 0;
            // 
            // cbPreview
            // 
            this.cbPreview.AutoSize = true;
            this.cbPreview.Checked = true;
            this.cbPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreview.Location = new System.Drawing.Point(6, 154);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(101, 17);
            this.cbPreview.TabIndex = 5;
            this.cbPreview.Text = "Предпросмотр";
            this.cbPreview.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblInfo);
            this.gbInfo.Location = new System.Drawing.Point(6, 80);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(166, 68);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Данные графика";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(97, 51);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Вперед!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // edCount
            // 
            this.edCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edCount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edCount.Location = new System.Drawing.Point(6, 25);
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
            this.edCount.Size = new System.Drawing.Size(166, 20);
            this.edCount.TabIndex = 2;
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
            this.lblCount.Location = new System.Drawing.Point(3, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(127, 13);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Количество испытаний:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown edCount;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pbGraphic;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox cbPreview;
    }
}


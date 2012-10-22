namespace _2._2
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
            this.pnlGraphics = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbGistogramma = new System.Windows.Forms.GroupBox();
            this.lblGistogrammaResolution = new System.Windows.Forms.Label();
            this.lblIntervalPieceOfValue = new System.Windows.Forms.Label();
            this.lblIntervalPieceOf = new System.Windows.Forms.Label();
            this.lblIntervalCountValue = new System.Windows.Forms.Label();
            this.lblIntervalCount = new System.Windows.Forms.Label();
            this.lblIntervalValue = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.gbCharacteristics = new System.Windows.Forms.GroupBox();
            this.lblExcessValue = new System.Windows.Forms.Label();
            this.lblExcess = new System.Windows.Forms.Label();
            this.lblAsymmetryValue = new System.Windows.Forms.Label();
            this.lblAsymmetry = new System.Windows.Forms.Label();
            this.lblDispersionValue = new System.Windows.Forms.Label();
            this.lblDispersion = new System.Windows.Forms.Label();
            this.lblMiddleValue = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.nudVariatesCount = new System.Windows.Forms.NumericUpDown();
            this.lblVariatesCount = new System.Windows.Forms.Label();
            this.ofdVariates = new System.Windows.Forms.OpenFileDialog();
            this.nudGistogrammaResolutionValue = new System.Windows.Forms.NumericUpDown();
            this.nudGistogrammaAValue = new System.Windows.Forms.NumericUpDown();
            this.lblGistogrammaA = new System.Windows.Forms.Label();
            this.nudGistogrammaBValue = new System.Windows.Forms.NumericUpDown();
            this.lblGistogrammaB = new System.Windows.Forms.Label();
            this.btnGistogrammaUpdate = new System.Windows.Forms.Button();
            this.scGraphics = new System.Windows.Forms.SplitContainer();
            this.pbGistogramma = new System.Windows.Forms.PictureBox();
            this.pbProbability = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlGraphics.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.gbGistogramma.SuspendLayout();
            this.gbCharacteristics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariatesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGistogrammaResolutionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGistogrammaAValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGistogrammaBValue)).BeginInit();
            this.scGraphics.Panel1.SuspendLayout();
            this.scGraphics.Panel2.SuspendLayout();
            this.scGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGistogramma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlGraphics);
            this.pnlMain.Controls.Add(this.pnlTools);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(771, 507);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlGraphics
            // 
            this.pnlGraphics.Controls.Add(this.scGraphics);
            this.pnlGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraphics.Location = new System.Drawing.Point(0, 0);
            this.pnlGraphics.Name = "pnlGraphics";
            this.pnlGraphics.Size = new System.Drawing.Size(527, 507);
            this.pnlGraphics.TabIndex = 3;
            // 
            // pnlTools
            // 
            this.pnlTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTools.Controls.Add(this.btnLoad);
            this.pnlTools.Controls.Add(this.gbGistogramma);
            this.pnlTools.Controls.Add(this.gbCharacteristics);
            this.pnlTools.Controls.Add(this.btnGo);
            this.pnlTools.Controls.Add(this.nudVariatesCount);
            this.pnlTools.Controls.Add(this.lblVariatesCount);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(527, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(244, 507);
            this.pnlTools.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(10, 49);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Загрузить...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbGistogramma
            // 
            this.gbGistogramma.Controls.Add(this.btnGistogrammaUpdate);
            this.gbGistogramma.Controls.Add(this.nudGistogrammaBValue);
            this.gbGistogramma.Controls.Add(this.lblGistogrammaB);
            this.gbGistogramma.Controls.Add(this.nudGistogrammaAValue);
            this.gbGistogramma.Controls.Add(this.lblGistogrammaA);
            this.gbGistogramma.Controls.Add(this.nudGistogrammaResolutionValue);
            this.gbGistogramma.Controls.Add(this.lblGistogrammaResolution);
            this.gbGistogramma.Controls.Add(this.lblIntervalPieceOfValue);
            this.gbGistogramma.Controls.Add(this.lblIntervalPieceOf);
            this.gbGistogramma.Controls.Add(this.lblIntervalCountValue);
            this.gbGistogramma.Controls.Add(this.lblIntervalCount);
            this.gbGistogramma.Controls.Add(this.lblIntervalValue);
            this.gbGistogramma.Controls.Add(this.lblInterval);
            this.gbGistogramma.Location = new System.Drawing.Point(11, 161);
            this.gbGistogramma.Name = "gbGistogramma";
            this.gbGistogramma.Size = new System.Drawing.Size(223, 171);
            this.gbGistogramma.TabIndex = 4;
            this.gbGistogramma.TabStop = false;
            this.gbGistogramma.Text = "Гистограмма";
            // 
            // lblGistogrammaResolution
            // 
            this.lblGistogrammaResolution.AutoSize = true;
            this.lblGistogrammaResolution.Location = new System.Drawing.Point(6, 16);
            this.lblGistogrammaResolution.Name = "lblGistogrammaResolution";
            this.lblGistogrammaResolution.Size = new System.Drawing.Size(106, 13);
            this.lblGistogrammaResolution.TabIndex = 10;
            this.lblGistogrammaResolution.Text = "Количество шагов: ";
            // 
            // lblIntervalPieceOfValue
            // 
            this.lblIntervalPieceOfValue.AutoSize = true;
            this.lblIntervalPieceOfValue.Location = new System.Drawing.Point(89, 152);
            this.lblIntervalPieceOfValue.Name = "lblIntervalPieceOfValue";
            this.lblIntervalPieceOfValue.Size = new System.Drawing.Size(19, 13);
            this.lblIntervalPieceOfValue.TabIndex = 9;
            this.lblIntervalPieceOfValue.Text = "    ";
            // 
            // lblIntervalPieceOf
            // 
            this.lblIntervalPieceOf.AutoSize = true;
            this.lblIntervalPieceOf.Location = new System.Drawing.Point(6, 152);
            this.lblIntervalPieceOf.Name = "lblIntervalPieceOf";
            this.lblIntervalPieceOf.Size = new System.Drawing.Size(40, 13);
            this.lblIntervalPieceOf.TabIndex = 8;
            this.lblIntervalPieceOf.Text = "Доля: ";
            // 
            // lblIntervalCountValue
            // 
            this.lblIntervalCountValue.AutoSize = true;
            this.lblIntervalCountValue.Location = new System.Drawing.Point(89, 139);
            this.lblIntervalCountValue.Name = "lblIntervalCountValue";
            this.lblIntervalCountValue.Size = new System.Drawing.Size(19, 13);
            this.lblIntervalCountValue.TabIndex = 7;
            this.lblIntervalCountValue.Text = "    ";
            // 
            // lblIntervalCount
            // 
            this.lblIntervalCount.AutoSize = true;
            this.lblIntervalCount.Location = new System.Drawing.Point(6, 139);
            this.lblIntervalCount.Name = "lblIntervalCount";
            this.lblIntervalCount.Size = new System.Drawing.Size(68, 13);
            this.lblIntervalCount.TabIndex = 6;
            this.lblIntervalCount.Text = "Кол-во раз: ";
            // 
            // lblIntervalValue
            // 
            this.lblIntervalValue.AutoSize = true;
            this.lblIntervalValue.Location = new System.Drawing.Point(89, 126);
            this.lblIntervalValue.Name = "lblIntervalValue";
            this.lblIntervalValue.Size = new System.Drawing.Size(19, 13);
            this.lblIntervalValue.TabIndex = 5;
            this.lblIntervalValue.Text = "    ";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(6, 126);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(62, 13);
            this.lblInterval.TabIndex = 4;
            this.lblInterval.Text = "Интервал: ";
            // 
            // gbCharacteristics
            // 
            this.gbCharacteristics.Controls.Add(this.lblExcessValue);
            this.gbCharacteristics.Controls.Add(this.lblExcess);
            this.gbCharacteristics.Controls.Add(this.lblAsymmetryValue);
            this.gbCharacteristics.Controls.Add(this.lblAsymmetry);
            this.gbCharacteristics.Controls.Add(this.lblDispersionValue);
            this.gbCharacteristics.Controls.Add(this.lblDispersion);
            this.gbCharacteristics.Controls.Add(this.lblMiddleValue);
            this.gbCharacteristics.Controls.Add(this.lblMiddle);
            this.gbCharacteristics.Location = new System.Drawing.Point(11, 78);
            this.gbCharacteristics.Name = "gbCharacteristics";
            this.gbCharacteristics.Size = new System.Drawing.Size(223, 77);
            this.gbCharacteristics.TabIndex = 3;
            this.gbCharacteristics.TabStop = false;
            this.gbCharacteristics.Text = "Характеристики";
            // 
            // lblExcessValue
            // 
            this.lblExcessValue.AutoSize = true;
            this.lblExcessValue.Location = new System.Drawing.Point(89, 55);
            this.lblExcessValue.Name = "lblExcessValue";
            this.lblExcessValue.Size = new System.Drawing.Size(19, 13);
            this.lblExcessValue.TabIndex = 7;
            this.lblExcessValue.Text = "    ";
            // 
            // lblExcess
            // 
            this.lblExcess.AutoSize = true;
            this.lblExcess.Location = new System.Drawing.Point(6, 55);
            this.lblExcess.Name = "lblExcess";
            this.lblExcess.Size = new System.Drawing.Size(56, 13);
            this.lblExcess.TabIndex = 6;
            this.lblExcess.Text = "Эксцесс: ";
            // 
            // lblAsymmetryValue
            // 
            this.lblAsymmetryValue.AutoSize = true;
            this.lblAsymmetryValue.Location = new System.Drawing.Point(89, 42);
            this.lblAsymmetryValue.Name = "lblAsymmetryValue";
            this.lblAsymmetryValue.Size = new System.Drawing.Size(19, 13);
            this.lblAsymmetryValue.TabIndex = 5;
            this.lblAsymmetryValue.Text = "    ";
            // 
            // lblAsymmetry
            // 
            this.lblAsymmetry.AutoSize = true;
            this.lblAsymmetry.Location = new System.Drawing.Point(6, 42);
            this.lblAsymmetry.Name = "lblAsymmetry";
            this.lblAsymmetry.Size = new System.Drawing.Size(77, 13);
            this.lblAsymmetry.TabIndex = 4;
            this.lblAsymmetry.Text = "Асимметрия: ";
            // 
            // lblDispersionValue
            // 
            this.lblDispersionValue.AutoSize = true;
            this.lblDispersionValue.Location = new System.Drawing.Point(89, 29);
            this.lblDispersionValue.Name = "lblDispersionValue";
            this.lblDispersionValue.Size = new System.Drawing.Size(19, 13);
            this.lblDispersionValue.TabIndex = 3;
            this.lblDispersionValue.Text = "    ";
            // 
            // lblDispersion
            // 
            this.lblDispersion.AutoSize = true;
            this.lblDispersion.Location = new System.Drawing.Point(6, 29);
            this.lblDispersion.Name = "lblDispersion";
            this.lblDispersion.Size = new System.Drawing.Size(70, 13);
            this.lblDispersion.TabIndex = 2;
            this.lblDispersion.Text = "Дисперсия: ";
            // 
            // lblMiddleValue
            // 
            this.lblMiddleValue.AutoSize = true;
            this.lblMiddleValue.Location = new System.Drawing.Point(89, 16);
            this.lblMiddleValue.Name = "lblMiddleValue";
            this.lblMiddleValue.Size = new System.Drawing.Size(19, 13);
            this.lblMiddleValue.TabIndex = 1;
            this.lblMiddleValue.Text = "    ";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(6, 16);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(56, 13);
            this.lblMiddle.TabIndex = 0;
            this.lblMiddle.Text = "Среднее: ";
            // 
            // btnGo
            // 
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(122, 49);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Вперёд!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // nudVariatesCount
            // 
            this.nudVariatesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudVariatesCount.Location = new System.Drawing.Point(11, 23);
            this.nudVariatesCount.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudVariatesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVariatesCount.Name = "nudVariatesCount";
            this.nudVariatesCount.Size = new System.Drawing.Size(186, 20);
            this.nudVariatesCount.TabIndex = 1;
            this.nudVariatesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVariatesCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblVariatesCount
            // 
            this.lblVariatesCount.AutoSize = true;
            this.lblVariatesCount.Location = new System.Drawing.Point(8, 7);
            this.lblVariatesCount.Name = "lblVariatesCount";
            this.lblVariatesCount.Size = new System.Drawing.Size(169, 13);
            this.lblVariatesCount.TabIndex = 0;
            this.lblVariatesCount.Text = "Количество случайных величин:";
            // 
            // nudGistogrammaResolutionValue
            // 
            this.nudGistogrammaResolutionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudGistogrammaResolutionValue.Location = new System.Drawing.Point(111, 14);
            this.nudGistogrammaResolutionValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudGistogrammaResolutionValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGistogrammaResolutionValue.Name = "nudGistogrammaResolutionValue";
            this.nudGistogrammaResolutionValue.Size = new System.Drawing.Size(106, 20);
            this.nudGistogrammaResolutionValue.TabIndex = 11;
            this.nudGistogrammaResolutionValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGistogrammaResolutionValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudGistogrammaAValue
            // 
            this.nudGistogrammaAValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudGistogrammaAValue.Location = new System.Drawing.Point(111, 40);
            this.nudGistogrammaAValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudGistogrammaAValue.Minimum = new decimal(new int[] {
            -1,
            0,
            0,
            -2147483648});
            this.nudGistogrammaAValue.Name = "nudGistogrammaAValue";
            this.nudGistogrammaAValue.Size = new System.Drawing.Size(106, 20);
            this.nudGistogrammaAValue.TabIndex = 13;
            this.nudGistogrammaAValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGistogrammaAValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            // 
            // lblGistogrammaA
            // 
            this.lblGistogrammaA.AutoSize = true;
            this.lblGistogrammaA.Location = new System.Drawing.Point(6, 42);
            this.lblGistogrammaA.Name = "lblGistogrammaA";
            this.lblGistogrammaA.Size = new System.Drawing.Size(89, 13);
            this.lblGistogrammaA.TabIndex = 12;
            this.lblGistogrammaA.Text = "Левая граница: ";
            // 
            // nudGistogrammaBValue
            // 
            this.nudGistogrammaBValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudGistogrammaBValue.Location = new System.Drawing.Point(111, 69);
            this.nudGistogrammaBValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudGistogrammaBValue.Minimum = new decimal(new int[] {
            -1,
            0,
            0,
            -2147483648});
            this.nudGistogrammaBValue.Name = "nudGistogrammaBValue";
            this.nudGistogrammaBValue.Size = new System.Drawing.Size(106, 20);
            this.nudGistogrammaBValue.TabIndex = 15;
            this.nudGistogrammaBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGistogrammaBValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblGistogrammaB
            // 
            this.lblGistogrammaB.AutoSize = true;
            this.lblGistogrammaB.Location = new System.Drawing.Point(6, 71);
            this.lblGistogrammaB.Name = "lblGistogrammaB";
            this.lblGistogrammaB.Size = new System.Drawing.Size(95, 13);
            this.lblGistogrammaB.TabIndex = 14;
            this.lblGistogrammaB.Text = "Правая граница: ";
            // 
            // btnGistogrammaUpdate
            // 
            this.btnGistogrammaUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGistogrammaUpdate.Location = new System.Drawing.Point(133, 95);
            this.btnGistogrammaUpdate.Name = "btnGistogrammaUpdate";
            this.btnGistogrammaUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnGistogrammaUpdate.TabIndex = 16;
            this.btnGistogrammaUpdate.Text = "Обновить";
            this.btnGistogrammaUpdate.UseVisualStyleBackColor = true;
            this.btnGistogrammaUpdate.Click += new System.EventHandler(this.btnGistogrammaUpdate_Click);
            // 
            // scGraphics
            // 
            this.scGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGraphics.Location = new System.Drawing.Point(0, 0);
            this.scGraphics.Name = "scGraphics";
            // 
            // scGraphics.Panel1
            // 
            this.scGraphics.Panel1.Controls.Add(this.pbGistogramma);
            // 
            // scGraphics.Panel2
            // 
            this.scGraphics.Panel2.Controls.Add(this.pbProbability);
            this.scGraphics.Size = new System.Drawing.Size(527, 507);
            this.scGraphics.SplitterDistance = 269;
            this.scGraphics.TabIndex = 4;
            // 
            // pbGistogramma
            // 
            this.pbGistogramma.BackColor = System.Drawing.Color.White;
            this.pbGistogramma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGistogramma.Location = new System.Drawing.Point(0, 0);
            this.pbGistogramma.Name = "pbGistogramma";
            this.pbGistogramma.Size = new System.Drawing.Size(267, 505);
            this.pbGistogramma.TabIndex = 4;
            this.pbGistogramma.TabStop = false;
            this.pbGistogramma.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGistogramma_Paint);
            this.pbGistogramma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGistogramma_MouseMove);
            this.pbGistogramma.Resize += new System.EventHandler(this.pbGistogramma_Resize);
            // 
            // pbProbability
            // 
            this.pbProbability.BackColor = System.Drawing.Color.White;
            this.pbProbability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProbability.Location = new System.Drawing.Point(0, 0);
            this.pbProbability.Name = "pbProbability";
            this.pbProbability.Size = new System.Drawing.Size(252, 505);
            this.pbProbability.TabIndex = 0;
            this.pbProbability.TabStop = false;
            this.pbProbability.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProbability_Paint);
            this.pbProbability.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbProbability_MouseMove);
            this.pbProbability.Resize += new System.EventHandler(this.pbProbability_Resize);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 507);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlMain.ResumeLayout(false);
            this.pnlGraphics.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.gbGistogramma.ResumeLayout(false);
            this.gbGistogramma.PerformLayout();
            this.gbCharacteristics.ResumeLayout(false);
            this.gbCharacteristics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariatesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGistogrammaResolutionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGistogrammaAValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGistogrammaBValue)).EndInit();
            this.scGraphics.Panel1.ResumeLayout(false);
            this.scGraphics.Panel2.ResumeLayout(false);
            this.scGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGistogramma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProbability)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudVariatesCount;
        private System.Windows.Forms.Label lblVariatesCount;
        private System.Windows.Forms.GroupBox gbCharacteristics;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblMiddleValue;
        private System.Windows.Forms.Label lblDispersionValue;
        private System.Windows.Forms.Label lblDispersion;
        private System.Windows.Forms.Label lblAsymmetryValue;
        private System.Windows.Forms.Label lblAsymmetry;
        private System.Windows.Forms.Label lblExcessValue;
        private System.Windows.Forms.Label lblExcess;
        private System.Windows.Forms.GroupBox gbGistogramma;
        private System.Windows.Forms.Label lblIntervalCountValue;
        private System.Windows.Forms.Label lblIntervalCount;
        private System.Windows.Forms.Label lblIntervalValue;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblIntervalPieceOfValue;
        private System.Windows.Forms.Label lblIntervalPieceOf;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofdVariates;
        private System.Windows.Forms.Panel pnlGraphics;
        private System.Windows.Forms.Label lblGistogrammaResolution;
        private System.Windows.Forms.NumericUpDown nudGistogrammaResolutionValue;
        private System.Windows.Forms.Button btnGistogrammaUpdate;
        private System.Windows.Forms.NumericUpDown nudGistogrammaBValue;
        private System.Windows.Forms.Label lblGistogrammaB;
        private System.Windows.Forms.NumericUpDown nudGistogrammaAValue;
        private System.Windows.Forms.Label lblGistogrammaA;
        private System.Windows.Forms.SplitContainer scGraphics;
        private System.Windows.Forms.PictureBox pbGistogramma;
        private System.Windows.Forms.PictureBox pbProbability;
    }
}


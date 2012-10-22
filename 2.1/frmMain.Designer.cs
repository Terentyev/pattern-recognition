namespace _2._1
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
            this.scGraphics = new System.Windows.Forms.SplitContainer();
            this.pbFrequencies = new System.Windows.Forms.PictureBox();
            this.pbProbability = new System.Windows.Forms.PictureBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbGistogramma = new System.Windows.Forms.GroupBox();
            this.lblSumPieceOfValue = new System.Windows.Forms.Label();
            this.lblSumPieceOf = new System.Windows.Forms.Label();
            this.lblSumCountValue = new System.Windows.Forms.Label();
            this.lblSumCount = new System.Windows.Forms.Label();
            this.lblSumValue = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
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
            this.pnlMain.SuspendLayout();
            this.scGraphics.Panel1.SuspendLayout();
            this.scGraphics.Panel2.SuspendLayout();
            this.scGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrequencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProbability)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.gbGistogramma.SuspendLayout();
            this.gbCharacteristics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariatesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.scGraphics);
            this.pnlMain.Controls.Add(this.pnlTools);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(808, 507);
            this.pnlMain.TabIndex = 0;
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
            this.scGraphics.Panel1.Controls.Add(this.pbFrequencies);
            // 
            // scGraphics.Panel2
            // 
            this.scGraphics.Panel2.Controls.Add(this.pbProbability);
            this.scGraphics.Size = new System.Drawing.Size(592, 507);
            this.scGraphics.SplitterDistance = 287;
            this.scGraphics.TabIndex = 2;
            // 
            // pbFrequencies
            // 
            this.pbFrequencies.BackColor = System.Drawing.Color.White;
            this.pbFrequencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrequencies.Location = new System.Drawing.Point(0, 0);
            this.pbFrequencies.Name = "pbFrequencies";
            this.pbFrequencies.Size = new System.Drawing.Size(285, 505);
            this.pbFrequencies.TabIndex = 2;
            this.pbFrequencies.TabStop = false;
            this.pbFrequencies.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFrequencies_Paint);
            this.pbFrequencies.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFrequencies_MouseMove);
            this.pbFrequencies.Resize += new System.EventHandler(this.pbGraphics_Resize);
            // 
            // pbProbability
            // 
            this.pbProbability.BackColor = System.Drawing.Color.White;
            this.pbProbability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProbability.Location = new System.Drawing.Point(0, 0);
            this.pbProbability.Name = "pbProbability";
            this.pbProbability.Size = new System.Drawing.Size(299, 505);
            this.pbProbability.TabIndex = 0;
            this.pbProbability.TabStop = false;
            this.pbProbability.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProbability_Paint);
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
            this.pnlTools.Location = new System.Drawing.Point(592, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(216, 507);
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
            this.gbGistogramma.Controls.Add(this.lblSumPieceOfValue);
            this.gbGistogramma.Controls.Add(this.lblSumPieceOf);
            this.gbGistogramma.Controls.Add(this.lblSumCountValue);
            this.gbGistogramma.Controls.Add(this.lblSumCount);
            this.gbGistogramma.Controls.Add(this.lblSumValue);
            this.gbGistogramma.Controls.Add(this.lblSum);
            this.gbGistogramma.Location = new System.Drawing.Point(11, 161);
            this.gbGistogramma.Name = "gbGistogramma";
            this.gbGistogramma.Size = new System.Drawing.Size(197, 60);
            this.gbGistogramma.TabIndex = 4;
            this.gbGistogramma.TabStop = false;
            this.gbGistogramma.Text = "Гистограмма";
            // 
            // lblSumPieceOfValue
            // 
            this.lblSumPieceOfValue.AutoSize = true;
            this.lblSumPieceOfValue.Location = new System.Drawing.Point(89, 42);
            this.lblSumPieceOfValue.Name = "lblSumPieceOfValue";
            this.lblSumPieceOfValue.Size = new System.Drawing.Size(19, 13);
            this.lblSumPieceOfValue.TabIndex = 9;
            this.lblSumPieceOfValue.Text = "    ";
            // 
            // lblSumPieceOf
            // 
            this.lblSumPieceOf.AutoSize = true;
            this.lblSumPieceOf.Location = new System.Drawing.Point(6, 42);
            this.lblSumPieceOf.Name = "lblSumPieceOf";
            this.lblSumPieceOf.Size = new System.Drawing.Size(40, 13);
            this.lblSumPieceOf.TabIndex = 8;
            this.lblSumPieceOf.Text = "Доля: ";
            // 
            // lblSumCountValue
            // 
            this.lblSumCountValue.AutoSize = true;
            this.lblSumCountValue.Location = new System.Drawing.Point(89, 29);
            this.lblSumCountValue.Name = "lblSumCountValue";
            this.lblSumCountValue.Size = new System.Drawing.Size(19, 13);
            this.lblSumCountValue.TabIndex = 7;
            this.lblSumCountValue.Text = "    ";
            // 
            // lblSumCount
            // 
            this.lblSumCount.AutoSize = true;
            this.lblSumCount.Location = new System.Drawing.Point(6, 29);
            this.lblSumCount.Name = "lblSumCount";
            this.lblSumCount.Size = new System.Drawing.Size(68, 13);
            this.lblSumCount.TabIndex = 6;
            this.lblSumCount.Text = "Кол-во раз: ";
            // 
            // lblSumValue
            // 
            this.lblSumValue.AutoSize = true;
            this.lblSumValue.Location = new System.Drawing.Point(89, 16);
            this.lblSumValue.Name = "lblSumValue";
            this.lblSumValue.Size = new System.Drawing.Size(19, 13);
            this.lblSumValue.TabIndex = 5;
            this.lblSumValue.Text = "    ";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(6, 16);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(79, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Сумма очков: ";
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
            this.gbCharacteristics.Size = new System.Drawing.Size(197, 77);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 507);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlMain.ResumeLayout(false);
            this.scGraphics.Panel1.ResumeLayout(false);
            this.scGraphics.Panel2.ResumeLayout(false);
            this.scGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrequencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProbability)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.gbGistogramma.ResumeLayout(false);
            this.gbGistogramma.PerformLayout();
            this.gbCharacteristics.ResumeLayout(false);
            this.gbCharacteristics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariatesCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudVariatesCount;
        private System.Windows.Forms.Label lblVariatesCount;
        private System.Windows.Forms.SplitContainer scGraphics;
        private System.Windows.Forms.PictureBox pbFrequencies;
        private System.Windows.Forms.PictureBox pbProbability;
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
        private System.Windows.Forms.Label lblSumCountValue;
        private System.Windows.Forms.Label lblSumCount;
        private System.Windows.Forms.Label lblSumValue;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSumPieceOfValue;
        private System.Windows.Forms.Label lblSumPieceOf;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofdVariates;
    }
}


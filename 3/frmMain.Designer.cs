namespace _3
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
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnDataFileBrowse = new System.Windows.Forms.Button();
            this.tbDataFile = new System.Windows.Forms.TextBox();
            this.lblDataFile = new System.Windows.Forms.Label();
            this.btnDataFileLoad = new System.Windows.Forms.Button();
            this.gbDataInfo = new System.Windows.Forms.GroupBox();
            this.pnlDataInfo = new System.Windows.Forms.Panel();
            this.tcCharacteristics = new System.Windows.Forms.TabControl();
            this.tpDx = new System.Windows.Forms.TabPage();
            this.lbDx = new System.Windows.Forms.ListBox();
            this.tpNormalCorrelationMatrix = new System.Windows.Forms.TabPage();
            this.lbNormalCorrelationMatrix = new System.Windows.Forms.ListBox();
            this.tpMx = new System.Windows.Forms.TabPage();
            this.lbMx = new System.Windows.Forms.ListBox();
            this.tpGraph = new System.Windows.Forms.TabPage();
            this.cbModelPoints = new System.Windows.Forms.CheckBox();
            this.cbCalculatedIsoline = new System.Windows.Forms.CheckBox();
            this.cbModelIsoline = new System.Windows.Forms.CheckBox();
            this.cbSecondDimension = new System.Windows.Forms.ComboBox();
            this.cbFirstDimension = new System.Windows.Forms.ComboBox();
            this.lblSecondDimension = new System.Windows.Forms.Label();
            this.lblFirstDimension = new System.Windows.Forms.Label();
            this.pnlDataGenerate = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.nudVectorsCount = new System.Windows.Forms.NumericUpDown();
            this.lblVectorsCount = new System.Windows.Forms.Label();
            this.btnParamsFileBrowse = new System.Windows.Forms.Button();
            this.tbParamsFile = new System.Windows.Forms.TextBox();
            this.lblParamsFile = new System.Windows.Forms.Label();
            this.btnParamsFileLoad = new System.Windows.Forms.Button();
            this.odParamsFile = new System.Windows.Forms.OpenFileDialog();
            this.sdVectorsToFile = new System.Windows.Forms.SaveFileDialog();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphics)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.gbDataInfo.SuspendLayout();
            this.pnlDataInfo.SuspendLayout();
            this.tcCharacteristics.SuspendLayout();
            this.tpDx.SuspendLayout();
            this.tpNormalCorrelationMatrix.SuspendLayout();
            this.tpMx.SuspendLayout();
            this.tpGraph.SuspendLayout();
            this.pnlDataGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbGraphics);
            this.pnlMain.Controls.Add(this.pnlTools);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(987, 585);
            this.pnlMain.TabIndex = 0;
            // 
            // pbGraphics
            // 
            this.pbGraphics.BackColor = System.Drawing.Color.White;
            this.pbGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraphics.Location = new System.Drawing.Point(0, 0);
            this.pbGraphics.Name = "pbGraphics";
            this.pbGraphics.Size = new System.Drawing.Size(501, 585);
            this.pbGraphics.TabIndex = 1;
            this.pbGraphics.TabStop = false;
            this.pbGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraphics_Paint);
            this.pbGraphics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGraphics_MouseDown);
            this.pbGraphics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGraphics_MouseMove);
            this.pbGraphics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGraphics_MouseUp);
            this.pbGraphics.Resize += new System.EventHandler(this.pbGraphics_Resize);
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnDataFileBrowse);
            this.pnlTools.Controls.Add(this.tbDataFile);
            this.pnlTools.Controls.Add(this.lblDataFile);
            this.pnlTools.Controls.Add(this.btnDataFileLoad);
            this.pnlTools.Controls.Add(this.gbDataInfo);
            this.pnlTools.Controls.Add(this.btnParamsFileBrowse);
            this.pnlTools.Controls.Add(this.tbParamsFile);
            this.pnlTools.Controls.Add(this.lblParamsFile);
            this.pnlTools.Controls.Add(this.btnParamsFileLoad);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(501, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(486, 585);
            this.pnlTools.TabIndex = 0;
            // 
            // btnDataFileBrowse
            // 
            this.btnDataFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataFileBrowse.Location = new System.Drawing.Point(369, 20);
            this.btnDataFileBrowse.Name = "btnDataFileBrowse";
            this.btnDataFileBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnDataFileBrowse.TabIndex = 8;
            this.btnDataFileBrowse.Text = "...";
            this.btnDataFileBrowse.UseVisualStyleBackColor = true;
            this.btnDataFileBrowse.Click += new System.EventHandler(this.btnDataFileBrowse_Click);
            // 
            // tbDataFile
            // 
            this.tbDataFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDataFile.Location = new System.Drawing.Point(248, 23);
            this.tbDataFile.Name = "tbDataFile";
            this.tbDataFile.ReadOnly = true;
            this.tbDataFile.Size = new System.Drawing.Size(117, 20);
            this.tbDataFile.TabIndex = 7;
            // 
            // lblDataFile
            // 
            this.lblDataFile.AutoSize = true;
            this.lblDataFile.Location = new System.Drawing.Point(245, 7);
            this.lblDataFile.Name = "lblDataFile";
            this.lblDataFile.Size = new System.Drawing.Size(97, 13);
            this.lblDataFile.TabIndex = 6;
            this.lblDataFile.Text = "Файл с данными:";
            // 
            // btnDataFileLoad
            // 
            this.btnDataFileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataFileLoad.Location = new System.Drawing.Point(402, 20);
            this.btnDataFileLoad.Name = "btnDataFileLoad";
            this.btnDataFileLoad.Size = new System.Drawing.Size(75, 23);
            this.btnDataFileLoad.TabIndex = 5;
            this.btnDataFileLoad.Text = "Загрузить";
            this.btnDataFileLoad.UseVisualStyleBackColor = true;
            this.btnDataFileLoad.Click += new System.EventHandler(this.btnDataFileLoad_Click);
            // 
            // gbDataInfo
            // 
            this.gbDataInfo.Controls.Add(this.pnlDataInfo);
            this.gbDataInfo.Controls.Add(this.pnlDataGenerate);
            this.gbDataInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDataInfo.Location = new System.Drawing.Point(13, 49);
            this.gbDataInfo.Name = "gbDataInfo";
            this.gbDataInfo.Size = new System.Drawing.Size(464, 524);
            this.gbDataInfo.TabIndex = 4;
            this.gbDataInfo.TabStop = false;
            this.gbDataInfo.Text = "Информация о данных";
            // 
            // pnlDataInfo
            // 
            this.pnlDataInfo.Controls.Add(this.tcCharacteristics);
            this.pnlDataInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataInfo.Location = new System.Drawing.Point(3, 62);
            this.pnlDataInfo.Name = "pnlDataInfo";
            this.pnlDataInfo.Size = new System.Drawing.Size(458, 459);
            this.pnlDataInfo.TabIndex = 1;
            // 
            // tcCharacteristics
            // 
            this.tcCharacteristics.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcCharacteristics.Controls.Add(this.tpDx);
            this.tcCharacteristics.Controls.Add(this.tpNormalCorrelationMatrix);
            this.tcCharacteristics.Controls.Add(this.tpMx);
            this.tcCharacteristics.Controls.Add(this.tpGraph);
            this.tcCharacteristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCharacteristics.Location = new System.Drawing.Point(0, 0);
            this.tcCharacteristics.Multiline = true;
            this.tcCharacteristics.Name = "tcCharacteristics";
            this.tcCharacteristics.SelectedIndex = 0;
            this.tcCharacteristics.Size = new System.Drawing.Size(458, 459);
            this.tcCharacteristics.TabIndex = 0;
            // 
            // tpDx
            // 
            this.tpDx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDx.Controls.Add(this.lbDx);
            this.tpDx.Location = new System.Drawing.Point(4, 25);
            this.tpDx.Name = "tpDx";
            this.tpDx.Padding = new System.Windows.Forms.Padding(3);
            this.tpDx.Size = new System.Drawing.Size(450, 430);
            this.tpDx.TabIndex = 0;
            this.tpDx.Text = "Вектор дисперсий";
            this.tpDx.UseVisualStyleBackColor = true;
            // 
            // lbDx
            // 
            this.lbDx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDx.FormattingEnabled = true;
            this.lbDx.Location = new System.Drawing.Point(3, 3);
            this.lbDx.Name = "lbDx";
            this.lbDx.Size = new System.Drawing.Size(442, 422);
            this.lbDx.TabIndex = 0;
            // 
            // tpNormalCorrelationMatrix
            // 
            this.tpNormalCorrelationMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNormalCorrelationMatrix.Controls.Add(this.lbNormalCorrelationMatrix);
            this.tpNormalCorrelationMatrix.Location = new System.Drawing.Point(4, 25);
            this.tpNormalCorrelationMatrix.Name = "tpNormalCorrelationMatrix";
            this.tpNormalCorrelationMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tpNormalCorrelationMatrix.Size = new System.Drawing.Size(450, 430);
            this.tpNormalCorrelationMatrix.TabIndex = 1;
            this.tpNormalCorrelationMatrix.Text = "Норм. кор. матрица";
            this.tpNormalCorrelationMatrix.UseVisualStyleBackColor = true;
            // 
            // lbNormalCorrelationMatrix
            // 
            this.lbNormalCorrelationMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNormalCorrelationMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNormalCorrelationMatrix.FormattingEnabled = true;
            this.lbNormalCorrelationMatrix.Location = new System.Drawing.Point(3, 3);
            this.lbNormalCorrelationMatrix.Name = "lbNormalCorrelationMatrix";
            this.lbNormalCorrelationMatrix.Size = new System.Drawing.Size(442, 422);
            this.lbNormalCorrelationMatrix.TabIndex = 1;
            // 
            // tpMx
            // 
            this.tpMx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpMx.Controls.Add(this.lbMx);
            this.tpMx.Location = new System.Drawing.Point(4, 25);
            this.tpMx.Name = "tpMx";
            this.tpMx.Padding = new System.Windows.Forms.Padding(3);
            this.tpMx.Size = new System.Drawing.Size(450, 430);
            this.tpMx.TabIndex = 2;
            this.tpMx.Text = "Вектор средних";
            this.tpMx.UseVisualStyleBackColor = true;
            // 
            // lbMx
            // 
            this.lbMx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMx.FormattingEnabled = true;
            this.lbMx.Location = new System.Drawing.Point(3, 3);
            this.lbMx.Name = "lbMx";
            this.lbMx.Size = new System.Drawing.Size(442, 422);
            this.lbMx.TabIndex = 1;
            // 
            // tpGraph
            // 
            this.tpGraph.BackColor = System.Drawing.SystemColors.Control;
            this.tpGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpGraph.Controls.Add(this.cbModelPoints);
            this.tpGraph.Controls.Add(this.cbCalculatedIsoline);
            this.tpGraph.Controls.Add(this.cbModelIsoline);
            this.tpGraph.Controls.Add(this.cbSecondDimension);
            this.tpGraph.Controls.Add(this.cbFirstDimension);
            this.tpGraph.Controls.Add(this.lblSecondDimension);
            this.tpGraph.Controls.Add(this.lblFirstDimension);
            this.tpGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpGraph.Location = new System.Drawing.Point(4, 25);
            this.tpGraph.Name = "tpGraph";
            this.tpGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraph.Size = new System.Drawing.Size(450, 430);
            this.tpGraph.TabIndex = 3;
            this.tpGraph.Text = "График";
            // 
            // cbModelPoints
            // 
            this.cbModelPoints.AutoSize = true;
            this.cbModelPoints.Checked = true;
            this.cbModelPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbModelPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModelPoints.Location = new System.Drawing.Point(20, 125);
            this.cbModelPoints.Name = "cbModelPoints";
            this.cbModelPoints.Size = new System.Drawing.Size(94, 17);
            this.cbModelPoints.TabIndex = 7;
            this.cbModelPoints.Text = "Точки модели";
            this.cbModelPoints.UseVisualStyleBackColor = true;
            this.cbModelPoints.CheckedChanged += new System.EventHandler(this.cbModelIsoline_CheckedChanged);
            // 
            // cbCalculatedIsoline
            // 
            this.cbCalculatedIsoline.AutoSize = true;
            this.cbCalculatedIsoline.Enabled = false;
            this.cbCalculatedIsoline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCalculatedIsoline.Location = new System.Drawing.Point(20, 102);
            this.cbCalculatedIsoline.Name = "cbCalculatedIsoline";
            this.cbCalculatedIsoline.Size = new System.Drawing.Size(112, 17);
            this.cbCalculatedIsoline.TabIndex = 6;
            this.cbCalculatedIsoline.Text = "Изолинии оценок";
            this.cbCalculatedIsoline.UseVisualStyleBackColor = true;
            this.cbCalculatedIsoline.CheckedChanged += new System.EventHandler(this.cbModelIsoline_CheckedChanged);
            // 
            // cbModelIsoline
            // 
            this.cbModelIsoline.AutoSize = true;
            this.cbModelIsoline.Enabled = false;
            this.cbModelIsoline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModelIsoline.Location = new System.Drawing.Point(20, 79);
            this.cbModelIsoline.Name = "cbModelIsoline";
            this.cbModelIsoline.Size = new System.Drawing.Size(114, 17);
            this.cbModelIsoline.TabIndex = 5;
            this.cbModelIsoline.Text = "Изолинии модели";
            this.cbModelIsoline.UseVisualStyleBackColor = true;
            this.cbModelIsoline.CheckedChanged += new System.EventHandler(this.cbModelIsoline_CheckedChanged);
            // 
            // cbSecondDimension
            // 
            this.cbSecondDimension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSecondDimension.FormattingEnabled = true;
            this.cbSecondDimension.Location = new System.Drawing.Point(146, 40);
            this.cbSecondDimension.Name = "cbSecondDimension";
            this.cbSecondDimension.Size = new System.Drawing.Size(73, 21);
            this.cbSecondDimension.TabIndex = 3;
            this.cbSecondDimension.SelectedIndexChanged += new System.EventHandler(this.cbSecondDimension_SelectedIndexChanged);
            // 
            // cbFirstDimension
            // 
            this.cbFirstDimension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFirstDimension.FormattingEnabled = true;
            this.cbFirstDimension.Location = new System.Drawing.Point(146, 13);
            this.cbFirstDimension.Name = "cbFirstDimension";
            this.cbFirstDimension.Size = new System.Drawing.Size(73, 21);
            this.cbFirstDimension.TabIndex = 2;
            this.cbFirstDimension.SelectedIndexChanged += new System.EventHandler(this.cbSecondDimension_SelectedIndexChanged);
            // 
            // lblSecondDimension
            // 
            this.lblSecondDimension.AutoSize = true;
            this.lblSecondDimension.Location = new System.Drawing.Point(17, 43);
            this.lblSecondDimension.Name = "lblSecondDimension";
            this.lblSecondDimension.Size = new System.Drawing.Size(121, 13);
            this.lblSecondDimension.TabIndex = 1;
            this.lblSecondDimension.Text = "Второе измерение (Y):";
            // 
            // lblFirstDimension
            // 
            this.lblFirstDimension.AutoSize = true;
            this.lblFirstDimension.Location = new System.Drawing.Point(17, 16);
            this.lblFirstDimension.Name = "lblFirstDimension";
            this.lblFirstDimension.Size = new System.Drawing.Size(123, 13);
            this.lblFirstDimension.TabIndex = 0;
            this.lblFirstDimension.Text = "Первое измерение (X):";
            // 
            // pnlDataGenerate
            // 
            this.pnlDataGenerate.Controls.Add(this.btnSave);
            this.pnlDataGenerate.Controls.Add(this.btnGenerate);
            this.pnlDataGenerate.Controls.Add(this.nudVectorsCount);
            this.pnlDataGenerate.Controls.Add(this.lblVectorsCount);
            this.pnlDataGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataGenerate.Enabled = false;
            this.pnlDataGenerate.Location = new System.Drawing.Point(3, 16);
            this.pnlDataGenerate.Name = "pnlDataGenerate";
            this.pnlDataGenerate.Size = new System.Drawing.Size(458, 46);
            this.pnlDataGenerate.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(344, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(250, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Генерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // nudVectorsCount
            // 
            this.nudVectorsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudVectorsCount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVectorsCount.Location = new System.Drawing.Point(6, 16);
            this.nudVectorsCount.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudVectorsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVectorsCount.Name = "nudVectorsCount";
            this.nudVectorsCount.Size = new System.Drawing.Size(238, 20);
            this.nudVectorsCount.TabIndex = 1;
            this.nudVectorsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVectorsCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblVectorsCount
            // 
            this.lblVectorsCount.AutoSize = true;
            this.lblVectorsCount.Location = new System.Drawing.Point(3, 0);
            this.lblVectorsCount.Name = "lblVectorsCount";
            this.lblVectorsCount.Size = new System.Drawing.Size(175, 13);
            this.lblVectorsCount.TabIndex = 0;
            this.lblVectorsCount.Text = "Количество случайных векторов:";
            // 
            // btnParamsFileBrowse
            // 
            this.btnParamsFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParamsFileBrowse.Location = new System.Drawing.Point(134, 20);
            this.btnParamsFileBrowse.Name = "btnParamsFileBrowse";
            this.btnParamsFileBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnParamsFileBrowse.TabIndex = 3;
            this.btnParamsFileBrowse.Text = "...";
            this.btnParamsFileBrowse.UseVisualStyleBackColor = true;
            this.btnParamsFileBrowse.Click += new System.EventHandler(this.btnParamsFileBrowse_Click);
            // 
            // tbParamsFile
            // 
            this.tbParamsFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbParamsFile.Location = new System.Drawing.Point(13, 23);
            this.tbParamsFile.Name = "tbParamsFile";
            this.tbParamsFile.ReadOnly = true;
            this.tbParamsFile.Size = new System.Drawing.Size(117, 20);
            this.tbParamsFile.TabIndex = 2;
            this.tbParamsFile.Text = ".\\Params.ipf";
            // 
            // lblParamsFile
            // 
            this.lblParamsFile.AutoSize = true;
            this.lblParamsFile.Location = new System.Drawing.Point(10, 8);
            this.lblParamsFile.Name = "lblParamsFile";
            this.lblParamsFile.Size = new System.Drawing.Size(120, 13);
            this.lblParamsFile.TabIndex = 1;
            this.lblParamsFile.Text = "Файл с параметрами:";
            // 
            // btnParamsFileLoad
            // 
            this.btnParamsFileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParamsFileLoad.Location = new System.Drawing.Point(167, 20);
            this.btnParamsFileLoad.Name = "btnParamsFileLoad";
            this.btnParamsFileLoad.Size = new System.Drawing.Size(75, 23);
            this.btnParamsFileLoad.TabIndex = 0;
            this.btnParamsFileLoad.Text = "Загрузить";
            this.btnParamsFileLoad.UseVisualStyleBackColor = true;
            this.btnParamsFileLoad.Click += new System.EventHandler(this.btnParamsFileLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 585);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.Resize += new System.EventHandler(this.pbGraphics_Resize);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphics)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.gbDataInfo.ResumeLayout(false);
            this.pnlDataInfo.ResumeLayout(false);
            this.tcCharacteristics.ResumeLayout(false);
            this.tpDx.ResumeLayout(false);
            this.tpNormalCorrelationMatrix.ResumeLayout(false);
            this.tpMx.ResumeLayout(false);
            this.tpGraph.ResumeLayout(false);
            this.tpGraph.PerformLayout();
            this.pnlDataGenerate.ResumeLayout(false);
            this.pnlDataGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbGraphics;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnParamsFileBrowse;
        private System.Windows.Forms.TextBox tbParamsFile;
        private System.Windows.Forms.Label lblParamsFile;
        private System.Windows.Forms.Button btnParamsFileLoad;
        private System.Windows.Forms.OpenFileDialog odParamsFile;
        private System.Windows.Forms.Button btnDataFileBrowse;
        private System.Windows.Forms.TextBox tbDataFile;
        private System.Windows.Forms.Label lblDataFile;
        private System.Windows.Forms.Button btnDataFileLoad;
        private System.Windows.Forms.GroupBox gbDataInfo;
        private System.Windows.Forms.Panel pnlDataInfo;
        private System.Windows.Forms.Panel pnlDataGenerate;
        private System.Windows.Forms.NumericUpDown nudVectorsCount;
        private System.Windows.Forms.Label lblVectorsCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sdVectorsToFile;
        private System.Windows.Forms.TabControl tcCharacteristics;
        private System.Windows.Forms.TabPage tpDx;
        private System.Windows.Forms.TabPage tpNormalCorrelationMatrix;
        private System.Windows.Forms.TabPage tpMx;
        private System.Windows.Forms.ListBox lbDx;
        private System.Windows.Forms.ListBox lbMx;
        private System.Windows.Forms.ListBox lbNormalCorrelationMatrix;
        private System.Windows.Forms.TabPage tpGraph;
        private System.Windows.Forms.ComboBox cbSecondDimension;
        private System.Windows.Forms.ComboBox cbFirstDimension;
        private System.Windows.Forms.Label lblSecondDimension;
        private System.Windows.Forms.Label lblFirstDimension;
        private System.Windows.Forms.CheckBox cbModelIsoline;
        private System.Windows.Forms.CheckBox cbModelPoints;
        private System.Windows.Forms.CheckBox cbCalculatedIsoline;
    }
}


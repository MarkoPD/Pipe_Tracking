
namespace PT_W_DB_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPipes = new System.Windows.Forms.DataGridView();
            this.colJobNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoilNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPipeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoodStat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colScrapStat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDropStat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colScrapLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDropLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNextPipe = new System.Windows.Forms.Button();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.lblJobNo = new System.Windows.Forms.Label();
            this.lblCoilNo = new System.Windows.Forms.Label();
            this.txtCoilNo = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNextPipeNo = new System.Windows.Forms.Label();
            this.txtNextPipeNo = new System.Windows.Forms.TextBox();
            this.lblCurrentPipeNo = new System.Windows.Forms.Label();
            this.lblCutLength = new System.Windows.Forms.Label();
            this.txtCutLength = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnEndOfCoil = new System.Windows.Forms.Button();
            this.lblTPipes = new System.Windows.Forms.Label();
            this.lblSLen = new System.Windows.Forms.Label();
            this.lblTotalScrap = new System.Windows.Forms.Label();
            this.lblTotalGoodPipes = new System.Windows.Forms.Label();
            this.lblTGP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPipes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPipes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobNum,
            this.colCoilNum,
            this.colPipeNum,
            this.colMLength,
            this.colGoodStat,
            this.colScrapStat,
            this.colDropStat,
            this.colScrapLen,
            this.colDropLength});
            this.dgvPipes.Location = new System.Drawing.Point(248, 22);
            this.dgvPipes.Name = "dgvPipes";
            this.dgvPipes.RowTemplate.Height = 25;
            this.dgvPipes.Size = new System.Drawing.Size(946, 577);
            this.dgvPipes.TabIndex = 0;
            this.dgvPipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPipes_CellContentClick);
            // 
            // colJobNum
            // 
            this.colJobNum.HeaderText = "Job Number";
            this.colJobNum.Name = "colJobNum";
            // 
            // colCoilNum
            // 
            this.colCoilNum.HeaderText = "Coil Number";
            this.colCoilNum.Name = "colCoilNum";
            // 
            // colPipeNum
            // 
            this.colPipeNum.HeaderText = "Pipe Number";
            this.colPipeNum.Name = "colPipeNum";
            // 
            // colMLength
            // 
            this.colMLength.HeaderText = "Measured Length (m)";
            this.colMLength.Name = "colMLength";
            // 
            // colGoodStat
            // 
            this.colGoodStat.HeaderText = "Good";
            this.colGoodStat.Name = "colGoodStat";
            // 
            // colScrapStat
            // 
            this.colScrapStat.HeaderText = "Scrap";
            this.colScrapStat.Name = "colScrapStat";
            // 
            // colDropStat
            // 
            this.colDropStat.HeaderText = "Dropout";
            this.colDropStat.Name = "colDropStat";
            this.colDropStat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDropStat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colScrapLen
            // 
            this.colScrapLen.HeaderText = "Scrap Length";
            this.colScrapLen.Name = "colScrapLen";
            // 
            // colDropLength
            // 
            this.colDropLength.HeaderText = "Dropout Length";
            this.colDropLength.Name = "colDropLength";
            // 
            // btnNextPipe
            // 
            this.btnNextPipe.Location = new System.Drawing.Point(10, 244);
            this.btnNextPipe.Name = "btnNextPipe";
            this.btnNextPipe.Size = new System.Drawing.Size(220, 34);
            this.btnNextPipe.TabIndex = 2;
            this.btnNextPipe.Text = "Next Pipe";
            this.btnNextPipe.UseVisualStyleBackColor = true;
            this.btnNextPipe.Click += new System.EventHandler(this.btnNextPipe_Click);
            // 
            // txtJobNo
            // 
            this.txtJobNo.Location = new System.Drawing.Point(121, 22);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(109, 23);
            this.txtJobNo.TabIndex = 3;
            // 
            // lblJobNo
            // 
            this.lblJobNo.AutoSize = true;
            this.lblJobNo.Location = new System.Drawing.Point(43, 25);
            this.lblJobNo.Name = "lblJobNo";
            this.lblJobNo.Size = new System.Drawing.Size(72, 15);
            this.lblJobNo.TabIndex = 4;
            this.lblJobNo.Text = "Job Number";
            // 
            // lblCoilNo
            // 
            this.lblCoilNo.AutoSize = true;
            this.lblCoilNo.Location = new System.Drawing.Point(40, 54);
            this.lblCoilNo.Name = "lblCoilNo";
            this.lblCoilNo.Size = new System.Drawing.Size(75, 15);
            this.lblCoilNo.TabIndex = 6;
            this.lblCoilNo.Text = "Coil Number";
            // 
            // txtCoilNo
            // 
            this.txtCoilNo.Location = new System.Drawing.Point(121, 51);
            this.txtCoilNo.Name = "txtCoilNo";
            this.txtCoilNo.Size = new System.Drawing.Size(109, 23);
            this.txtCoilNo.TabIndex = 5;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(121, 139);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(109, 37);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter Info";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNextPipeNo
            // 
            this.lblNextPipeNo.AutoSize = true;
            this.lblNextPipeNo.Location = new System.Drawing.Point(10, 83);
            this.lblNextPipeNo.Name = "lblNextPipeNo";
            this.lblNextPipeNo.Size = new System.Drawing.Size(105, 15);
            this.lblNextPipeNo.TabIndex = 10;
            this.lblNextPipeNo.Text = "Next Pipe Number";
            // 
            // txtNextPipeNo
            // 
            this.txtNextPipeNo.Location = new System.Drawing.Point(121, 80);
            this.txtNextPipeNo.Name = "txtNextPipeNo";
            this.txtNextPipeNo.Size = new System.Drawing.Size(109, 23);
            this.txtNextPipeNo.TabIndex = 9;
            // 
            // lblCurrentPipeNo
            // 
            this.lblCurrentPipeNo.AutoSize = true;
            this.lblCurrentPipeNo.Location = new System.Drawing.Point(12, 587);
            this.lblCurrentPipeNo.Name = "lblCurrentPipeNo";
            this.lblCurrentPipeNo.Size = new System.Drawing.Size(92, 15);
            this.lblCurrentPipeNo.TabIndex = 11;
            this.lblCurrentPipeNo.Text = "Current Pipe No";
            // 
            // lblCutLength
            // 
            this.lblCutLength.AutoSize = true;
            this.lblCutLength.Location = new System.Drawing.Point(49, 113);
            this.lblCutLength.Name = "lblCutLength";
            this.lblCutLength.Size = new System.Drawing.Size(66, 15);
            this.lblCutLength.TabIndex = 13;
            this.lblCutLength.Text = "Cut Length";
            // 
            // txtCutLength
            // 
            this.txtCutLength.Location = new System.Drawing.Point(121, 110);
            this.txtCutLength.Name = "txtCutLength";
            this.txtCutLength.Size = new System.Drawing.Size(109, 23);
            this.txtCutLength.TabIndex = 12;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(126, 460);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(53, 15);
            this.lblCount.TabIndex = 14;
            this.lblCount.Text = "lblCount";
            // 
            // btnEndOfCoil
            // 
            this.btnEndOfCoil.Location = new System.Drawing.Point(10, 284);
            this.btnEndOfCoil.Name = "btnEndOfCoil";
            this.btnEndOfCoil.Size = new System.Drawing.Size(220, 34);
            this.btnEndOfCoil.TabIndex = 15;
            this.btnEndOfCoil.Text = "End Of Coil";
            this.btnEndOfCoil.UseVisualStyleBackColor = true;
            this.btnEndOfCoil.Click += new System.EventHandler(this.btnEndOfCoil_Click);
            // 
            // lblTPipes
            // 
            this.lblTPipes.AutoSize = true;
            this.lblTPipes.Location = new System.Drawing.Point(56, 460);
            this.lblTPipes.Name = "lblTPipes";
            this.lblTPipes.Size = new System.Drawing.Size(69, 15);
            this.lblTPipes.TabIndex = 17;
            this.lblTPipes.Text = "Total Pipes :";
            // 
            // lblSLen
            // 
            this.lblSLen.AutoSize = true;
            this.lblSLen.Location = new System.Drawing.Point(15, 500);
            this.lblSLen.Name = "lblSLen";
            this.lblSLen.Size = new System.Drawing.Size(110, 15);
            this.lblSLen.TabIndex = 18;
            this.lblSLen.Text = "Total Scrap Length :";
            // 
            // lblTotalScrap
            // 
            this.lblTotalScrap.AutoSize = true;
            this.lblTotalScrap.Location = new System.Drawing.Point(126, 500);
            this.lblTotalScrap.Name = "lblTotalScrap";
            this.lblTotalScrap.Size = new System.Drawing.Size(74, 15);
            this.lblTotalScrap.TabIndex = 19;
            this.lblTotalScrap.Text = "lblTotalScrap";
            // 
            // lblTotalGoodPipes
            // 
            this.lblTotalGoodPipes.AutoSize = true;
            this.lblTotalGoodPipes.Location = new System.Drawing.Point(126, 480);
            this.lblTotalGoodPipes.Name = "lblTotalGoodPipes";
            this.lblTotalGoodPipes.Size = new System.Drawing.Size(102, 15);
            this.lblTotalGoodPipes.TabIndex = 21;
            this.lblTotalGoodPipes.Text = "lblTotalGoodPipes";
            // 
            // lblTGP
            // 
            this.lblTGP.AutoSize = true;
            this.lblTGP.Location = new System.Drawing.Point(24, 480);
            this.lblTGP.Name = "lblTGP";
            this.lblTGP.Size = new System.Drawing.Size(101, 15);
            this.lblTGP.TabIndex = 20;
            this.lblTGP.Text = "Total Good Pipes :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 611);
            this.Controls.Add(this.lblTotalGoodPipes);
            this.Controls.Add(this.lblTGP);
            this.Controls.Add(this.lblTotalScrap);
            this.Controls.Add(this.lblSLen);
            this.Controls.Add(this.lblTPipes);
            this.Controls.Add(this.btnEndOfCoil);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCutLength);
            this.Controls.Add(this.txtCutLength);
            this.Controls.Add(this.lblCurrentPipeNo);
            this.Controls.Add(this.lblNextPipeNo);
            this.Controls.Add(this.txtNextPipeNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblCoilNo);
            this.Controls.Add(this.txtCoilNo);
            this.Controls.Add(this.lblJobNo);
            this.Controls.Add(this.txtJobNo);
            this.Controls.Add(this.btnNextPipe);
            this.Controls.Add(this.dgvPipes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoilNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPipeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMLength;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGoodStat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colScrapStat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDropStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScrapLen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDropLength;
        private System.Windows.Forms.Button btnNextPipe;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.Label lblJobNo;
        private System.Windows.Forms.Label lblCoilNo;
        private System.Windows.Forms.TextBox txtCoilNo;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNextPipeNo;
        private System.Windows.Forms.TextBox txtNextPipeNo;
        private System.Windows.Forms.Label lblCurrentPipeNo;
        private System.Windows.Forms.Label lblCutLength;
        private System.Windows.Forms.TextBox txtCutLength;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnEndOfCoil;
        private System.Windows.Forms.Label lblTPipes;
        private System.Windows.Forms.Label lblSLen;
        private System.Windows.Forms.Label lblTotalScrap;
        private System.Windows.Forms.Label lblTotalGoodPipes;
        private System.Windows.Forms.Label lblTGP;
    }
}


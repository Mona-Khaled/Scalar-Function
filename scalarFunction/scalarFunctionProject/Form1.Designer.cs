namespace scalarFunctionProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.combobxTableName = new System.Windows.Forms.ComboBox();
            this.groupdataFunctionName = new System.Windows.Forms.GroupBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxColName = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxResult = new System.Windows.Forms.TextBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.lblnoFn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupdataFunctionName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name :";
            // 
            // combobxTableName
            // 
            this.combobxTableName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobxTableName.FormattingEnabled = true;
            this.combobxTableName.Items.AddRange(new object[] {
            "Employee"});
            this.combobxTableName.Location = new System.Drawing.Point(227, 54);
            this.combobxTableName.Name = "combobxTableName";
            this.combobxTableName.Size = new System.Drawing.Size(505, 29);
            this.combobxTableName.TabIndex = 1;
            this.combobxTableName.SelectedIndexChanged += new System.EventHandler(this.combobxTableName_SelectedIndexChanged);
            // 
            // groupdataFunctionName
            // 
            this.groupdataFunctionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupdataFunctionName.Controls.Add(this.btnCount);
            this.groupdataFunctionName.Controls.Add(this.btnMax);
            this.groupdataFunctionName.Controls.Add(this.btnMin);
            this.groupdataFunctionName.Controls.Add(this.btnAverage);
            this.groupdataFunctionName.Controls.Add(this.btnSum);
            this.groupdataFunctionName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupdataFunctionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupdataFunctionName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupdataFunctionName.Location = new System.Drawing.Point(83, 108);
            this.groupdataFunctionName.Name = "groupdataFunctionName";
            this.groupdataFunctionName.Size = new System.Drawing.Size(660, 152);
            this.groupdataFunctionName.TabIndex = 2;
            this.groupdataFunctionName.TabStop = false;
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCount.Location = new System.Drawing.Point(552, 67);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(95, 38);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMax.Location = new System.Drawing.Point(407, 67);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(128, 38);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMin.Location = new System.Drawing.Point(261, 67);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(130, 38);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Minimum";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAverage.Location = new System.Drawing.Point(122, 67);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(118, 38);
            this.btnAverage.TabIndex = 1;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSum.Location = new System.Drawing.Point(10, 67);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(95, 38);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(79, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colum Name :";
            // 
            // comboBoxColName
            // 
            this.comboBoxColName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxColName.FormattingEnabled = true;
            this.comboBoxColName.Items.AddRange(new object[] {
            "Employee"});
            this.comboBoxColName.Location = new System.Drawing.Point(238, 329);
            this.comboBoxColName.Name = "comboBoxColName";
            this.comboBoxColName.Size = new System.Drawing.Size(505, 29);
            this.comboBoxColName.TabIndex = 4;
            this.comboBoxColName.SelectedIndexChanged += new System.EventHandler(this.comboBoxColName_SelectedIndexChanged);
            this.comboBoxColName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxColName_SelectionChangeCommitted_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalculate.Location = new System.Drawing.Point(282, 428);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(246, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(101, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result :";
            // 
            // textboxResult
            // 
            this.textboxResult.Location = new System.Drawing.Point(185, 524);
            this.textboxResult.Name = "textboxResult";
            this.textboxResult.Size = new System.Drawing.Size(520, 22);
            this.textboxResult.TabIndex = 7;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(765, 122);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(508, 415);
            this.dataGridViewTable.TabIndex = 8;
            // 
            // btnShowData
            // 
            this.btnShowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowData.Location = new System.Drawing.Point(903, 54);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(180, 38);
            this.btnShowData.TabIndex = 9;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // lblnoFn
            // 
            this.lblnoFn.AutoSize = true;
            this.lblnoFn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoFn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblnoFn.Location = new System.Drawing.Point(92, 287);
            this.lblnoFn.Name = "lblnoFn";
            this.lblnoFn.Size = new System.Drawing.Size(257, 23);
            this.lblnoFn.TabIndex = 10;
            this.lblnoFn.Text = "Please choose a function";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(2, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 68);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(765, 122);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(508, 415);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(-5, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65, 682);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1229, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1285, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblnoFn);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.textboxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comboBoxColName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupdataFunctionName);
            this.Controls.Add(this.combobxTableName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupdataFunctionName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobxTableName;
        private System.Windows.Forms.GroupBox groupdataFunctionName;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxColName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxResult;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Label lblnoFn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}


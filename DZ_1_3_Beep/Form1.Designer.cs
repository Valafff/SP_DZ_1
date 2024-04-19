namespace DZ_1_3_Beep
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Beep = new System.Windows.Forms.Button();
			this.btn_MessgeBeep = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.numericUpDown_Duratuon = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown_Hz = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_TypeOfSignal = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Duratuon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hz)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_Beep, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_MessgeBeep, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 211);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btn_Beep
			// 
			this.btn_Beep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Beep.Location = new System.Drawing.Point(3, 108);
			this.btn_Beep.Name = "btn_Beep";
			this.btn_Beep.Size = new System.Drawing.Size(186, 100);
			this.btn_Beep.TabIndex = 0;
			this.btn_Beep.Text = "Сгенерировать произвольный сигнал";
			this.btn_Beep.UseVisualStyleBackColor = true;
			this.btn_Beep.Click += new System.EventHandler(this.btn_Beep_Click);
			// 
			// btn_MessgeBeep
			// 
			this.btn_MessgeBeep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_MessgeBeep.Location = new System.Drawing.Point(195, 108);
			this.btn_MessgeBeep.Name = "btn_MessgeBeep";
			this.btn_MessgeBeep.Size = new System.Drawing.Size(186, 100);
			this.btn_MessgeBeep.TabIndex = 1;
			this.btn_MessgeBeep.Text = "Сгенерировать стандартный сигнал";
			this.btn_MessgeBeep.UseVisualStyleBackColor = true;
			this.btn_MessgeBeep.Click += new System.EventHandler(this.btn_MessgeBeep_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown_Duratuon);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.numericUpDown_Hz);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(186, 99);
			this.panel1.TabIndex = 2;
			// 
			// numericUpDown_Duratuon
			// 
			this.numericUpDown_Duratuon.Location = new System.Drawing.Point(10, 66);
			this.numericUpDown_Duratuon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDown_Duratuon.Name = "numericUpDown_Duratuon";
			this.numericUpDown_Duratuon.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown_Duratuon.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Укажите продолжительность, мс";
			// 
			// numericUpDown_Hz
			// 
			this.numericUpDown_Hz.Location = new System.Drawing.Point(10, 23);
			this.numericUpDown_Hz.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.numericUpDown_Hz.Name = "numericUpDown_Hz";
			this.numericUpDown_Hz.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown_Hz.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Укажите частоту, Hz";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cb_TypeOfSignal);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(195, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(186, 99);
			this.panel2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Выберете тип сигнала";
			// 
			// cb_TypeOfSignal
			// 
			this.cb_TypeOfSignal.FormattingEnabled = true;
			this.cb_TypeOfSignal.Items.AddRange(new object[] {
            "SimpleBeep = 0xFFFFFFFF",
            "MB_OK = 0x00000000L",
            "MB_ICONASTERISK = 0x00000040L",
            "MB_ICONEXCLAMATION = 0x00000030L",
            "MB_ICONERROR = 0x00000010L",
            "MB_ICONHAND = 0x00000010L",
            "MB_ICONINFORMATION = 0x00000040L"});
			this.cb_TypeOfSignal.Location = new System.Drawing.Point(6, 22);
			this.cb_TypeOfSignal.Name = "cb_TypeOfSignal";
			this.cb_TypeOfSignal.Size = new System.Drawing.Size(121, 21);
			this.cb_TypeOfSignal.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Beep";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Duratuon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hz)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_Beep;
		private System.Windows.Forms.Button btn_MessgeBeep;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown numericUpDown_Hz;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown_Duratuon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cb_TypeOfSignal;
		private System.Windows.Forms.Label label3;
	}
}


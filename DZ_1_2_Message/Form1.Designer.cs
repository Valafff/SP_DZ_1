namespace DZ_1_2_Message
{
	partial class SendMessege
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_Apps = new System.Windows.Forms.ComboBox();
			this.btn_Start = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_SearchApp = new System.Windows.Forms.Button();
			this.tb_Title = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Message = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_SendMessege = new System.Windows.Forms.Button();
			this.checkBox_CloseTargetApp = new System.Windows.Forms.CheckBox();
			this.TargetProcess = new System.Diagnostics.Process();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_Start, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 211);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cb_Apps, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 99);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "Укажите или выберете приложение для запуска";
			// 
			// cb_Apps
			// 
			this.cb_Apps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cb_Apps.FormattingEnabled = true;
			this.cb_Apps.Items.AddRange(new object[] {
            "charmap",
            "notepad",
            "cmd"});
			this.cb_Apps.Location = new System.Drawing.Point(3, 52);
			this.cb_Apps.Name = "cb_Apps";
			this.cb_Apps.Size = new System.Drawing.Size(180, 21);
			this.cb_Apps.TabIndex = 1;
			// 
			// btn_Start
			// 
			this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Start.Location = new System.Drawing.Point(195, 3);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(186, 99);
			this.btn_Start.TabIndex = 1;
			this.btn_Start.Text = "Запуск";
			this.btn_Start.UseVisualStyleBackColor = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btn_SearchApp, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.tb_Title, 0, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 108);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 100);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 33);
			this.label2.TabIndex = 0;
			this.label2.Text = "Введите заголовок целевого приложения";
			// 
			// btn_SearchApp
			// 
			this.btn_SearchApp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_SearchApp.Location = new System.Drawing.Point(3, 69);
			this.btn_SearchApp.Name = "btn_SearchApp";
			this.btn_SearchApp.Size = new System.Drawing.Size(180, 28);
			this.btn_SearchApp.TabIndex = 2;
			this.btn_SearchApp.Text = "Поиск окна";
			this.btn_SearchApp.UseVisualStyleBackColor = true;
			this.btn_SearchApp.Click += new System.EventHandler(this.btn_SearchApp_Click);
			// 
			// tb_Title
			// 
			this.tb_Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Title.Location = new System.Drawing.Point(3, 36);
			this.tb_Title.Name = "tb_Title";
			this.tb_Title.Size = new System.Drawing.Size(180, 20);
			this.tb_Title.TabIndex = 3;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tb_Message, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(195, 108);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(186, 100);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 33);
			this.label3.TabIndex = 0;
			this.label3.Text = "Введите сообщение или оставьте поле пустым";
			// 
			// tb_Message
			// 
			this.tb_Message.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Message.Location = new System.Drawing.Point(3, 36);
			this.tb_Message.Name = "tb_Message";
			this.tb_Message.Size = new System.Drawing.Size(180, 20);
			this.tb_Message.TabIndex = 1;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.btn_SendMessege, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.checkBox_CloseTargetApp, 1, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 69);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(180, 28);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// btn_SendMessege
			// 
			this.btn_SendMessege.Dock = System.Windows.Forms.DockStyle.Left;
			this.btn_SendMessege.Location = new System.Drawing.Point(3, 3);
			this.btn_SendMessege.Name = "btn_SendMessege";
			this.btn_SendMessege.Size = new System.Drawing.Size(75, 22);
			this.btn_SendMessege.TabIndex = 3;
			this.btn_SendMessege.Text = "Отправить сообщение";
			this.btn_SendMessege.UseVisualStyleBackColor = true;
			this.btn_SendMessege.Click += new System.EventHandler(this.btn_SendMessege_Click);
			// 
			// checkBox_CloseTargetApp
			// 
			this.checkBox_CloseTargetApp.AutoSize = true;
			this.checkBox_CloseTargetApp.Location = new System.Drawing.Point(93, 3);
			this.checkBox_CloseTargetApp.Name = "checkBox_CloseTargetApp";
			this.checkBox_CloseTargetApp.Size = new System.Drawing.Size(70, 17);
			this.checkBox_CloseTargetApp.TabIndex = 4;
			this.checkBox_CloseTargetApp.Text = "Закрыть";
			this.checkBox_CloseTargetApp.UseVisualStyleBackColor = true;
			// 
			// TargetProcess
			// 
			this.TargetProcess.StartInfo.Domain = "";
			this.TargetProcess.StartInfo.LoadUserProfile = false;
			this.TargetProcess.StartInfo.Password = null;
			this.TargetProcess.StartInfo.StandardErrorEncoding = null;
			this.TargetProcess.StartInfo.StandardOutputEncoding = null;
			this.TargetProcess.StartInfo.UserName = "";
			this.TargetProcess.SynchronizingObject = this;
			// 
			// SendMessege
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SendMessege";
			this.Text = "Методы FindWindow и SendMessage ";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_Apps;
		private System.Windows.Forms.Button btn_Start;
		private System.Diagnostics.Process TargetProcess;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_SearchApp;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Message;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button btn_SendMessege;
		private System.Windows.Forms.CheckBox checkBox_CloseTargetApp;
		private System.Windows.Forms.TextBox tb_Title;
	}
}


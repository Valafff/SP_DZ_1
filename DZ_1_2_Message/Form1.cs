using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;
namespace DZ_1_2_Message
{
	public partial class SendMessege : Form
	{

		IntPtr hWnd = IntPtr.Zero;
		public SendMessege()
		{
			InitializeComponent();
		}

		private void btn_Start_Click(object sender, System.EventArgs e)
		{

			try
			{
				TargetProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(cb_Apps.Text);
				TargetProcess.Start();

			}
			catch (System.Exception)
			{
				MessageBox.Show("Приложение не найдено");
			}
		}

		private void btn_SearchApp_Click(object sender, System.EventArgs e)
		{
			try
			{
				tb_Title.Text = TargetProcess.MainWindowTitle;
				//Получение дискриптора и проверка заголовка
				hWnd = User32DlLLImport.FindWindow(null, TargetProcess.MainWindowTitle);
			}
			catch (Exception)
			{
				MessageBox.Show("Приложение не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			//if (hWnd == IntPtr.Zero || TargetProcess.StartInfo.FileName == "")
			//{
			//	MessageBox.Show("Приложение не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
			//else if (TargetProcess.MainWindowTitle == tb_Title.Text)
			//{
			//	MessageBox.Show("Заголовок совпадает", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//}
			//else
			//{
			//	MessageBox.Show("Заголовок не совпадает", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}

		//Отправка сообщения
		private void btn_SendMessege_Click(object sender, EventArgs e)
		{
			if(!checkBox_CloseTargetApp.Checked)
			{
				User32DlLLImport.SendMessage(hWnd, User32DlLLImport.WM_SETTEXT, IntPtr.Zero, Marshal.StringToBSTR(tb_Message.Text));
			}
			else 
			{
				User32DlLLImport.SendMessage(hWnd, User32DlLLImport.WM_CLOSE, IntPtr.Zero, Marshal.StringToBSTR(tb_Message.Text));
			}
		}

	}
}

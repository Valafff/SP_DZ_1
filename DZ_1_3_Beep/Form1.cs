using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_3_Beep
{
	public partial class Form1 : Form
	{
		int frequency;
		int duration;
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Beep_Click(object sender, EventArgs e)
		{
			frequency = Convert.ToInt32( numericUpDown_Hz.Value);
			duration = Convert.ToInt32(numericUpDown_Duratuon.Value);
			User32DlLLImportBeep.Beep(frequency, duration);
		}

		private void btn_MessgeBeep_Click(object sender, EventArgs e)
		{
			if (cb_TypeOfSignal.SelectedIndex == 0)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.SimpleBeep);
			}
			if (cb_TypeOfSignal.SelectedIndex == 1)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.MB_OK);
			}
			if (cb_TypeOfSignal.SelectedIndex == 2)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.MB_ICONASTERISK);
			}
			if (cb_TypeOfSignal.SelectedIndex == 3)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.MB_ICONEXCLAMATION);
			}
			if (cb_TypeOfSignal.SelectedIndex == 4)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.MB_ICONERROR);
			}
			if (cb_TypeOfSignal.SelectedIndex == 5)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.MB_ICONERROR);
			}
			if (cb_TypeOfSignal.SelectedIndex == 6)
			{
				User32DlLLImportBeep.MessageBeep((uint)User32DlLLImportBeep.MB_ICONINFORMATION);
			}
		}
	}
}

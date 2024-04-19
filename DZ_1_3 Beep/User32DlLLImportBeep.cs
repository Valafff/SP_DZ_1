using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_3_Beep
{
	public class User32DlLLImportBeep
	{
		[DllImport("kernel32.dll")]
		public static extern bool Beep(int frequency, int duration);

		[DllImport("user32.dll")]
		public static extern bool MessageBeep(uint uType);
	}
}

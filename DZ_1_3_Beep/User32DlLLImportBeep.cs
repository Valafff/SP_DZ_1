using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZ_1_3_Beep
{

	public class User32DlLLImportBeep
	{
		public const Int64 SimpleBeep = 0xFFFFFFFF;
		public const Int64 MB_OK = 0x00000000L;
		public const Int64 MB_ICONASTERISK = 0x00000040L;
		public const Int64 MB_ICONEXCLAMATION = 0x00000030L;
		public const Int64 MB_ICONERROR = 0x00000010L;
		public const Int64 MB_ICONHAND = 0x00000010L;
		public const Int64 MB_ICONINFORMATION = 0x00000040L;


		[DllImport("kernel32.dll")]
		public static extern bool Beep(int frequency, int duration);

		[DllImport("user32.dll")]
		public static extern bool MessageBeep(uint uType);
	}

	
}

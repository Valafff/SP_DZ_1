using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1_Hello
{
	internal class Program
	{
		public class FromWinAPI
		{
			[DllImport("User32.dll", ExactSpelling = true)]
			public static extern int MessageBoxA(IntPtr intPtr, string text, string caption, uint type);
		}

		static void Main(string[] args)
		{
			FromWinAPI.MessageBoxA(IntPtr.Zero, "Имя: Виталий", "Обо мне", 0);
			FromWinAPI.MessageBoxA(IntPtr.Zero, "Фамилия: Афанасьев", "Обо мне", 1);
			FromWinAPI.MessageBoxA(IntPtr.Zero, "Вид деятельности: студент Академии ТОП", "Обо мне", 2);
			//FromWinAPI.MessageBoxA(IntPtr.Zero, "test class", "Обо мне", 3);
			//FromWinAPI.MessageBoxA(IntPtr.Zero, "test class", "Обо мне", 4);
			//FromWinAPI.MessageBoxA(IntPtr.Zero, "test class", "Обо мне", 5);
			//FromWinAPI.MessageBoxA(IntPtr.Zero, "test class", "Обо мне", 6);
		}
	}
}

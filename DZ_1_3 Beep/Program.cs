using DZ_1_2_Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ_1_3_Beep
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Выберете тип генерируемого сигнала");
			Console.WriteLine("1. Beep");
			Console.WriteLine("2. MessageBeep");

			int choice;
			//Running a check if you choose the wrong You get Invalid error messages 
			if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
			{
				Console.WriteLine("Invalid choice. Please enter 1 or 2.");
				return;
			}
			//Using the switch statement to run our Beep Sound or messages
			switch (choice)
			{
				case 1:
					Console.WriteLine("Enter the frequency (in Hz) and duration (in milliseconds) of the beep, separated by space:");
					if (!int.TryParse(Console.ReadLine(), out int frequency) || !int.TryParse(Console.ReadLine(), out int duration))
					{
						Console.WriteLine("Invalid input. Please enter valid numbers.");
						return;
					}
					Console.WriteLine("Bewarn Generating beep...");
					User32DlLLImportBeep.Beep(frequency, duration);
					break;

				case 2:
					//https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messagebox
					Console.WriteLine("Enter the type of beep:");
					Console.WriteLine("MB_ICONASTERISK");
					Console.WriteLine("MB_ICONEXCLAMATION");
					Console.WriteLine("MB_ICONHAND");
					Console.WriteLine("MB_ICONQUESTION");
					Console.WriteLine("MB_OK");
					uint beepType;
					if (!uint.TryParse(Console.ReadLine(), out beepType))
					{
						Console.WriteLine("Invalid input. Please enter a valid beep type.");
						return;
					}
					Console.WriteLine("Generating message beep...");
					User32DlLLImportBeep.MessageBeep(beepType);
					break;
			}

			Console.WriteLine("Sound generated. Press any key to exit.");
			Console.ReadKey();
		}
	}
}

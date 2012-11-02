using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AutoTyper {
	/// <summary>
	/// Description of FocusControl.
	/// </summary>
	public class FocusControl {
		[DllImport("user32.dll")]
		public static extern IntPtr GetTopWindow(IntPtr hWnd);
		
		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowCmd uCmd);
		
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, IntPtr lParam);
		
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, StringBuilder lParam);
		
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);
		
		[DllImport("user32.dll", EntryPoint = "SendMessageW")]
		public static extern IntPtr SendMessageW(IntPtr hWnd, UInt32 Msg, Int32 wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
		
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
		
		public const uint WM_GETTEXT = 0x000D;
		
		public enum GetWindowCmd : uint {
    		GW_HWNDFIRST = 0,
    		GW_HWNDLAST = 1,
    		GW_HWNDNEXT = 2,
    		GW_HWNDPREV = 3,
    		GW_OWNER = 4,
    		GW_CHILD = 5,
    		GW_ENABLEDPOPUP = 6
		}
		
		public static IntPtr GetWindowUnder() {
			IntPtr top = GetTopWindow(GetDesktopWindow());
			IntPtr window = GetWindow(top, GetWindowCmd.GW_HWNDNEXT);
			System.Windows.Forms.MessageBox.Show(GetWindowTitle(top));
			System.Windows.Forms.MessageBox.Show(GetWindowTitle(window));
			return window;
		}
		
		public static string GetWindowTitle(IntPtr hwnd) {
			StringBuilder builder = new StringBuilder(1024);
			SendMessage(hwnd, WM_GETTEXT, builder.Capacity, builder);
			return builder.ToString();
		}
		
		public static void FocusWindowUnder() {
			IntPtr window/* = GetTopWindow(GetDesktopWindow());
			while (true) {
				System.Windows.Forms.MessageBox.Show(GetWindowTitle(window));
				window = GetWindow(window, GetWindowCmd.GW_HWNDNEXT);
			}
			
			window = GetWindowUnder();
			SetForegroundWindow(window);*/
		}
	}
}

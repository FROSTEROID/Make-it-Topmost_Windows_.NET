using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MakeItTopmost
{
	public partial class Form1 : Form
	{

		#region DLL and constants
		[DllImport("user32.dll")]
		static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
		// http://msdn.microsoft.com/ru-ru/library/windows/desktop/ms633545%28v=vs.85%29.aspx - The API

		static readonly IntPtr HwndTopmost = new IntPtr(-1);
		static readonly IntPtr HwndNormal = new IntPtr(-2);
		const UInt32 SwpNosize = 0x0001;
		const UInt32 SwpNomove = 0x0002;
		const UInt32 SwpShowwindow = 0x0040;
		#endregion

		#region refreshing
		public Form1()
		{
			InitializeComponent();

			Process[] ps = Process.GetProcesses();
			lb_pids.Items.Clear();
			lb_hwnds.Items.Clear();
			lb_titles.Items.Clear();
			foreach (var p in ps)
			{
				if (!String.IsNullOrEmpty(p.MainWindowTitle))
				{
					if (p.MainWindowTitle == Text) continue; // Don't show ourselves in lists
					lb_pids.Items.Add(p.Id);
					lb_hwnds.Items.Add(p.MainWindowHandle);
					lb_titles.Items.Add(p.MainWindowTitle);
				}
			}
		}

		private void t_updater_Tick(object sender, EventArgs e){
			Process[] ps = Process.GetProcesses();
			lb_pids.Items.Clear();
			lb_hwnds.Items.Clear();
			lb_titles.Items.Clear();
			foreach (var p in ps)
			{
				if (!String.IsNullOrEmpty(p.MainWindowTitle))
				{
					if (p.MainWindowTitle == Text) continue; // Don't show ourselves in lists
					lb_pids.Items.Add(p.Id);
					lb_hwnds.Items.Add(p.MainWindowHandle);
					lb_titles.Items.Add(p.MainWindowTitle);
				}
			}
		}
		#endregion

		#region setting (no)topmost
		private void lb_titles_DoubleClick(object sender, EventArgs e){
			IntPtr hWnd = new IntPtr(Convert.ToInt32(lb_hwnds.SelectedItem.ToString()));
			SetWindowPos(hWnd, HwndTopmost, 0, 0, 0, 0, SwpNosize | SwpNomove | SwpShowwindow);
		}
		private void lb_hwnds_DoubleClick(object sender, EventArgs e)
		{
			if (lb_hwnds.SelectedItem == null) return;

			IntPtr hWnd = new IntPtr(Convert.ToInt32(lb_hwnds.SelectedItem.ToString()));
			SetWindowPos(hWnd, HwndNormal, 0, 0, 0, 0, SwpNosize | SwpNomove);
		}
		#endregion

		#region sync listboxes selection indexes
		private void lb_hwnds_SelectedIndexChanged(object sender, EventArgs e){
			lb_pids.SelectedIndex = lb_titles.SelectedIndex = lb_hwnds.SelectedIndex;
		}

		private void lb_titles_SelectedIndexChanged(object sender, EventArgs e){
			lb_pids.SelectedIndex = lb_hwnds.SelectedIndex = lb_titles.SelectedIndex;
		}

		private void lb_pids_SelectedIndexChanged(object sender, EventArgs e){
			lb_hwnds.SelectedIndex = lb_titles.SelectedIndex = lb_pids.SelectedIndex;
		}
		#endregion

	}
}

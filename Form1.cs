using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsbMemoryCheck
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x0219:
					this.UsbMemoryCheck(ref m);
					break;
			}
			base.WndProc(ref m);
		}

		private void UsbMemoryCheck(ref Message m)
		{
			switch (m.WParam.ToInt32())
			{
				case 0x8000:
					MessageBox.Show("USBメモリが装着されました。");
					break;

				case 0x8004:
					MessageBox.Show("USBメモリが外されました。");
					break;
			}
		}
	}
}

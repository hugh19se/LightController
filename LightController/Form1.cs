using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkStickDotNet;
using System.Windows.Forms;

namespace lightController
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.redValue.Text = Convert.ToString(trackBarRed.Value);
			Variables.Br = Convert.ToByte(trackBarRed.Value);
			changeColor();
		}

		private void redValue_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void trackBarGreen_Scroll(object sender, EventArgs e)
		{
			this.greenValue.Text = Convert.ToString(trackBarGreen.Value);
			Variables.Bg = Convert.ToByte(trackBarGreen.Value);
			changeColor();
		}

		private void trackBarBlue_Scroll(object sender, EventArgs e)
		{
			this.blueValue.Text = Convert.ToString(trackBarBlue.Value);
			Variables.Bb = Convert.ToByte(trackBarBlue.Value);
			changeColor();
		}

		public void changeColor()
		{
			BlinkStick device = BlinkStick.FindFirst();
			if (device == null)
			{
				MessageBox.Show("No Devices found, Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			device.SetMode(2);
			if (device != null)
			{
				if (device.OpenDevice())
				{

					byte[] data = new byte[3 * 8]
						{Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb,Variables.Br, Variables.Bg, Variables.Bb};
					device.SetColors(0, data);
				}
			}
		}

		private void offButton_Click(object sender, EventArgs e)
		{
			Variables.Br = 0;
			Variables.Bg = 0;
			Variables.Bb = 0;
			changeColor();
		}

		

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void redValue_Click_1(object sender, EventArgs e)
		{

		}

		private void trackBarRed_Scroll(object sender, EventArgs e)
		{
			this.redValue.Text = Convert.ToString(trackBarRed.Value);
			Variables.Bg = Convert.ToByte(trackBarRed.Value);
			changeColor();
		}

		private void trackBarGreen_Scroll_1(object sender, EventArgs e)
		{
			this.greenValue.Text = Convert.ToString(trackBarGreen.Value);
			Variables.Br = Convert.ToByte(trackBarGreen.Value);
			changeColor();
		}
	}

	public class Variables
	{
		public static byte Br;
		public static byte Bg;
		public static byte Bb;
	}
}

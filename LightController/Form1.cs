using System;
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
		private void trackBarRed_Scroll(object sender, EventArgs e)
		{
			ColorValues.Bg = Convert.ToByte(trackBarRed.Value);
			changeColor();
			this.redValue.Text = Convert.ToString(trackBarRed.Value);
		}

		private void trackBarGreen_Scroll_1(object sender, EventArgs e)
		{
			ColorValues.Br = Convert.ToByte(trackBarGreen.Value);
			changeColor();
			this.greenValue.Text = Convert.ToString(trackBarGreen.Value);
		}

		private void trackBarBlue_Scroll(object sender, EventArgs e)
		{
			ColorValues.Bb = Convert.ToByte(trackBarBlue.Value);
			changeColor();
			this.blueValue.Text = Convert.ToString(trackBarBlue.Value);
		}

		public void changeColor()
		{
			BlinkStick device = BlinkStick.FindFirst();
			if (device == null)
			{
				MessageBox.Show("No Devices found, Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				trackBarRed.Value = 0;
				trackBarGreen.Value = 0;
				trackBarBlue.Value = 0;
				return;
			}
			device.SetMode(2);
			if (device.OpenDevice())
			{
				byte[] data = new byte[3 * 8];

                for (int i = 0; i < 23; i+=3)
                {
					data[i] = ColorValues.Br;
					data[i + 1] = ColorValues.Bg;
					data[i + 2] = ColorValues.Bb;
                }
				device.SetColors(0, data);
			}
		}

		private void offButton_Click(object sender, EventArgs e)
		{
			ColorValues.Br = 0;
			ColorValues.Bg = 0;
			ColorValues.Bb = 0;
			changeColor();
		}
	}

	public class ColorValues
	{
		public static byte Br;
		public static byte Bg;
		public static byte Bb;
	}
}

namespace lightController
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.titleLabel = new System.Windows.Forms.Label();
            this.redValueLabel = new System.Windows.Forms.Label();
            this.greenValueLabel = new System.Windows.Forms.Label();
            this.blueValueLabel = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.offButton = new System.Windows.Forms.Button();
            this.redValue = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(85, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Light Controller";
            // 
            // redValueLabel
            // 
            this.redValueLabel.AutoSize = true;
            this.redValueLabel.Location = new System.Drawing.Point(136, 59);
            this.redValueLabel.Name = "redValueLabel";
            this.redValueLabel.Size = new System.Drawing.Size(57, 13);
            this.redValueLabel.TabIndex = 2;
            this.redValueLabel.Text = "Red Value";
            // 
            // greenValueLabel
            // 
            this.greenValueLabel.AutoSize = true;
            this.greenValueLabel.Location = new System.Drawing.Point(135, 123);
            this.greenValueLabel.Name = "greenValueLabel";
            this.greenValueLabel.Size = new System.Drawing.Size(66, 13);
            this.greenValueLabel.TabIndex = 3;
            this.greenValueLabel.Text = "Green Value";
            // 
            // blueValueLabel
            // 
            this.blueValueLabel.AutoSize = true;
            this.blueValueLabel.Location = new System.Drawing.Point(135, 192);
            this.blueValueLabel.Name = "blueValueLabel";
            this.blueValueLabel.Size = new System.Drawing.Size(58, 13);
            this.blueValueLabel.TabIndex = 4;
            this.blueValueLabel.Text = "Blue Value";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(89, 208);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBarBlue.TabIndex = 6;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(89, 289);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(124, 23);
            this.offButton.TabIndex = 8;
            this.offButton.Text = "Turn Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // redValue
            // 
            this.redValue.AutoSize = true;
            this.redValue.Location = new System.Drawing.Point(200, 75);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(13, 13);
            this.redValue.TabIndex = 9;
            this.redValue.Text = "0";
            // 
            // greenValue
            // 
            this.greenValue.AutoSize = true;
            this.greenValue.Location = new System.Drawing.Point(200, 144);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(13, 13);
            this.greenValue.TabIndex = 10;
            this.greenValue.Text = "0";
            // 
            // blueValue
            // 
            this.blueValue.AutoSize = true;
            this.blueValue.Location = new System.Drawing.Point(199, 208);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(13, 13);
            this.blueValue.TabIndex = 11;
            this.blueValue.Text = "0";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(89, 75);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 45);
            this.trackBarRed.TabIndex = 12;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(89, 139);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 45);
            this.trackBarGreen.TabIndex = 13;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 371);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.redValue);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.blueValueLabel);
            this.Controls.Add(this.greenValueLabel);
            this.Controls.Add(this.redValueLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "LightController";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label redValueLabel;
		private System.Windows.Forms.Label greenValueLabel;
		private System.Windows.Forms.Label blueValueLabel;
		private System.Windows.Forms.TrackBar trackBarBlue;
		private System.Windows.Forms.Button offButton;
		private System.Windows.Forms.Label redValue;
		private System.Windows.Forms.Label greenValue;
		private System.Windows.Forms.Label blueValue;
		private System.Windows.Forms.TrackBar trackBarRed;
		private System.Windows.Forms.TrackBar trackBarGreen;
	}
}


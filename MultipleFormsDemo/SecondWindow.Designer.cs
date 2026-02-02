namespace MultipleFormsDemo
{
	partial class SecondWindow
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
			buttonChange = new Button();
			SuspendLayout();
			// 
			// buttonChange
			// 
			buttonChange.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonChange.Location = new Point(47, 33);
			buttonChange.Name = "buttonChange";
			buttonChange.Size = new Size(694, 366);
			buttonChange.TabIndex = 0;
			buttonChange.Text = "CHANGE FORM1'S COLOR!!!";
			buttonChange.UseVisualStyleBackColor = true;
			buttonChange.Click += ButtonChange_Click;
			// 
			// SecondWindow
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonChange);
			Name = "SecondWindow";
			Text = "SecondWindow";
			FormClosing += SecondWindow_FormClosing;
			ResumeLayout(false);
		}

		#endregion

		private Button buttonChange;
	}
}
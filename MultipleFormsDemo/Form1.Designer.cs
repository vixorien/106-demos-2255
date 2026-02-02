namespace MultipleFormsDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonMessage = new Button();
			buttonOpenFile = new Button();
			openFileDialog1 = new OpenFileDialog();
			buttonSecondWindow = new Button();
			SuspendLayout();
			// 
			// buttonMessage
			// 
			buttonMessage.Location = new Point(12, 12);
			buttonMessage.Name = "buttonMessage";
			buttonMessage.Size = new Size(170, 150);
			buttonMessage.TabIndex = 0;
			buttonMessage.Text = "Show Message";
			buttonMessage.UseVisualStyleBackColor = true;
			buttonMessage.Click += ButtonMessage_Click;
			// 
			// buttonOpenFile
			// 
			buttonOpenFile.Location = new Point(188, 12);
			buttonOpenFile.Name = "buttonOpenFile";
			buttonOpenFile.Size = new Size(189, 150);
			buttonOpenFile.TabIndex = 1;
			buttonOpenFile.Text = "Open File...";
			buttonOpenFile.UseVisualStyleBackColor = true;
			buttonOpenFile.Click += ButtonOpenFile_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonSecondWindow
			// 
			buttonSecondWindow.Location = new Point(383, 12);
			buttonSecondWindow.Name = "buttonSecondWindow";
			buttonSecondWindow.Size = new Size(183, 150);
			buttonSecondWindow.TabIndex = 2;
			buttonSecondWindow.Text = "Open Second Window";
			buttonSecondWindow.UseVisualStyleBackColor = true;
			buttonSecondWindow.Click += ButtonSecondWindow_Click;
			// 
			// Form1
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(578, 174);
			Controls.Add(buttonSecondWindow);
			Controls.Add(buttonOpenFile);
			Controls.Add(buttonMessage);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonMessage;
		private Button buttonOpenFile;
		private OpenFileDialog openFileDialog1;
		private Button buttonSecondWindow;
	}
}

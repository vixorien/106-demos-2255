namespace UICreationDemo
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
			components = new System.ComponentModel.Container();
			buttonAdd = new Button();
			buttonSubtract = new Button();
			buttonReset = new Button();
			labelCount = new Label();
			textCount = new TextBox();
			timerCount = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// buttonAdd
			// 
			buttonAdd.Location = new Point(12, 12);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(119, 114);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "Add";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += ButtonAdd_Click;
			// 
			// buttonSubtract
			// 
			buttonSubtract.Location = new Point(137, 12);
			buttonSubtract.Name = "buttonSubtract";
			buttonSubtract.Size = new Size(119, 114);
			buttonSubtract.TabIndex = 1;
			buttonSubtract.Text = "Subtract";
			buttonSubtract.UseVisualStyleBackColor = true;
			buttonSubtract.Click += ButtonSubtract_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(262, 12);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(119, 114);
			buttonReset.TabIndex = 2;
			buttonReset.Text = "Reset";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += ButtonReset_Click;
			// 
			// labelCount
			// 
			labelCount.AutoSize = true;
			labelCount.Location = new Point(12, 152);
			labelCount.Name = "labelCount";
			labelCount.Size = new Size(64, 25);
			labelCount.TabIndex = 3;
			labelCount.Text = "Count:";
			// 
			// textCount
			// 
			textCount.Location = new Point(77, 149);
			textCount.Name = "textCount";
			textCount.ReadOnly = true;
			textCount.Size = new Size(304, 31);
			textCount.TabIndex = 4;
			// 
			// timerCount
			// 
			timerCount.Tick += TimerCount_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(397, 205);
			Controls.Add(textCount);
			Controls.Add(labelCount);
			Controls.Add(buttonReset);
			Controls.Add(buttonSubtract);
			Controls.Add(buttonAdd);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "Form1";
			Text = "Counter";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonAdd;
		private Button buttonSubtract;
		private Button buttonReset;
		private Label labelCount;
		private TextBox textCount;
		private System.Windows.Forms.Timer timerCount;
	}
}

// Chris Cascioli
// 2/2/26
// Example of message boxes, open file dialogs and
// inter-form communication between two windows

namespace MultipleFormsDemo
{
	public partial class Form1 : Form
	{
		// Fields
		private SecondWindow window2;

		public Form1()
		{
			InitializeComponent();

			window2 = new SecondWindow(this);
		}

		/// <summary>
		/// Shows a message to the user
		/// </summary>
		private void ButtonMessage_Click(object sender, EventArgs e)
		{
			// Open a simple dialog message box
			MessageBox.Show("I am a message box!");

			// Open a more complex message box
			DialogResult result = MessageBox.Show(
				"I am the text",
				"I am the caption",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Information);

			// Report the result
			MessageBox.Show("You chose " + result);
		}

		private void ButtonOpenFile_Click(object sender, EventArgs e)
		{
			// Show the open file dialog and capture the result
			DialogResult result = openFileDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				MessageBox.Show("You chose " + openFileDialog1.FileName);
			}
		}

		/// <summary>
		/// Opens up the second window of the app
		/// </summary>
		private void ButtonSecondWindow_Click(object sender, EventArgs e)
		{
			window2.Show();
		}
	}
}

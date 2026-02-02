// Chris Cascioli
// 2/2/26
// Second window to interact with the first

namespace MultipleFormsDemo
{
	public partial class SecondWindow : Form
	{
		private Form1 firstWindow;

		public SecondWindow(Form1 firstWindow)
		{
			this.firstWindow = firstWindow;

			InitializeComponent();
		}

		/// <summary>
		/// This event occurs when the form has requested
		/// to be closed but has not done so yet
		/// </summary>
		private void SecondWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Prevent the window from actually closing
			// (canceling its event)
			e.Cancel = true;

			// Hide the dang form
			this.Hide();
		}

		/// <summary>
		/// Changes the background color of form1
		/// </summary>
		private void ButtonChange_Click(object sender, EventArgs e)
		{
			firstWindow.BackColor = Color.Bisque;
		}
	}
}

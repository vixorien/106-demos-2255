// Chris Cascioli
// 1/28/26
// Example of a form (displayable window)

namespace WindowsFormsDemo
{
	internal class MyWindow : Form
	{

		public MyWindow()
		{
			// Changing properties of the form
			this.Text = "I am a window!";
			this.Size = new Size(600, 400);
			this.Location = new Point(300, 300);

			// Create a component
			Button button = new Button();
			button.Text = "Click me!";
			button.BackColor = Color.Coral;
			button.Size = new Size(100, 50);
			button.Location = new Point(20, 20);
			button.Click += Button_Click;
			button.MouseEnter += Button_MouseEnter;

			// Add the button to the form
			this.Controls.Add(button);
		}

		/// <summary>
		/// Called when the mouse cursor enters the button
		/// </summary>
		private void Button_MouseEnter(object? sender, EventArgs e)
		{
			Button button = (Button)sender!;
			
			// Copy/alter/replace
			Point loc = button.Location;
			loc.X += button.Size.Width;
			button.Location = loc;
		}

		/// <summary>
		/// Called when the button is clicked
		/// </summary>
		private void Button_Click(object? sender, EventArgs e)
		{
			Button button = (Button)sender!;
			button.BackColor = Color.Gray;

			// Copy/alter/replace
			//button.Size.Width += 10;
			Size size = button.Size;
			size.Width += 10;
			button.Size = size;
		}
	}
}

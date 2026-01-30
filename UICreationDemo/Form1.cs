// Chris Cascioli
// 1/30/26
// Demo of a simple windows forms app to make a number go up and down

namespace UICreationDemo
{
	public partial class Form1 : Form
	{
		// Fields
		private int count;

		public Form1()
		{
			// Init all my fields
			count = 0;

			InitializeComponent();
		}

		/// <summary>
		/// Initialize the display of the count
		/// at form startup
		/// </summary>
		private void Form1_Load(object sender, EventArgs e)
		{
			textCount.Text = count.ToString();
			
			timerCount.Start();
		}

		/// <summary>
		/// Adds to the counter and redisplays
		/// </summary>
		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			count++;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Subtracts from the counter and redisplays
		/// </summary>
		private void ButtonSubtract_Click(object sender, EventArgs e)
		{
			count--;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Resets the counter to zero and redisplays
		/// </summary>
		private void ButtonReset_Click(object sender, EventArgs e)
		{
			count = 0;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Adds to the counter and redisplays
		/// every time the timer's Tick event is fired
		/// </summary>
		private void TimerCount_Tick(object sender, EventArgs e)
		{
			count++;
			textCount.Text = count.ToString();
		}
	}
}

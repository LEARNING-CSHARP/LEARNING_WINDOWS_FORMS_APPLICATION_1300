namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public int CurrentLeftPanelWidth;

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void leftPanel_DoubleClick(object sender, System.EventArgs e)
		{
			if (leftPanel.Width != 10)
			{
				CurrentLeftPanelWidth = leftPanel.Width;

				leftPanel.Width = 10;
			}
			else
			{
				leftPanel.Width = CurrentLeftPanelWidth;
			}
		}
	}
}

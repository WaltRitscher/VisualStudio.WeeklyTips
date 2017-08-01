using System.Windows;

namespace WeeklyTips.WpfApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		#region Show As Dialog

		private void ShowNormal_Click(object sender, RoutedEventArgs e)
		{
			var win = new Views.SimpleWindow();
			win.Show();
		}

		private void ShowDialog_Click(object sender, RoutedEventArgs e)
		{
			var win = new Views.SimpleWindow();
			win.ShowDialog();
		}

		#endregion Show As Dialog

		#region Null Result
		private void NullResult1_Click(object sender, RoutedEventArgs e)
		{
			bool? result;
			var win = new Views.SimpleWindow();

			// will always be null, as window has not been shown
			result = win.DialogResult;


		}

		private void NullResult2_Click(object sender, RoutedEventArgs e)
		{
			bool? result;
			var win = new Views.SimpleWindow();

			// Show non-modal
			win.Show();
			// will always be null, as window was not shown modal
			result = win.DialogResult;
		}

		#endregion

		#region Boolean Result
		private void TrueFalseResult_Click(object sender, RoutedEventArgs e)
		{
			bool? result;
			var win = new Views.SimpleWindow();

			// will never be null, only true or false
			result = win.ShowDialog();
		}

		private void ReturnBoolValue_Click(object sender, RoutedEventArgs e)
		{
			bool? result;

			// the other window (SimpleWindow) has to set the dialog result to true

			var win = new Views.SimpleWindow();
			result = win.ShowDialog();

			//  Also note that the Dialog will always return false unless you write code to return true.  
			MessageText.Text = result.ToString();
		}
		#endregion

		#region Other Values
		private void OtherValues_Click(object sender, RoutedEventArgs e)
		{
			bool? result;
			var win = new Views.PrintWindow();
			result = win.ShowDialog();

			var numberOfCopies = win.NumberOfCopies; // add custom property to dialog
			MessageText2.Text = numberOfCopies.ToString();
		} 
		#endregion
	}
}
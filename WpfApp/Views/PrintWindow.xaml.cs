using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WeeklyTips.WpfApp.Views
{
	/// <summary>
	/// Interaction logic for PrintWindow.xaml
	/// </summary>
	public partial class PrintWindow : Window
	{
		public PrintWindow()
		{
			InitializeComponent();
		}
		private void OKButton_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = true;
		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = false;
		}

		// create properties to expose values to other pages

		public int NumberOfCopies {
			get
			{
				return int.Parse(numberCopiesTextbox.Text);
			}
			set { numberCopiesTextbox.Text = value.ToString(); }
		}
		public string PrinterName {
			get
			{
				return (listPrinters.SelectedItem as TextBlock).Text;
			}
			set { }
		}
	}
}

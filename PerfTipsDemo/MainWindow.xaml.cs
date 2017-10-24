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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PerfTipsDemo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private async void Button_Click(object sender, RoutedEventArgs e) {
			var nameGen = new NameGeneratorLib.NameGenerator();

			var maleName = nameGen.GetMaleName();
      var maleNames = await nameGen.GetMaleNames(8);
      var femaleNames = await nameGen.GetFemaleNames(8);

      MaleNamesListBox.ItemsSource = maleNames;
      FemaleNamesListBox.ItemsSource = femaleNames;

    }


  }
}

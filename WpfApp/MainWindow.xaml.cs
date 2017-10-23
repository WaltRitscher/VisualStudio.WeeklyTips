using System.Windows;
using System.Windows.Media;

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
      this.Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      GetSource();
    }

    private void GetSource()
    {
      var source = new SalesDataSource();
      Sales1.DataContext = source.GetRandomized();
      Sales2.DataContext = source.GetRandomized();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      GetSource();
    }
  }
}
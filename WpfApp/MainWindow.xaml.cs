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
      SolidSlider1.ValueChanged += Slider_ValueChanged;
      SolidSlider2.ValueChanged += Slider_ValueChanged;
      SpaceSlider1.ValueChanged += Slider_ValueChanged;
      SpaceSlider2.ValueChanged += Slider_ValueChanged;
    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
      DoubleCollection nums = new DoubleCollection();
      nums.Add(SolidSlider1.Value);
      nums.Add(SpaceSlider1.Value);
      nums.Add(SolidSlider2.Value);
      nums.Add(SpaceSlider2.Value);
      mainRect.StrokeDashArray = nums;
    }
  }
}
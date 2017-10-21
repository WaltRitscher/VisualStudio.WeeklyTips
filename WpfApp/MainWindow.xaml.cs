using System;
using System.Collections.Generic;
using System.Globalization;
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

    private void dashBox_TextChanged(object sender, TextChangedEventArgs e)
    {

      DoubleCollection nums = new DoubleCollection();
      nums.Add(GetDash(dashBox1));
      nums.Add(GetDash(dashBox2));
      nums.Add(GetDash(dashBox3));
      nums.Add(GetDash(dashBox4));

      mainRect.StrokeDashArray = nums;
    }

    public double GetDash(TextBox tb)
    {
      if (tb == null) return 0;
      double candidate = 0;
      if (tb.Text.Length > 0)
      {
        double.TryParse(tb.Text, NumberStyles.Any, null, out candidate);

      }
      return candidate;
    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      TextBlock tb = list1.SelectedItem as TextBlock;
      if (tb != null)
      {
        if (tb.Text == "Flat")
        {
          mainRect.StrokeDashCap = PenLineCap.Flat;
        }
        if (tb.Text == "Round")
        {
          mainRect.StrokeDashCap = PenLineCap.Round;
        }
        if (tb.Text == "Triangle")
        {
          mainRect.StrokeDashCap = PenLineCap.Triangle;
        }
        if (tb.Text == "Square")
        {
          mainRect.StrokeDashCap = PenLineCap.Square;
        }

      }
    }
  }

}


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

namespace LinqSetOperators {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    private List<int> setA = new List<int> { 2, 4, 6, 8, 10 };
    private List<int> setB = new List<int> { 2, 3, 4, 5, 6 };
    private List<int> setC = new List<int> { 5, 10, 15 };
    public MainWindow() {
      InitializeComponent();



      SetAListBox.DataContext = setA;

      SetBListBox.DataContext = setB;
      SetCListBox.DataContext = setC;
    }

    private void UnionButton_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Union(setB).ToList();

      #region UpdateUI
      MessageTextBlock.Text = "Union: (A-B) all numbers in both sets - no duplicates.";
      Uri packUri = new Uri("Images/VennUnion.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion
    }

   

    private void Union2Button_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Union(setC).ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Union: (A-C) all numbers in both sets - no duplicates.";
      Uri packUri = new Uri("Images/VennUnion.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion

    }

    private void IntersectButton_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Intersect(setB).ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Intersect: (A-B) unique items that occur in both sets.";
      Uri packUri = new Uri("Images/VennIntersection.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion

    }
    private void Intersect2Button_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Intersect(setC).ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Intersect: (A-C) unique items that occur in both sets.";

      Uri packUri = new Uri("Images/VennIntersection.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion
    }

    private void ExceptButton_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Except(setB).ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Except: (A-B)  items in first source that do not occur in second source.";
      Uri packUri = new Uri("Images/VennExcept.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion
    }

    private void Except2Button_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Except(setC).ToList();

      #region UpdateUI
      MessageTextBlock.Text = "Except: (A-C) items in first source that do not occur in second source.";
      Uri packUri = new Uri("Images/VennExcept.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion
    }

    private void Cartesian1Button_Click(object sender, RoutedEventArgs e) {
      var q = from a in setA
              from b in setB
              select $"{a}, {b} ";

      ResultListBox.DataContext = q.ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Cartesian: (A-B) produces every possible pairing between the items from both sets.";
      Uri packUri = new Uri("Images/VennCartesian.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion

    }

    private void Cartesian2Button_Click(object sender, RoutedEventArgs e) {
      var q = setA.SelectMany(x => setC.Select(y => $"{x}, {y} "));
      ResultListBox.DataContext = q.ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Cartesian: (A-C) produces every possible pairing between the items from both sets.";
      Uri packUri = new Uri("Images/VennCartesian.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri);
#endregion
    }

    private void Cartesian3Button_Click(object sender, RoutedEventArgs e) {
      var q = setA.SelectMany(x => setB.Select(y => $"{x}x{y}={x*y} "));
      ResultListBox.DataContext = q.ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Times Table:";
      Uri packUri = new Uri("Images/VennCartesian.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri);
      #endregion
    }

    private void Cartesian4Button_Click(object sender, RoutedEventArgs e) {
      var q = from a in setA
              from b in setB
              from c in setC
              select $"{a},{b},{c}";

      ResultListBox.DataContext = q.ToList();
      #region UpdateUI
      MessageTextBlock.Text = "Cartesian: (three sets)";
      Uri packUri = new Uri("Images/VennCartesian.png", UriKind.RelativeOrAbsolute);
      VennImage.Source = new BitmapImage(packUri); 
      #endregion
    }
  }
}

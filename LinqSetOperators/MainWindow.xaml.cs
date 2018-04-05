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
      MessageTextBlock.Text = "Union: (A-B) all numbers in both sets - no duplicates.";
    }

    private void IntersectButton_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Intersect(setB).ToList();
      MessageTextBlock.Text = "Intersect: (A-B) unique items that occur in both sets.";

    }

    private void Union2Button_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Union(setC).ToList();
      MessageTextBlock.Text = "Union: (A-C) all numbers in both sets - no duplicates.";

    }

    private void Intersect2Button_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Intersect(setC).ToList();
      MessageTextBlock.Text = "Intersect: (A-C) unique items that occur in both sets.";
    }

    private void ExceptButton_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Except(setB).ToList();
      MessageTextBlock.Text = "Except: (A-B)  items in first source that do not occur in second source.";
    }

    private void Except2Button_Click(object sender, RoutedEventArgs e) {
      ResultListBox.DataContext = setA.Except(setC).ToList();
      MessageTextBlock.Text = "Except: (A-C) items in first source that do not occur in second source.";
    }

    private void Cartesian1Button_Click(object sender, RoutedEventArgs e) {
      var q = from a in setA
              from b in setB
              select $"{a}, {b} ";

      ResultListBox.DataContext = q.ToList();
      MessageTextBlock.Text = "Cartesian: (A-B) produces every possible pairing between the items from both sets.";

    }

    private void Cartesian2Button_Click(object sender, RoutedEventArgs e) {
      var q = setA.SelectMany(x => setC.Select(y => $"{x}, {y} "));
      ResultListBox.DataContext = q.ToList();
      MessageTextBlock.Text = "Cartesian: (A-C) produces every possible pairing between the items from both sets.";
    }

    private void Cartesian3Button_Click(object sender, RoutedEventArgs e) {
      var q = setA.SelectMany(x => setB.Select(y => $"{x}x{y}={x*y} "));
      ResultListBox.DataContext = q.ToList();
      MessageTextBlock.Text = "Times Table:";
    }

    private void Cartesian4Button_Click(object sender, RoutedEventArgs e) {
      var q = from a in setA
              from b in setB
              from c in setC
              select $"{a},{b},{c}";

      ResultListBox.DataContext = q.ToList();
      MessageTextBlock.Text = "Cartesian: (three sets)";
    }
  }
}

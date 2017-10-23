using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.WpfApp
{
  internal class SalesDataSource
  {

    ObservableCollection<int> _sales = new ObservableCollection<int>();
    Random _rand = new Random();
   internal SalesDataSource()
    {
      _sales.Add(100);
      _sales.Add(200);
      _sales.Add(300);
      _sales.Add(400);
      _sales.Add(500);
      _sales.Add(600);
      _sales.Add(700);
    }

    internal ObservableCollection<int> GetAll()
    {
      return _sales;
    }
    internal ObservableCollection<int> GetRandomized()
    {
      var result = new ObservableCollection<int>( _sales.OrderBy(x => _rand.Next()).ToList() );
      return result;
    }
    internal ObservableCollection<int> GetRandomized2()
    {
      var q = from s in _sales
              orderby _rand.Next()
              select s;

      return new ObservableCollection<int> (q.ToList());
    }

     }
}

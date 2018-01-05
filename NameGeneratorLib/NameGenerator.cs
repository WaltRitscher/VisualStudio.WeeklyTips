using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorLib
{

  // https://channel9.msdn.com/Events/Visual-Studio/Connect-event-2014/718
  public class NameGenerator
  {
    private string[] _maleNames;
    private string[] _femaleNames;

    private string[] _surNames;
    private string[] _initials = new string[] { "A.", "B.", "C." };

    private Random _ran = new Random();

    public NameGenerator()
    {
      _surNames = System.IO.File.ReadAllLines("surNames.txt");
      _maleNames = System.IO.File.ReadAllLines("maleNames.txt");
      _femaleNames = System.IO.File.ReadAllLines("femaleNames.txt");

    }

    public string GetFemaleName()
    {
      var randomFirstIndex = _ran.Next(0, _femaleNames.Length - 1);
      var randomSurIndex = _ran.Next(0, _surNames.Length - 1);
      return _femaleNames[randomFirstIndex] + " " + _surNames[randomSurIndex];
    }
    public async Task<ObservableCollection<string>> GetFemaleNames(int maxCount)
    {
      var temp = new ObservableCollection<string>();
      int currentMaxCount = (_femaleNames.Length * _surNames.Length) > maxCount ? maxCount :
                                                                      (_femaleNames.Length * _surNames.Length);
      var q1 = from name in _femaleNames
               orderby _ran.NextDouble()
               select name;
      var q2 = from name in _surNames
               orderby _ran.NextDouble()
               select name;
      var firstResults = q1.ToArray();
      var surResults = q2.ToArray();
      for (int i = 0; i < maxCount; i++)
      {
        temp.Add(firstResults[i] + " " + surResults[i]);
      }
      await Task.Delay(random.Next(400, 600)); // simulate laggy code

      return temp;
    }
    Random random = new Random();
    public string GetMaleName()
    {
      var randomFirstIndex = _ran.Next(0, _maleNames.Length - 1);
      var randomSurIndex = _ran.Next(0, _surNames.Length - 1);
      return _maleNames[randomFirstIndex] + " " + _surNames[randomSurIndex];
    }

    public async Task<ObservableCollection<string>> GetMaleNames(int maxCount)
    {
      var temp = new ObservableCollection<string>();

      int currentMaxCount = (_maleNames.Length * _surNames.Length) > maxCount ? maxCount :
                                                                      (_maleNames.Length * _surNames.Length);
      var q1 = from name in _maleNames
               orderby _ran.NextDouble()
               select name;
      var q2 = from name in _surNames
               orderby _ran.NextDouble()
               select name;
      var firstResults = q1.ToArray();
      var surResults = q2.ToArray();
      for (int i = 0; i < maxCount; i++)
      {
        temp.Add(firstResults[i] + " " + surResults[i]);
      }
      await Task.Delay(random.Next(400, 600));// simulate laggy code
      return temp;
    }

  }

  public class NameRepository
  {

  }
}

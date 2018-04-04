using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
  internal static class EnumerableExtensions {

    public static IEnumerable<string> ContiguousList(this IEnumerable<int> candidateList) {
      return GetTheContiguousValues(candidateList).ToList();
    }
    public static string FormatAsContiguous(this IEnumerable<int> candidateList) {
      var result = string.Join(", ", GetTheContiguousValues(candidateList).ToList());
      return result;
    }
    private static IEnumerable<string> GetTheContiguousValues(IEnumerable<int> candidateList) {
      // works with ascending list of numbers, 
      int rangeStart = 0;
      int previous = 0;

      if (!candidateList.Any())
        yield break;

      rangeStart = previous = candidateList.FirstOrDefault();

      foreach (int n in candidateList.Skip(1)) {
        if (n - previous > 1) // sequence break - yield a sequence
        {
          if (previous > rangeStart) {
            yield return string.Format("{0}-{1}", rangeStart, previous);
          }
          else {
            yield return rangeStart.ToString();
          }
          rangeStart = n;
        }
        previous = n;
      }

      if (previous > rangeStart) {
        yield return string.Format("{0}-{1}", rangeStart, previous);
      }
      else {
        yield return rangeStart.ToString();
      }
    }

    public static IEnumerable<TSource> IndexRange<TSource>(this IList<TSource> source,
                                                           int fromIndex,
                                                           int toIndex) {

      int currentIndex = fromIndex;

      while (currentIndex <= toIndex) {
        yield return source[currentIndex];
        currentIndex++;
      }
    }
  }
}

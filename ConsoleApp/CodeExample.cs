using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp
{
	class CodeExample
	{
		// why are magic strings considered undesirable.

		// Mistyping. It's easy to mistype a string literal. 
		// Duplicated. String might be repeated everywhere.
		// Refactoring. It's easier to refactor strongly-typed identifiers. 
		// Code analysis: Invisible to tools like Intellisense and AutoComplete
		public static void DoWork()
		{
			// write the example code here...

			// Use NameOf to get the string value of a variable, type, or member.

			string name1;
			string name2;

			name1 = nameof(SaveFile);

			// using reflection

			var theType = typeof(CodeExample);
			var methodInfo = theType.GetMethod("SaveFile", BindingFlags.NonPublic | BindingFlags.Instance);
			name2 = methodInfo.Name;

		}
		private void SaveFile(string fileName)
		{
			// Example method
		}

		internal static void UseWithExceptions(string fileName)
		{

			if (fileName == null)
			{
				// old way
				throw new ArgumentNullException(paramName: "fileName");
				// with nameOf
				throw new ArgumentNullException(paramName: nameof(fileName));
			}
		}

		internal void UseWithEnums()
		{

			// old way
			var name1 = RoundingUnit.Day.ToString();

			// with nameof
			var name2 = nameof(RoundingUnit.Day);

			var unit = RoundingUnit.Hour;

			switch (unit)
			{

				case RoundingUnit.Day:
					Console.WriteLine(nameof(RoundingUnit.Day));
					break;
				case RoundingUnit.Hour:
					Console.WriteLine(nameof(RoundingUnit.Hour));
					break;
				case RoundingUnit.Minute:
					Console.WriteLine(nameof(RoundingUnit.Minute));
					break;
				case RoundingUnit.Second:
					Console.WriteLine(nameof(RoundingUnit.Second));
					break;
				default:
					break;
			}

		}

		internal void UseWithPropertyChanged()
		{
			this.FileCount = 5;
		}

		private int _fileCount;

		public int FileCount {
			get { return _fileCount; }
			set
			{
				_fileCount = value;
				RaisePropertyChanged(nameof(FileCount));
			}
		}
		private void RaisePropertyChanged(string propertyChanged)
		{
			if (propertyChanged == null)
			{
				throw new ArgumentNullException(nameof(propertyChanged));
			}

			// do stuff
		}
	}

	public enum RoundingUnit
	{
		Day,
		Hour,
		Minute,
		Second
	}
}

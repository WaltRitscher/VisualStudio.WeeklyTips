using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public static class BookStore
	{
		public static Book GetTopSeller()
		{
			// simulate get the top book


			var topBook = new Book { Author = "Walt Ritscher", Title = "HLSL and Pixel Shaders for XAML Developers", Price = 9.95M };
			return topBook;

		}

		public static void UpdateBookPrice(Book book, decimal percentChanged)
		{
			book.Price *= percentChanged;
			// update Database

		}
	}
}

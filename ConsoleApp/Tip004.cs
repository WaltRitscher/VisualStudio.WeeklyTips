using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTips.ConsoleApp {
	class Tip004 {

		// Use Code Clone feature to find similar code
		// Available in Visual Studio Enterprise only
		public async Task GetBlogText() {
		

			try
			{
				var client = new HttpClient();
				var uri = new Uri("http://www.xamlwonderland.com/");
				client.Timeout = TimeSpan.FromMilliseconds(4000);
				client.MaxResponseContentBufferSize = 65000;
				var response = await client.GetAsync(uri);
				var content = await response.Content.ReadAsStringAsync();

				Console.WriteLine(content);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
		

		}

		public async Task GetHomePageText() {
			// Remove duplicate code

			try
			{
				var client = new HttpClient();
				var uri = new Uri("http://www.visualstudio.com/");
				
				client.MaxResponseContentBufferSize = 65000;
				client.Timeout = TimeSpan.FromMilliseconds(3000);

				var response = await client.GetAsync(uri);
				var content = await response.Content.ReadAsStringAsync();

				Console.Write(content);
			}
			catch (WebException ex)
			{

				throw ex;
			}



		}
	}
}

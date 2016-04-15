using System;
using SQLite.Net.Interop;
using Xamarin.Forms;

//We need this dependency in order to establish compatibility in all platforms
[assembly: Dependency(typeof(XFEmployees.Droid.Config))]


namespace XFEmployees.Droid
{
	public class Config: IConfig
	{
		private string directoryDB;
		private ISQLitePlatform platform;

		#region IConfig implementation
		public string DirectoryDB {
			get 
			{
				//throw new NotImplementedException();
				if (string.IsNullOrEmpty(directoryDB)) 
				{
					//Android directory access
					directoryDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);	// MyDocuments
//					Console.WriteLine("***Path: " + System.Environment.SpecialFolder.Personal);

					//					//iOS directory access
					//					var directory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					//					directoryDB = System.IO.Path.Combine(directory, "..", "Library");
				}
				return directoryDB;
			}
		}
		public ISQLitePlatform Platform {
			get 
			{
//				throw new NotImplementedException();
//				if (platform == null) 
//				{
					platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
					return platform;
//				}
			}
		}
		#endregion

	}
}


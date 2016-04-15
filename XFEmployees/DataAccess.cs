using System;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace XFEmployees
{
	public class DataAccess: IDisposable
	{
		private SQLiteConnection connection;

		public DataAccess()
		{
			var config = DependencyService.Get<IConfig>();
			connection = new SQLiteConnection(config.Platform, Path.Combine(config.DirectoryDB, "Employees.db3"));
			connection.CreateTable<Employees>();
		}

		public void InsertEmployee(Employees employee = null)
		{
			connection.Insert(employee);
		}

//		public void UpdateEmployee(Employees employee = null)
		public void UpdateEmployee(Employees employee)
		{
			connection.Update(employee);
		}

//		public void DeleteEmployee(Employees employee = null)
		public void DeleteEmployee(Employees employee)
		{
			connection.Delete(employee);
		}

		public Employees GetEmployee(int employeeID = 0)
		{
			return connection.Table<Employees>().FirstOrDefault(c => c.EmployeeID == employeeID);
		}

		public List<Employees> GetEmployees(int employeeID = 0)
		{
			return connection.Table<Employees>().OrderBy(c => c.LastNames).ToList();
		}

		#region IDisposable implementation

		public void Dispose()
		{
			connection.Dispose();
		}

		#endregion
	}
}


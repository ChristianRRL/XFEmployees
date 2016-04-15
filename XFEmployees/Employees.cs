using System;
using SQLite.Net.Attributes;

namespace XFEmployees
{
	public class Employees
	{
		[PrimaryKey, AutoIncrement]
		public int EmployeeID { get; set; }
		public string FirstNames { get; set; }
		public string LastNames { get; set; }
		public DateTime ContractDate { get; set; }
		public decimal Salary { get; set; }
		public bool Active { get; set; }

		public override string ToString()
		{
//			return string.Format("[Employees: EmployeeID={0}, FirstNames={1}, LastNames={2}, ContractDate={3}, Salary={4}, Active={5}]", EmployeeID, FirstNames, LastNames, ContractDate, Salary, Active);
			return string.Format("{0}, {1}, {2}, {3}, {4}]", EmployeeID, FirstNames, LastNames, ContractDate, Salary, Active);
		}
//		public Employees()
//		{
//			
//		}
	}
}


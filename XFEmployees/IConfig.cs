using System;
using SQLite.Net.Interop;

namespace XFEmployees
{
	public interface IConfig
	{
		string DirectoryDB { get; }
		ISQLitePlatform Platform { get; }
	}
}


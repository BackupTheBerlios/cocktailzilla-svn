using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GotDotNet.ApplicationBlocks.Data;

namespace Data
{																							
	public class DBCon
	{
		private static AdoHelper m_helper;
		private static string m_connectionstring;
		public static AdoHelper Helper
		{
			get
			{
				if(m_helper==null) m_helper=AdoHelper.CreateHelper("mainDB");
				return m_helper;
			}
		} 
		
		public static string ConnectionString
		{
			get
			{
				if(m_connectionstring==null) m_connectionstring=ConfigurationSettings.AppSettings["ConnectionString"];
				return m_connectionstring;
			}
		}
	}
}
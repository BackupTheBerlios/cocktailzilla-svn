using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace DebugClasses
{

	public class MainClass
	{
		  public static void Main(string[] argv)
		  {

			IDataReader dr = DBCon.Helper.ExecuteReader(DBCon.ConnectionString, CommandType.Text, "SELECT * FROM "+"Cocktails");
			
			while(dr.Read())
			{	
			if(dr["name"]!=null)	
				Console.WriteLine(dr["name"].ToString());				
			}
					
		}
					
	}
}

/*
dirty implementation for MySqlHelper
*/

using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml;
using ByteFX.Data.MySqlClient;

namespace GotDotNet.ApplicationBlocks.Data
{

	public class MySqlServer : AdoHelper
	{

		public MySqlServer()
		{
		}

		protected override IDataParameter[] GetDataParameters(int size)
		{
			return null;
		}


		public override IDbConnection GetConnection( string connectionString )
		{
			return new MySqlConnection( connectionString );
		}


		public override IDbDataAdapter GetDataAdapter()
		{
			return new MySqlDataAdapter(); 
		}
		
		public override void DeriveParameters( IDbCommand cmd )
		{
		}

		public override IDataParameter GetParameter()
		{
			return new SqlParameter(); 
		}

		protected override void ClearCommand( IDbCommand command )
		{
		}

		public override void CleanParameterSyntax(IDbCommand command)
		{
		}
		
		public override XmlReader ExecuteXmlReader(IDbCommand command)
		{
			return null;
		}

		protected override void AddUpdateEventHandlers(IDbDataAdapter dataAdapter, RowUpdatingHandler rowUpdatingHandler, RowUpdatedHandler rowUpdatedHandler)
		{
		}


		protected void RowUpdating(object obj, SqlRowUpdatingEventArgs e)
		{
		}

		protected void RowUpdated(object obj, SqlRowUpdatedEventArgs e)
		{
		}
		
		protected override IDataParameter GetBlobParameter(IDbConnection connection, IDataParameter p)
		{
			return p;
		}
	}
}
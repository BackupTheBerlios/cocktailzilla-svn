/*
dirty implementation for SqlitelHelper
*/

using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml;
using Mono.Data.SqliteClient;


namespace GotDotNet.ApplicationBlocks.Data
{

	public class SqliteServer : AdoHelper
	{

		public SqliteServer()
		{
		}

		protected override IDataParameter[] GetDataParameters(int size)
		{
			return null;
		}


		public override IDbConnection GetConnection( string connectionString )
		{
			return new SqliteConnection( connectionString );
		}


		public override IDbDataAdapter GetDataAdapter()
		{
			return new SqliteDataAdapter(); 
		}
		
		public override void DeriveParameters( IDbCommand cmd )
		{
		}

		public override IDataParameter GetParameter()
		{
			return new SqliteParameter(); 
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
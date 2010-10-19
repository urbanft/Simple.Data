﻿using System;
using System.Data;
using System.Data.Common;

namespace Simple.Data.Mocking.Ado
{
    public class MockDbConnection : DbConnection
    {
        private readonly DataSet _schemaDataSet;

        public MockDbConnection()
        {
            
        }

        public MockDbConnection(DataSet schemaDataSet)
        {
            _schemaDataSet = schemaDataSet;
        }

        public DataTable DummyDataTable { get; set; }

        /// <summary>
        /// Starts a database transaction.
        /// </summary>
        /// <returns>
        /// An object representing the new transaction.
        /// </returns>
        /// <param name="isolationLevel">Specifies the isolation level for the transaction.</param>
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            
        }

        /// <summary>
        /// Changes the current database for an open connection.
        /// </summary>
        /// <param name="databaseName">Specifies the name of the database for the connection to use.</param><filterpriority>2</filterpriority>
        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public override string ConnectionString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override int ConnectionTimeout
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates and returns a <see cref="T:System.Data.Common.DbCommand"/> object associated with the current connection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Data.Common.DbCommand"/> object.
        /// </returns>
        protected override DbCommand CreateDbCommand()
        {
            return new MockDbCommand(this);
        }

        public override string Database
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the name of the database server to which to connect.
        /// </summary>
        /// <returns>
        /// The name of the database server to which to connect. The default value is an empty string.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public override string DataSource
        {
            get { throw new NotImplementedException(); }
        }

        public override void Open()
        {
            
        }

        /// <summary>
        /// Gets a string that represents the version of the server to which the object is connected.
        /// </summary>
        /// <returns>
        /// The version of the database. The format of the string returned depends on the specific type of connection you are using.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ServerVersion
        {
            get { throw new NotImplementedException(); }
        }

        public override ConnectionState State
        {
            get { throw new NotImplementedException(); }
        }

        public override DataTable GetSchema(string collectionName)
        {
            if (_schemaDataSet.Tables.Contains(collectionName))
            {
                return _schemaDataSet.Tables[collectionName];
            }

            return null;
        }
    }
}
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MommyCookBook.Application.Options;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlConnectionStringBuilder = Microsoft.Data.SqlClient.SqlConnectionStringBuilder;

namespace MommyCookBook.Infrastructure
{
    public sealed class SqlConnectionFactory(IOptions<DatabaseOptions> connectionString) : IDbConnectionFactory
    {
        private readonly DatabaseOptions _connectionString = connectionString.Value;

        public SqlConnection CreateConnection()
        => new (_connectionString.ConnectionString);

        public SqlConnection CreateConnection(SqlConnectionStringBuilder connectionStringBuilder)
        => new SqlConnection(connectionStringBuilder.ConnectionString);

        
    }
}

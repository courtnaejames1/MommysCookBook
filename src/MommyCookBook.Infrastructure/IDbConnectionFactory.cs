using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace MommyCookBook.Infrastructure
{
    public interface IDbConnectionFactory
    {
        SqlConnection CreateConnection();

        SqlConnection CreateConnection(SqlConnectionStringBuilder connectionStringBuilder);
    }
}

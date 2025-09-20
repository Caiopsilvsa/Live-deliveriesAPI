// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

namespace Infrastructure.Abstractions;

public interface ISqlConnectionFactory
{
    SqlConnection CreateConnection();
}

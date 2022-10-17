using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap01;

public class ConnectionFactory
{
    public IDbConnection GetConnection()
    {
        IDbConnection conexao = new SqlConnection();
        conexao.ConnectionString = "Server=.;Database=alura;User Id=sa;Password=123456";
        conexao.Open();

        return conexao;
    }
}
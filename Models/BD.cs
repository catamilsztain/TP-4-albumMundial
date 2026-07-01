using Dapper;
using Microsoft.Data.SqlClient;

public class BD{
    private string _connectionString =
     @"Server=localhost;DataBase=Album;Integrated Security=True;TrustServerCertificate=True;";

    public void Pegar (int fichu){
        string query = "UPDATE Figuritas SET contadorRepe = contadorRepe + 1 WHERE figu = @pfichu";
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Execute(query, new { pfichu = fichu })
        }
    }
}
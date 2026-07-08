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

    public Jugadores[] ObtenerJugador(int[] figuritasSobre){
        Jugadores[] jugadores = new Jugadores[6];
        for(int i = 0; i<figuritasSobre.lenght; i++ ){
            string query = "SELECT * FROM Jugadores WHERE Número = @pfichu";
            using(SqlConnection connection = new SqlConnection(_connectionString)){
                jugadores[i] = connection.QueryFirstOrDefault<Jugadores>(query, new {pfichu = figuritasSobre[i]})
            }
        }
        return jugadores;
    }
}
using Dapper;
using Microsoft.Data.SqlClient;

public class BD{
    private static string _connectionString =
     @"Server=localhost;DataBase=Album;Integrated Security=True;TrustServerCertificate=True;";

    public static void SumarRepetida(int jugadorcitoId){
        string query = "UPDATE Figuritas SET contadorRepe = contadorRepe + 1 WHERE IdJugador = @pjugador";
        using(SqlConnection connection = new SqlConnection(_connectionString)){
            connection.Execute(query, new {pjugador = jugadorcitoId})
        }
    }

    public static List<Figurita> ObtenerAlbum()
    {
    string query = "SELECT * FROM Figuritas WHERE ContadorRepe > 0";

    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        return connection.Query<Figurita>(query).ToList();
    }
    }
    

    public static Jugadores[] ObtenerJugador(int[] figuritasSobre){
        Jugadores[] jugadores = new Jugadores[6];
        for(int i = 0; i<figuritasSobre.Length; i++ ){
            string query = "SELECT * FROM Jugadores WHERE ID = @pfichu";
            using(SqlConnection connection = new SqlConnection(_connectionString)){
                jugadores[i] = connection.QueryFirstOrDefault<Jugadores>(query, new {pfichu = figuritasSobre[i]});
            }
        }
        return jugadores;
    }
}


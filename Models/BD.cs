using Dapper;
using Microsoft.Data.SqlClient;

public class BD{
    private static string _connectionString =
     @"Server=localhost;DataBase=Album;Integrated Security=True;TrustServerCertificate=True;";

    public static void Pegar (int fichu){
        string query = "UPDATE Figuritas SET contadorRepe = contadorRepe + 1 WHERE figu = @pfichu";
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Execute(query, new { pfichu = fichu });
        }
    }

    //TENES QUE HACER QUE PASE EL OBJETO POR PARAMETRO PARA PODER INSERTARLO EN LA BASE DE DATOS Y DESPUES CON OTRO METODO LO UPDATES EL CONTADOR REPE PUTA

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


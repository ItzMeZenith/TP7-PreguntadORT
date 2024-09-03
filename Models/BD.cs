using System.Data.SqlClient;
using Dapper;
namespace TP7_PreguntadORT.Models;

public static class BD
{
    private static string _ConnectionString = "Server=localhost;DataBase=heladeria;Trusted_Connection=true;";

    public static List<Categorias> ObtenerCategorias(){
        List<Categorias> ListaCategorias = new List<Categorias>();
        using(SqlConnection conn = new SqlConnection(_ConnectionString)){
            string sql="SELECT * FROM Categorias";
            ListaCategorias = conn.Query<Categorias>(sql).ToList();
        }
        return ListaCategorias;
    }

        public static List<Dificultades> ObtenerDificultades(){
        List<Dificultades> ListaDificultades = new List<Dificultades>();
        using(SqlConnection conn = new SqlConnection(_ConnectionString)){
            string sql="SELECT * FROM Dificultades";
            ListaDificultades = conn.Query<Dificultades>(sql).ToList();
        }
        return ListaDificultades;
    }
}

    
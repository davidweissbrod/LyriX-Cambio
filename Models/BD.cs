using System.Data.SqlClient;
using Dapper;
namespace LyriX_Cambio.Models;
public static class BD{
    private static string _connectionString = @"Server=localhost;DataBase=BD_LyriX;Trusted_Connection=True;";
    public static List<Albumes> ObtenerAlbumesPorArtista(int IdArtista){
        string sql = "SELECT * FROM Albumes WHERE IdArtista = @pIdArtista";
        List<Albumes> listaA = new List<Albumes>{};
        using(SqlConnection db = new SqlConnection(_connectionString)){  
            listaA = db.Query<Albumes>(sql, new {pIdArtista = IdArtista}).ToList();
        }
        return listaA;
    }
    public static List<Artistas> ObtenerArtistas(){
        string sql = "SELECT TOP 5 * FROM Artistas ORDER BY NEWID()";
        List<Artistas> devolver = new List<Artistas>{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.Query<Artistas>(sql).ToList();
        }
        return devolver;
    }
    public static List<Canciones> ObtenerCancionesPorAlbum(int IdAlbum){
        string sql = "SELECT * FROM Canciones WHERE IdAlbum = @pIdAlbum";
        List<Canciones> listaC = new List<Canciones>{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            listaC = db.Query<Canciones>(sql, new {pIdAlbum = IdAlbum}).ToList();
        }
        return listaC;
    }
    public static Artistas ObtenerInfoArtista(int IdArtista){
        string sql = "SELECT * FROM Artistas WHERE IdArtista = @pIdArtista";
        Artistas devolver;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.QueryFirstOrDefault<Artistas>(sql, new {pIdArtista = IdArtista});
        }
        return devolver;
    }
    public static Usuarios ObtenerInfoUser(int IdUsuario){
        string sql = "SELECT * FROM Usuarios WHERE IdUsuario = @pIdUsuario";
        Usuarios devolver;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.QueryFirstOrDefault<Usuarios>(sql, new {pIdUsuario = IdUsuario});
        }
        return devolver;
    }
    public static void InsertarUsuario(string nom, string ma , DateTime fn, string con){
        string sql = "exec sp_CrearUsuario @nom, @ma, @fn, @con";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new {@nom = nom, @ma = ma, @fn = fn, @con = con});
        }
    }
    public static void InsertarDescripcion(string desc, int IdUsuario){
        string sql = "UPDATE Usuarios SET Descripcion = @desc WHERE IdUsuario = @pIdUsuario";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new {@desc = desc, @pIdUsuario = IdUsuario});
        }
    }
    public static void InsertarInstagram(string insta, int IdUsuario){
        insta = "instagram.com/" + insta;
        string sql = "UPDATE Usuarios SET Instaram = @insta WHERE IdUsuario = @pIdUsuario";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new {@insta = insta, @pIdUsuario = IdUsuario});
        }
    }
    public static void InsertarTwitter(string twit, int IdUsuario){
        twit = "twitter.com/" + twit;
        string sql = "UPDATE Usuarios SET Twitter = @twit WHERE IdUsuario = @pIdUsuario";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new {@twit = twit, @pIdUsuario = IdUsuario});
        }
    }
    public static Usuarios IniciarSesion(string nombre, string contra){
        string sql = "SELECT * FROM Usuarios WHERE NombreUsuario = @pnombre AND Contrasenia = @pcontrasenia";
        Usuarios devolver;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.QueryFirstOrDefault<Usuarios>(sql, new {pnombre = nombre, pcontrasenia = contra});
        }
        return devolver;
    }

        public static List<Canciones> ObtenerCancionesCarrusel(){
        string sql = "SELECT TOP 5 * FROM Canciones ORDER BY NEWID()";
        List<Canciones> devolver = new List<Canciones>{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.Query<Canciones>(sql).ToList();
        }
        return devolver;
    }

    public static List<Albumes> ObtenerAlbumesCarrusel(){
        string sql = "SELECT TOP 5 * FROM Albumes ORDER BY NEWID()";
        List<Albumes> devolver = new List<Albumes>{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.Query<Albumes>(sql).ToList();
        }
        return devolver;
    }
    public static Artistas ObtenerArtistaPorId(int IdAr){
        string sql = "SELECT * FROM Artistas WHERE IdArtista = @pIdArtista";
        Artistas devolver = new Artistas{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.QueryFirstOrDefault<Artistas>(sql,new {pIdArtista = IdAr});
        }
        return devolver;
    }
    public static Canciones ObtenerCancionPorId(int IdCan){
        string sql = "SELECT * FROM Canciones WHERE IdCancion = @pIdCancion";
        Canciones devolver = new Canciones{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.QueryFirstOrDefault<Canciones>(sql,new {pIdCancion = IdCan});
        }
        return devolver;
    }

    public static Albumes ObtenerAlbumPorId(int IdAlb){
        string sql = "SELECT * FROM Albumes WHERE IdAlbum = @pIdAlbum";
        Albumes devolver = new Albumes{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.QueryFirstOrDefault<Albumes>(sql,new {pIdAlbum = IdAlb});
        }
        return devolver;
    }
    public static List<Canciones> ObtenerCancionesPorArtista(int IdAr){
        string sql = "SELECT * FROM Canciones WHERE IdArtista = @pIdArtista";
        List<Canciones> devolver = new List<Canciones>{};
        using(SqlConnection db = new SqlConnection(_connectionString)){
            devolver = db.Query<Canciones>(sql,new {pIdArtista = IdAr}).ToList();
        }
        return devolver;
    }
    
}
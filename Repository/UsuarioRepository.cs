using System.Data.SQLite;
using Models;
namespace RepositorioUsuario;

public class UsuarioRepository: IUsuarioRepository
{
    private readonly string _cadenaDeConexion = "Data Source=DB/kanban.db;Cache=Shared";

    public void CreateUsuario(Usuario usuario)
    {
        var query = $"INSERT INTO usuario(nombre_de_usuario) VALUES(@nombre)";

        using (SQLiteConnection conexion = new SQLiteConnection(_cadenaDeConexion))
        {
            conexion.Open();
            var command = new SQLiteCommand(query,conexion);
            command.Parameters.Add(new SQLiteParameter("@nombre", usuario.Nombre_de_usuario));
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
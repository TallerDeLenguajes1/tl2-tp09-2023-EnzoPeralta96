using Models;
namespace RepositorioUsuario;

public interface IUsuarioRepository
{
    public void CreateUsuario(Usuario usuario);
   /* public void UpdateUsuario(int idUsuario,Usuario usuario);
    public List<Usuario> GetAllUsuarios();
    public Usuario GetUsuarioById(int idUsuario);
    public void DeleteUsuarioById(int idUsuario);*/
}